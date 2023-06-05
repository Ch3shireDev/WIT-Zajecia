using System;

namespace CircleCross
{

	public class GameAI
	{
		private enPlayType wTypeCPU;
		private enPlayType wTypePlayer;
		private enDifficulty wDifficulty;
		frmCircleCross objCircleCross;
		#region Constructor 
		public GameAI(frmCircleCross objForm)
		{
			objCircleCross=objForm;
			wTypeCPU=objCircleCross.wTypeCPU;
			wTypePlayer=objCircleCross.wTypePlayer;
			wDifficulty=objCircleCross.wDifficulty;
		}
		#endregion
		#region Game (1 player) 
		public void MakeComputerMove()
		{
			bool wNothing=false;
			if (objCircleCross.wTurn==wTypePlayer)
				return;
            PlayWinner(false,ref wNothing);
			if (objCircleCross.wTurn==wTypePlayer)
				return;
			PlayDefensive();
			if (objCircleCross.wTurn==wTypePlayer)
				return;
			PlayOffensive();

		}
		private void PlayWinner(bool pJustVerifyMove,ref bool rGoodMove)
		{

			if (wDifficulty==enDifficulty.Average)
			{
				rGoodMove=true;
				return;
			}
			int wSum1=(int)objCircleCross.wBoard[1,1]+(int)objCircleCross.wBoard[1,2]+(int)objCircleCross.wBoard[1,3];
			int wSum2=(int)objCircleCross.wBoard[2,1]+(int)objCircleCross.wBoard[2,2]+(int)objCircleCross.wBoard[2,3];
			int wSum3=(int)objCircleCross.wBoard[3,1]+(int)objCircleCross.wBoard[3,2]+(int)objCircleCross.wBoard[3,3];
			int wSum4=(int)objCircleCross.wBoard[1,1]+(int)objCircleCross.wBoard[2,1]+(int)objCircleCross.wBoard[3,1];
			int wSum5=(int)objCircleCross.wBoard[1,2]+(int)objCircleCross.wBoard[2,2]+(int)objCircleCross.wBoard[3,2];
			int wSum6=(int)objCircleCross.wBoard[1,3]+(int)objCircleCross.wBoard[2,3]+(int)objCircleCross.wBoard[3,3];
			int wSum7=(int)objCircleCross.wBoard[1,1]+(int)objCircleCross.wBoard[2,2]+(int)objCircleCross.wBoard[3,3];
			int wSum8=(int)objCircleCross.wBoard[3,1]+(int)objCircleCross.wBoard[2,2]+(int)objCircleCross.wBoard[1,3];
			int wCPUSum=0;
			if (wTypeCPU==enPlayType.Cross)
				wCPUSum=20;
			else
				wCPUSum=2;

			if (wSum1==wCPUSum)
			{
				if (objCircleCross.wBoard[1,1]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(1,1);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[1,2]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(1,2);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[1,3]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(1,3);
					rGoodMove=true;
					return;
				}
			}
			if (wSum2==wCPUSum)
			{
				if (objCircleCross.wBoard[2,1]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(2,1);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[2,2]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(2,2);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[2,3]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(2,3);
					rGoodMove=true;
					return;
				}
			}
			if (wSum3==wCPUSum)
			{
				if (objCircleCross.wBoard[3,1]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(3,1);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[3,2]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(3,2);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[3,3]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(3,3);
					rGoodMove=true;
					return;
				}
			}
			if (wSum4==wCPUSum)
			{
				if (objCircleCross.wBoard[1,1]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(1,1);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[2,1]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(2,1);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[3,1]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(3,1);
					rGoodMove=true;
					return;
				}
			}
			if (wSum5==wCPUSum)
			{
				if (objCircleCross.wBoard[1,2]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(1,2);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[2,2]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(2,2);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[3,2]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(3,2);
					rGoodMove=true;
					return;
				}
			}
			if (wSum6==wCPUSum)
			{
				if (objCircleCross.wBoard[1,3]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(1,3);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[2,3]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(2,3);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[3,3]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(3,3);
					rGoodMove=true;
					return;
				}
			}
			if (wSum7==wCPUSum)
			{
				if (objCircleCross.wBoard[1,1]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(1,1);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[2,2]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(2,2);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[3,3]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(3,3);
					rGoodMove=true;
					return;
				}
			}
			if (wSum8==wCPUSum)
			{
				if (objCircleCross.wBoard[3,1]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(3,1);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[2,2]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(2,2);
					rGoodMove=true;
					return;
				}
				if (objCircleCross.wBoard[1,3]==enPlayType.None)
				{
					if (pJustVerifyMove==false)
						objCircleCross.MakeMove(1,3);
					rGoodMove=true;
					return;
				}
			}
		}
		private void PlayDefensive()
		{
			if (wDifficulty==enDifficulty.Average)		
			{
				System.Threading.Thread.Sleep(15);
				System.Random objRandom=new Random();
				int rnd=objRandom.Next(1,6);
				if (rnd==3)
					return;
			}
			if (wDifficulty==enDifficulty.Easy)		
			{
				System.Threading.Thread.Sleep(15);
				System.Random objRandom=new Random();
				int rnd=objRandom.Next(1,3);
				if (rnd==1)
					return;
			}
			int wSum1=(int)objCircleCross.wBoard[1,1]+(int)objCircleCross.wBoard[1,2]+(int)objCircleCross.wBoard[1,3];
			int wSum2=(int)objCircleCross.wBoard[2,1]+(int)objCircleCross.wBoard[2,2]+(int)objCircleCross.wBoard[2,3];
			int wSum3=(int)objCircleCross.wBoard[3,1]+(int)objCircleCross.wBoard[3,2]+(int)objCircleCross.wBoard[3,3];
			int wSum4=(int)objCircleCross.wBoard[1,1]+(int)objCircleCross.wBoard[2,1]+(int)objCircleCross.wBoard[3,1];
			int wSum5=(int)objCircleCross.wBoard[1,2]+(int)objCircleCross.wBoard[2,2]+(int)objCircleCross.wBoard[3,2];
			int wSum6=(int)objCircleCross.wBoard[1,3]+(int)objCircleCross.wBoard[2,3]+(int)objCircleCross.wBoard[3,3];
			int wSum7=(int)objCircleCross.wBoard[1,1]+(int)objCircleCross.wBoard[2,2]+(int)objCircleCross.wBoard[3,3];
			int wSum8=(int)objCircleCross.wBoard[3,1]+(int)objCircleCross.wBoard[2,2]+(int)objCircleCross.wBoard[1,3];
			int wPlayerSum=0;

			if (wTypePlayer==enPlayType.Cross)
				wPlayerSum=20;
			else
				wPlayerSum=2;

			if (wSum1==wPlayerSum)
			{
				if (objCircleCross.wBoard[1,1]==enPlayType.None) {
					objCircleCross.MakeMove(1,1);return;}
				if (objCircleCross.wBoard[1,2]==enPlayType.None) {
					objCircleCross.MakeMove(1,2);return;}
				if (objCircleCross.wBoard[1,3]==enPlayType.None) {
					objCircleCross.MakeMove(1,3);return;}
			}
			if (wSum2==wPlayerSum)
			{
				if (objCircleCross.wBoard[2,1]==enPlayType.None) {
					objCircleCross.MakeMove(2,1);return;}
				if (objCircleCross.wBoard[2,2]==enPlayType.None) {
					objCircleCross.MakeMove(2,2);return;}
				if (objCircleCross.wBoard[2,3]==enPlayType.None) {
					objCircleCross.MakeMove(2,3);return;}
			}
			if (wSum3==wPlayerSum)
			{
				if (objCircleCross.wBoard[3,1]==enPlayType.None) {
					objCircleCross.MakeMove(3,1);return;}
				if (objCircleCross.wBoard[3,2]==enPlayType.None) {
					objCircleCross.MakeMove(3,2);return;}
				if (objCircleCross.wBoard[3,3]==enPlayType.None) {
					objCircleCross.MakeMove(3,3);return;}
			}
			if (wSum4==wPlayerSum)
			{
				if (objCircleCross.wBoard[1,1]==enPlayType.None) {
					objCircleCross.MakeMove(1,1);return;}
				if (objCircleCross.wBoard[2,1]==enPlayType.None) {
					objCircleCross.MakeMove(2,1);return;}
				if (objCircleCross.wBoard[3,1]==enPlayType.None) {
					objCircleCross.MakeMove(3,1);return;}
			}
			if (wSum5==wPlayerSum)
			{
				if (objCircleCross.wBoard[1,2]==enPlayType.None) {
					objCircleCross.MakeMove(1,2);return;}
				if (objCircleCross.wBoard[2,2]==enPlayType.None) {
					objCircleCross.MakeMove(2,2);return;}
				if (objCircleCross.wBoard[3,2]==enPlayType.None) {
					objCircleCross.MakeMove(3,2);return;}
			}
			if (wSum6==wPlayerSum)
			{
				if (objCircleCross.wBoard[1,3]==enPlayType.None) {
					objCircleCross.MakeMove(1,3);return;}
				if (objCircleCross.wBoard[2,3]==enPlayType.None) {
					objCircleCross.MakeMove(2,3);return;}
				if (objCircleCross.wBoard[3,3]==enPlayType.None) {
					objCircleCross.MakeMove(3,3);return;}
			}
			if (wSum7==wPlayerSum)
			{
				if (objCircleCross.wBoard[1,1]==enPlayType.None) {
					objCircleCross.MakeMove(1,1);return;}
				if (objCircleCross.wBoard[2,2]==enPlayType.None) {
					objCircleCross.MakeMove(2,2);return;}
				if (objCircleCross.wBoard[3,3]==enPlayType.None) {
					objCircleCross.MakeMove(3,3);return;}
			}
			if (wSum8==wPlayerSum)
			{
				if (objCircleCross.wBoard[3,1]==enPlayType.None) {
					objCircleCross.MakeMove(3,1);return;}
				if (objCircleCross.wBoard[2,2]==enPlayType.None) {
					objCircleCross.MakeMove(2,2);return;}
				if (objCircleCross.wBoard[1,3]==enPlayType.None) {
					objCircleCross.MakeMove(1,3);return;}
			}
		}

