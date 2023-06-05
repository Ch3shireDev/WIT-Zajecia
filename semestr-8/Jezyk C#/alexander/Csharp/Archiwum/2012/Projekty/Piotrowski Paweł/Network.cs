using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace CircleCross
{
	public class Network
	{
		#region Variables 
		frmCircleCross objCircleCross=null;
		public Thread thread_receive_client;
		public Thread thread_receive_server;
		private string wServerIP;
		const int SERVERPORT=9870;
		bool wReceivingServer=true;
		bool wReceivingClient=true;
		NetworkStream clientSockStream;
		NetworkStream serverSockStream; 
		TcpClient tcpClient;
		TcpListener tcpListener;
		Socket soTcpServer;
		#endregion

		#region Constructor 

		public Network(frmCircleCross pThis)
		{
		   	objCircleCross=pThis;
		}
		#endregion

		#region Client 

		public void ConnectServer(string pIP)
		{
			wServerIP=pIP;
			byte[] buf = new byte[1];
			thread_receive_client = new Thread(new ThreadStart(ThreadReceivingClient));
			thread_receive_client.Start();
		}

        private void ThreadReceivingClient()
        {
            try
            {
                byte[] buf = new byte[512];
                int bytesReceived = 0;
                tcpClient = new TcpClient(wServerIP, SERVERPORT);
                clientSockStream = tcpClient.GetStream();
                objCircleCross.RestartGame();
                objCircleCross.SetStatusMessage("Connected!");
                wReceivingClient = true;

                while (wReceivingClient)
                {
                    try
                    {
                        bytesReceived = clientSockStream.Read(buf, 0, 2);
                    }
                    catch
                    {
                        return;
                    }

                    if (bytesReceived > 0)
                    {
                        if (buf[0] == byte.Parse(Asc("R").ToString()))
                        {
                            objCircleCross.RestartGame();
                            continue;
                        }
                        int wRow = int.Parse(Convert.ToChar(buf[0]).ToString());
                        int wColumn = int.Parse(Convert.ToChar(buf[1]).ToString());

                        if ((wRow > 0 && wRow < 4) && (wColumn > 0 && wColumn < 4))
                        {
                            objCircleCross.wNetworkPlay = true;
                            objCircleCross.MakeMove(wRow, wColumn);
                        }

                    } //if (bytesReceived>0) 

                } //while (wReceivingClient)

            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred: " + ex.Message + "\n" + ex.StackTrace);
                objCircleCross.mnDisconnect_Click(null, null);
                return;
            }
        }
		#endregion

		#region Server 
 
		public void StartServer()
		{
			thread_receive_server = new Thread(new ThreadStart(ThreadReceivingServer));
			thread_receive_server.Start();
		}
		private void ThreadReceivingServer()
		{
			try 
			{
				byte[] buf = new byte[512];
                IPAddress localHostEntry = IPAddress.Any; //use local IP addres
				int bytesReceived=0;
				tcpListener = new TcpListener(localHostEntry,SERVERPORT);
				tcpListener.Start();
				soTcpServer = tcpListener.AcceptSocket();
				serverSockStream = new NetworkStream(soTcpServer);
				objCircleCross.RestartGame();
				objCircleCross.SetStatusMessage("Connected!");
				wReceivingServer=true;
				while (wReceivingServer)
				{
					try 
					{
						bytesReceived=serverSockStream.Read(buf,0,2);
					}
					catch
					{
						return;
					}
					if (bytesReceived>0) 
					{
						if (buf[0]==byte.Parse(Asc("R").ToString()))
						{
							objCircleCross.RestartGame();
							continue;
						}
						int wRow=int.Parse(Convert.ToChar(buf[0]).ToString());
						int wColumn=int.Parse(Convert.ToChar(buf[1]).ToString());

						if ((wRow>0 && wRow<4) && (wColumn>0 && wColumn<4))
						{
							objCircleCross.wNetworkPlay=true;
							objCircleCross.MakeMove(wRow,wColumn);
						}

					}	//if (bytesReceived>0) 
			
				}	//while (wReceivingServer)
			}
			catch (ThreadAbortException) {}
			catch (Exception ex)
			{
				MessageBox.Show("An error ocurred: " + ex.Message + "\n" + ex.StackTrace);
				objCircleCross.mnDisconnect_Click(null,null);
				return;
			}
		}
		#endregion
		#region Wysylanie pakietow / disconnect
		public void SendPacketTCP(Byte[] pDados)
		{
			try
			{
				if (objCircleCross.wClient==true)
				{
					if (clientSockStream==null)
						return;

					if (clientSockStream.CanWrite)
					{
						clientSockStream.Write(pDados, 0, 2);
						clientSockStream.Flush();
					}
				}
				else
				{
					if (serverSockStream==null)
						return;

					if (serverSockStream.CanWrite)
					{
						serverSockStream.Write(pDados,0, 2);
						serverSockStream.Flush();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error ocurred: " + ex.Message + "\n" + ex.StackTrace);
				objCircleCross.mnDisconnect_Click(null,null);
				return;
			}
		}
		public void SendMove(int wRow,int wColumn)
		{
			byte[] buf = new byte[2];
			buf[0]=byte.Parse(Asc(wRow.ToString()).ToString());
			buf[1]=byte.Parse(Asc(wColumn.ToString()).ToString());
			SendPacketTCP(buf);
		}
		public void SendsRestartPacket()
		{
			byte[] buf = new byte[2];
			buf[0]=byte.Parse(Asc("R").ToString());
			buf[1]=0;
			SendPacketTCP(buf);
		}
		public void Disconnect()
		{
			if (objCircleCross.wClient==true)
			{
				thread_receive_client.Abort();
				wReceivingClient=false;
				if (clientSockStream!=null)
					clientSockStream.Close();
				if (tcpClient!=null)
					tcpClient.Close();
			}
			if (objCircleCross.wServer==true)
			{
				thread_receive_server.Abort();	
				wReceivingServer=false;
				if (serverSockStream!=null)
					serverSockStream.Close();
				if (tcpListener!=null)
					tcpListener.Stop();
				if (soTcpServer!=null)
					soTcpServer.Shutdown(SocketShutdown.Both);	
			}
		}
		private static int Asc(string character)
		{
			if (character.Length == 1)
			{
				System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
				int intAsciiCode = (int)asciiEncoding.GetBytes(character)[0];
				return (intAsciiCode);
			}
			else
			{
				throw new ApplicationException("Character is not valid.");
			}
		}
		#endregion
	}
}
