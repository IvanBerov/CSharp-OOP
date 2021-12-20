using System;
using System.Text;

namespace RhombusOfStars
{
    public class RhombusStringDrawer
    {
        public string Draw(int numberOfStars)
        {
            var sb = new StringBuilder();

            DrawTopPart(sb, numberOfStars);
            DrawStarsLine(sb, numberOfStars);
            DrawBottomPart(sb, numberOfStars);

            return sb.ToString();
        }

        public static void DrawStarsLine(StringBuilder sb, int numberStars)
        {
            for (int star = 0; star < numberStars; star++)
            {
                sb.Append('*');

                if (star < numberStars - 1)
                {
                    sb.Append(' ');
                }
            }

            sb.AppendLine();
        }

        public static void DrawTopPart(StringBuilder sb, int n)
        {
            for (int i = 1; i < n; i++)
            {
                sb.Append(new string(' ', n - i));
                DrawStarsLine(sb, i);
            }
        }

        public static void DrawBottomPart(StringBuilder sb, int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                sb.Append(new string(' ', n - i));
                DrawStarsLine(sb, i);
            }
        }
    }
    
}