		private void PlayOffensive()
		{
		
			bool wGoodMove=false;
   			if (wDifficulty==enDifficulty.Hard)
			{
				if (wTypePlayer==enPlayType.Cross)
				{
				
					if ((objCircleCross.wBoard[1,1]==enPlayType.None) && (objCircleCross.wBoard[3,3]==wTypePlayer))
					{
						objCircleCross.MakeMove(1,1);
						return;
					}
									
					if ((objCircleCross.wBoard[1,3]==enPlayType.None) && (objCircleCross.wBoard[3,1]==wTypePlayer))
					{
						objCircleCross.MakeMove(1,3);
						return;
					}
					
					if ((objCircleCross.wBoard[3,1]==enPlayType.None) && (objCircleCross.wBoard[1,3]==wTypePlayer))
					{
						objCircleCross.MakeMove(3,1);
						return;
					}
					
					if ((objCircleCross.wBoard[3,3]==enPlayType.None) && (objCircleCross.wBoard[1,1]==wTypePlayer))
					{
						objCircleCross.MakeMove(3,3);
						return;
					}
				}
				else
				{
                    if (objCircleCross.wBoard[2,2]==enPlayType.None)
					{
						objCircleCross.MakeMove(2,2);
						return;
					}
				}
			}
			
			if (wDifficulty==enDifficulty.Hard)
			{

				if ((objCircleCross.wBoard[1,2]==enPlayType.None) && ((objCircleCross.wBoard[1,3]==wTypePlayer) && (objCircleCross.wBoard[3,1]==wTypePlayer)))
				{
					objCircleCross.wBoard[1,2]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[1,2]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(1,2);
						return;
					}
				}

				if ((objCircleCross.wBoard[3,2]==enPlayType.None) && ((objCircleCross.wBoard[1,3]==wTypePlayer) && (objCircleCross.wBoard[3,1]==wTypePlayer)))
				{
					objCircleCross.wBoard[3,2]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[3,2]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(3,2);
						return;
					}
				}

