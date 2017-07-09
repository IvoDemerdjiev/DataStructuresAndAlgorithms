namespace DictHashSetT
{
    using System;
    using System.Collections.Generic;

    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})",
                this.X, this.Y, this.Z);
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            Point3D other = obj as Point3D;

            if (other == null)
                return false;

            if (!this.X.Equals(other.X))
                return false;

            if (!this.Y.Equals(other.Y))
                return false;

            if (!this.Z.Equals(other.Z))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            int prime = 83;
            int result = 1;
            unchecked
            {
                result = result * prime + X.GetHashCode();
                result = result * prime + Y.GetHashCode();
                result = result * prime + Z.GetHashCode();
            }

            return result;
        }
    }

    public class DictHashSet
    {
        public class Point3DEqualityComparer : IEqualityComparer<Point3D>
        {
            public bool Equals(Point3D point1, Point3D point2)
            {
                if (point1 == point2)
                    return true;

                if (point1 == null || point2 == null)
                    return false;

                if (!point1.X.Equals(point2.X))
                    return false;

                if (!point1.Y.Equals(point2.Y))
                    return false;

                if (!point1.Z.Equals(point2.Z))
                    return false;

                return true;
            }

            public int GetHashCode(Point3D obj)
            {
                Point3D point = obj as Point3D;
                if (point == null)
                {
                    return 0;
                }

                int prime = 83;
                int result = 1;
                unchecked
                {
                    result = result * prime + point.X.GetHashCode();
                    result = result * prime + point.Y.GetHashCode();
                    result = result * prime + point.Z.GetHashCode();
                }
                return result;
            }
        }

        static void Main()
        {
            HashDictionary<Point3D, int> dict =
                new HashDictionary<Point3D, int>(3, 0.9f);

            dict[new Point3D(1, 2, 3)] = 2; // Put a key-value pair
            Console.WriteLine(dict[new Point3D(1, 2, 3)]); // Get value

            // Overwrite the previous value for the same key
            dict[new Point3D(1, 2, 3)] += 1;
            Console.WriteLine(dict[new Point3D(1, 2, 3)]);

            // Now this point will cause a collision with the
            // previous one and the elements will be chained
            dict[new Point3D(3, 2, 2)] = 42;

            Console.WriteLine(dict[new Point3D(3, 2, 2)]);

            // Test if the chaining works as expected, i.e.
            // elements with equal hash-codes are not overwritten
            Console.WriteLine(dict[new Point3D(1, 2, 3)]);

            // Creation of another entry in the internal table
            // This will cause the internal table to expand
            dict[new Point3D(4, 5, 6)] = 1111;
            Console.WriteLine(dict[new Point3D(4, 5, 6)]);

            // Delete an existing by its key
            dict.Remove(new Point3D(3, 2, 2));

            // Iterate through the dictionary entries and print them
            foreach (KeyValuePair<Point3D, int> entry in dict)
            {
                Console.WriteLine(
                    "Key: " + entry.Key + "; Value: " + entry.Value);
            }
        }
    }
}
