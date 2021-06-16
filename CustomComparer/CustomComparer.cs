using System.Collections;

namespace CustomComparer
{
    class CustomComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            // 0 If both are equal
            // 1 If x is greater than y
            // -1 If x is less than y

            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            Employee emp1 = (Employee)x;
            Employee emp2 = (Employee)y;

            if (emp1.Salary < emp2.Salary) return -1;
            if (emp1.Salary > emp2.Salary) return 1;

            return 0;
        }
    }
}