				if ((objCircleCross.wBoard[1,2]==enPlayType.None) && ((objCircleCross.wBoard[1,1]==wTypePlayer) && (objCircleCross.wBoard[3,3]==wTypePlayer)))
				{
					objCircleCross.wBoard[1,2]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[1,2]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(1,2);
						return;
					}
				}

				if ((objCircleCross.wBoard[3,2]==enPlayType.None) && ((objCircleCross.wBoard[1,1]==wTypePlayer) && (objCircleCross.wBoard[3,3]==wTypePlayer)))
				{
					objCircleCross.wBoard[3,2]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[3,2]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(3,2);
						return;
					}
				}
				
				if ((objCircleCross.wBoard[1,2]==enPlayType.None) && ((objCircleCross.wBoard[2,1]==wTypePlayer) && (objCircleCross.wBoard[3,3]==wTypePlayer)))
				{
					objCircleCross.wBoard[1,2]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[1,2]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(1,2);
						return;
					}
				}

				if ((objCircleCross.wBoard[2,1]==enPlayType.None) && ((objCircleCross.wBoard[1,1]==wTypePlayer) && (objCircleCross.wBoard[3,2]==wTypePlayer)))
				{
					objCircleCross.wBoard[2,1]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[2,1]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(2,1);
						return;
					}
				}

				if ((objCircleCross.wBoard[2,3]==enPlayType.None) && ((objCircleCross.wBoard[1,3]==wTypePlayer) && (objCircleCross.wBoard[3,2]==wTypePlayer)))
				{
					objCircleCross.wBoard[2,3]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[2,3]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(2,3);
						return;
					}
				}

				if ((objCircleCross.wBoard[3,2]==enPlayType.None) && ((objCircleCross.wBoard[2,3]==wTypePlayer) && (objCircleCross.wBoard[3,1]==wTypePlayer)))
				{
					objCircleCross.wBoard[3,2]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[3,2]=enPlayType.None;
  					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(3,2);
						return;
					}
				}

				if ((objCircleCross.wBoard[2,3]==enPlayType.None) && ((objCircleCross.wBoard[3,1]==wTypePlayer) && (objCircleCross.wBoard[1,2]==wTypePlayer)))
				{
					objCircleCross.wBoard[2,3]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[2,3]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(2,3);
						return;
					}
				}

				if ((objCircleCross.wBoard[2,1]==enPlayType.None) && ((objCircleCross.wBoard[1,1]==wTypePlayer) && (objCircleCross.wBoard[3,2]==wTypePlayer)))
				{
					objCircleCross.wBoard[2,1]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[2,1]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(2,1);
						return;
					}
				}

				if ((objCircleCross.wBoard[1,1]==enPlayType.None) && ((objCircleCross.wBoard[1,2]==wTypePlayer) && (objCircleCross.wBoard[2,1]==wTypePlayer)))
				{
					objCircleCross.wBoard[1,1]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[1,1]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(1,1);
						return;
					}
				}

				if ((objCircleCross.wBoard[1,3]==enPlayType.None) && ((objCircleCross.wBoard[1,2]==wTypePlayer) && (objCircleCross.wBoard[2,3]==wTypePlayer)))
				{
					objCircleCross.wBoard[1,3]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[1,3]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(1,3);
						return;
					}
				}

				if ((objCircleCross.wBoard[3,3]==enPlayType.None) && ((objCircleCross.wBoard[2,3]==wTypePlayer) && (objCircleCross.wBoard[3,2]==wTypePlayer)))
				{
					objCircleCross.wBoard[3,3]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[3,3]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(3,3);
						return;
					}
				}

				if ((objCircleCross.wBoard[3,1]==enPlayType.None) && ((objCircleCross.wBoard[2,1]==wTypePlayer) && (objCircleCross.wBoard[3,2]==wTypePlayer)))
				{
					objCircleCross.wBoard[3,1]=wTypeCPU;
					PlayWinner(true,ref wGoodMove);
					objCircleCross.wBoard[3,1]=enPlayType.None;

					if (wGoodMove==true)
					{
						objCircleCross.MakeMove(3,1);
						return;
					}
				}
   			}
            System.Threading.Thread.Sleep(15);
			System.Random objRandom=new Random();
			int rnd=objRandom.Next(1,5);

			int[] wPosicaoPontaX = new int[5];
			int[] wPosicaoPontaY = new int[5];
		
			if (rnd==1)
			{
				wPosicaoPontaX[1]=1;wPosicaoPontaY[1]=1;
				wPosicaoPontaX[2]=1;wPosicaoPontaY[2]=3;
				wPosicaoPontaX[3]=3;wPosicaoPontaY[3]=1;
				wPosicaoPontaX[4]=3;wPosicaoPontaY[4]=3;
			}
			if (rnd==2)
			{
				wPosicaoPontaX[1]=1;wPosicaoPontaY[1]=3;
				wPosicaoPontaX[2]=3;wPosicaoPontaY[2]=1;
				wPosicaoPontaX[3]=3;wPosicaoPontaY[3]=3;
				wPosicaoPontaX[4]=1;wPosicaoPontaY[4]=1;
			}
			if (rnd==3)
			{			
				wPosicaoPontaX[1]=3;wPosicaoPontaY[1]=1;
				wPosicaoPontaX[2]=3;wPosicaoPontaY[2]=3;
				wPosicaoPontaX[3]=1;wPosicaoPontaY[3]=1;
				wPosicaoPontaX[4]=1;wPosicaoPontaY[4]=3;
			}
			if (rnd==4)
			{				
				wPosicaoPontaX[1]=3;wPosicaoPontaY[1]=3;
				wPosicaoPontaX[2]=1;wPosicaoPontaY[2]=1;
				wPosicaoPontaX[3]=1;wPosicaoPontaY[3]=3;
				wPosicaoPontaX[4]=3;wPosicaoPontaY[4]=1;
			}
			
			if (objCircleCross.wBoard[wPosicaoPontaX[1],wPosicaoPontaY[1]]==enPlayType.None)
			{
				objCircleCross.MakeMove(wPosicaoPontaX[1],wPosicaoPontaY[1]);
				return;
			}
		
			if (objCircleCross.wBoard[wPosicaoPontaX[2],wPosicaoPontaY[2]]==enPlayType.None)
			{
				objCircleCross.MakeMove(wPosicaoPontaX[2],wPosicaoPontaY[2]);
				return;
			}
		
			if (objCircleCross.wBoard[wPosicaoPontaX[3],wPosicaoPontaY[3]]==enPlayType.None)
			{
				objCircleCross.MakeMove(wPosicaoPontaX[3],wPosicaoPontaY[3]);
				return;
			}
		
			if (objCircleCross.wBoard[wPosicaoPontaX[4],wPosicaoPontaY[4]]==enPlayType.None)
			{
				objCircleCross.MakeMove(wPosicaoPontaX[4],wPosicaoPontaY[4]);
				return;
			}

			if (objCircleCross.wBoard[1,2]==enPlayType.None)
			{
				objCircleCross.MakeMove(1,2);
				return;
			}

			if (objCircleCross.wBoard[2,1]==enPlayType.None)
			{
				objCircleCross.MakeMove(2,1);
				return;
			}

			if (objCircleCross.wBoard[2,3]==enPlayType.None)
			{
				objCircleCross.MakeMove(2,3);
				return;
			}

			if (objCircleCross.wBoard[3,2]==enPlayType.None)
			{
				objCircleCross.MakeMove(3,2);
				return;
			}

			if (objCircleCross.wBoard[2,2]==enPlayType.None)
			{
				objCircleCross.MakeMove(2,2);
				return;
			}

		}

		#endregion
   	}
}