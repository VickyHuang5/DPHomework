namespace CoRPattern
{
    /// <summary>
    /// 有效證號檢查器
    /// </summary>
    public class ValidIdChecker : AbstractChecker
    {
        /// <summary>
        /// 覆寫檢查
        /// </summary>
        /// <param name="idNumber">身份證號</param>
        /// <returns>檢查結果boolean</returns>
        public override bool Check(string idNumber)
        {
            int sum = this.CalculateSum(idNumber);
            if (!(sum % 10 == 0))
            {
                return false;
            }

            if (this.nextChecker == null)
            {
                return true;
            }

            return this.nextChecker.Check(idNumber);
        }

        /// <summary>
        /// 計算總和
        /// 步驟1.英文字母代表的數字：
        /// A=10 B=11 C=12 D=13 E=14 F=15 G=16 H=17 I=34
        /// J=18 K=19 L=20 M=21 N=22 O=35 P=23 Q=24 R=25
        /// S=26 T=27 U=28 V=29 W=32 X=30 Y=31 Z=33
        /// 再將所查出的數字 "十位數+個位數x9"
        /// 步驟2.N2x8+N3x7+N4x6+N5x5+N6x4+N7x3+N8x2+N9+N10
        /// 步驟3. (步驟1+步驟2)/10 可整除
        /// </summary>
        /// <param name="idNumber">身分證號</param>
        /// <returns>總和</returns>
        private int CalculateSum(string idNumber)
        {
            idNumber = idNumber.ToUpper();
            int[] checkArray = new int[11];

            // 步驟1
            int[] firstLetter = new[] { 10, 11, 12, 13, 14, 15, 16, 17, 34, 18, 19, 20, 21, 22, 35, 23, 24, 25, 26, 27, 28, 29, 32, 30, 31, 33 };
            int sum = checkArray[0] = firstLetter[(idNumber[0]) - 65] / 10;
            checkArray[1] = firstLetter[(idNumber[0]) - 65] % 10;

            // 步驟2
            for (int i = 1; i <= 9; i++)
            {
                checkArray[i + 1] = idNumber[i] - 48;
                sum += checkArray[i] * (10 - i);
            }

            return sum += checkArray[10];
        }
    }
}