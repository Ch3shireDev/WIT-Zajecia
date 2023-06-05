using System.Net;
using System.Threading;
        

        TcpListener srv = new TcpListener(IPAddress.Any, port);
        if(srv.Pending())
        Socket conn = srv.AcceptSocket();
        Thread th = new Thread(ClnLoop);
        th.Start(conn);


        TcpClient cln = new TcpClient();
        cln.Connect(EdHost.Text, port);
        Socket conn = cln.Client;

        conn.Send(UTF8Encoding.UTF8.GetBytes(text));
	if (conn.Poll(10, SelectMode.SelectRead))
        int len = conn.Available;
        byte[] buff;
        conn.Receive(buff);
        string text=UTF8Encoding.UTF8.GetString(buff);