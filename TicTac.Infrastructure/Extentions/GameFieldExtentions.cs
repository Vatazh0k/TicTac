using System;

namespace TicTac.Infrastructure.Extentions
{
    public static class GameFieldExtentions
    {
        public static bool HasWinner(this string[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                var str = String
                    .Join("", field[i, 0], field[i, 1], field[i, 2]);

                if (str.IsSameMark() is true) return true;
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                var str = String
                    .Join("", field[0, i], field[1, i], field[2, i]);

                if (str.IsSameMark() is true) return true;
            }

            for (int i = 0; i < 2; i++)
            {
                var x = Convert.ToInt32(Math.Pow(0, Convert.ToDouble(i)));

                var str = String
                    .Join("", field[0, i * 2], field[1, 1], field[2, x + x]);

                if (str.IsSameMark() is true) return true;
            }

            return false;
        }

        public static bool HasEmptyCell(this string[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (string.IsNullOrEmpty(field[i, j])) return true;
                }
            }

            return false;
        }
    }
}
