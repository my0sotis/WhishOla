using System;
namespace DbGenerate.Library
{
    public abstract class BaseEntities:ICloneable
    {
		#region Định nghĩa  BaseEntities
        public abstract string NameE();
        public object Clone()
        {
            return MemberwiseClone();
        }
		#endregion

		
    }
}
