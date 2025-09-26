using System;
using System.Text;
using System.Security.Cryptography;

namespace PersonalMathLib
{
    public class MathTool
    {
        // BACKING FIELDS
        private int _inputA = 0;
        private int _inputB = 0;
        private string _personalSignature = "LINH Nguyen (LINH2025)";

        // PROPERTIES
        public int InputA
        {
            get { return _inputA; }
            set { _inputA = value; }
        }

        public int InputB
        {
            get { return _inputB; }
            set { _inputB = value; }
        }

        public string PersonalSignature
        {
            get { return _personalSignature; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _personalSignature = "LINH Nguyen (LINH2025)";
                else
                    _personalSignature = value;
            }
        }

        // Euclidean algorithm (GCD)
        public int ComputeGCD()
        {
            int a = Math.Abs(_inputA);
            int b = Math.Abs(_inputB);
            if (a == 0 && b == 0) return 0;
            if (a == 0) return b;
            if (b == 0) return a;
            while (b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            return a;
        }

        // LCM
        public long ComputeLCM()
        {
            int gcd = ComputeGCD();
            if (gcd == 0) return 0;
            long la = Math.Abs((long)_inputA);
            long lb = Math.Abs((long)_inputB);
            return (la / gcd) * lb;
        }

        // Prime check
        public bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0) return false;
            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
                if (n % i == 0) return false;
            return true;
        }

        // Factorial (up to 20)
        public long Factorial(int n)
        {
            if (n < 0 || n > 20) return -1;
            long r = 1;
            for (int i = 2; i <= n; i++)
                r *= i;
            return r;
        }

        // Fingerprint (hash)
        public string GetFingerprint()
        {
            try
            {
                MD5 md5 = MD5.Create();
                string concat = _inputA + "|" + _inputB + "|" + _personalSignature;
                byte[] data = Encoding.UTF8.GetBytes(concat);
                byte[] hash = md5.ComputeHash(data);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < Math.Min(6, hash.Length); i++)
                    sb.Append(hash[i].ToString("x2"));
                return sb.ToString();
            }
            catch
            {
                return "000000";
            }
        }

        // Summary
        public string ComputeSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== PersonalMathLib - KET QUA ===");
            sb.AppendLine(string.Format("InputA = {0}, InputB = {1}", _inputA, _inputB));

            int gcd = ComputeGCD();
            long lcm = ComputeLCM();
            sb.AppendLine("UCLN (GCD) = " + gcd);
            sb.AppendLine("BCNN (LCM) = " + lcm);

            // prime checks
            sb.AppendLine("InputA " + (IsPrime(_inputA) ? "la nguyen to" : "khong phai nguyen to"));
            sb.AppendLine("InputB " + (IsPrime(_inputB) ? "la nguyen to" : "khong phai nguyen to"));

            // factorial
            if (_inputA >= 0 && _inputA <= 20)
                sb.AppendLine("InputA! = " + Factorial(_inputA));
            if (_inputB >= 0 && _inputB <= 20)
                sb.AppendLine("InputB! = " + Factorial(_inputB));

            // fingerprint
            sb.AppendLine("Fingerprint: " + GetFingerprint());
            sb.AppendLine("-- " + _personalSignature + " - " + DateTime.Now.ToString("yyyy-MM-dd") + " --");

            return sb.ToString();
        }
    }
}
