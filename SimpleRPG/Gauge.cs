using System;

namespace SimpleRPG
{
	public class Gauge<T> where T: struct, IComparable<T>, IConvertible
	{
		T _Max;
		public T Max {
			get {
				return _Max;
			}
			set {
				if (Max.CompareTo (_Zero) < 0)
					throw new ArgumentOutOfRangeException ("Max", value, "The value cannot be negative");
				else
					_Max = value;
			}
		}

		T _Current;
		public T Current {
			get {
				return _Current;
			}
			set {
				if (value.CompareTo (_Zero) < 0)
					_Current = _Zero;
				else if (value.CompareTo (Max) > 0)
					_Current = Max;
				else
					_Current = value;
			}
		}

		T _Zero;

		public Gauge () {
			_Zero = (T)Convert.ChangeType (0, typeof(T));
		}

		public Gauge (T Max) : this() {
			this.Current = this.Max = Max;
		}
	}
}

