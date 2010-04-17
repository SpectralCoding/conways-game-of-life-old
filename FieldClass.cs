using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
	public static class FieldClass
	{
		private static bool[,] cbCell = new bool[199,199];
		private static bool[,] cbCellTmp = new bool[199, 199];
		public static int StepCount = 0;

		public static bool Cell(int x, int y)
		{
			return cbCell[x,y];
		}
		
		public static void ResetField() {
			StepCount = 0;
			RandomField();
		}
		
		public static void RandomField() {
			Random random = new Random();
			int num;
			for (int y = 0; y <= 198; y++) {
				for (int x = 0; x <= 198; x++) {
					num = random.Next(0, 2);
					if (num == 0) {
						cbCell[x, y] = false;
					} else {
						cbCell[x, y] = true;
					}
				}
			}		
		}
		
		public static void MakeCheckerboard()
		{
			bool tmp = true;
			for (int y = 0; y <= 198; y++) {
				for (int x = 0; x <= 198; x++) {
					if (tmp == true) {
						cbCell[x,y] = true;
						tmp = false;
					} else {
						tmp = true;
					}
				}
			}
		}
		
		public static void NextStep() {
			cbCellTmp = cbCell;
			for (int x = 0; x <= 198; x++) {
				for (int y = 0; y <= 198; y++) {
					cbCellTmp[x, y] = DetermineLife(x, y);
				}
			}
			cbCell = cbCellTmp;
			StepCount++;
		}
		
		private static bool DetermineLife(int X, int Y) {
			bool bLiveDie = false;
			int iLiveNeighbors;
			iLiveNeighbors = LiveNeighbors(X, Y);
			//if (iLiveNeighbors < 2) { bLiveDie = false; }
			//if (iLiveNeighbors > 3) { bLiveDie = false; }
			if (cbCell[X, Y] == true) {
				if (iLiveNeighbors == 2 || iLiveNeighbors == 3) { bLiveDie = true; }
			} else {
				if (iLiveNeighbors == 3) { bLiveDie = true; }
			}
			return bLiveDie;
		}
		
		private static int LiveNeighbors(int X, int Y) {
			int iLiveNeighbors = 0;
			try {
				if (X > 0) {
					if (Y > 0) {
						if (cbCell[X - 1, Y - 1] == true) { iLiveNeighbors++; } // Top Left
					}
					if (cbCell[X - 1, Y] == true) { iLiveNeighbors++; } // Left
					if (Y < 198) {
						if (cbCell[X - 1, Y + 1] == true) { iLiveNeighbors++; } // Bottom Left
					}
				}
				if (X < 198) {
					if (Y > 0) {
						if (cbCell[X + 1, Y - 1] == true) { iLiveNeighbors++; } // Top Right
					}
					if (cbCell[X + 1, Y] == true) { iLiveNeighbors++; } // Right
					if (Y < 198) {
						if (cbCell[X + 1, Y + 1] == true) { iLiveNeighbors++; } // Bottom Right
					}
				}
				if (Y > 0) {
					if (cbCell[X, Y - 1] == true) { iLiveNeighbors++; } // Top
				}
				//if (cbCell[X, Y] == true) { iLiveNeighbors++; } // Cell in Question
				if (Y < 198) {
					if (cbCell[X, Y + 1] == true) { iLiveNeighbors++; } // Bottom
				}
			}
			catch (Exception e) {
			
			}
			return iLiveNeighbors;
		}
				
	}
}
