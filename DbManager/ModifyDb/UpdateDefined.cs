/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;

namespace DbGenerate.Library
{
    public abstract class UpdateDefined:DbInfor
    {
        public abstract int Insert(object data);
        public abstract bool Update(object data);
        public abstract bool Delete(object _key);
    }
}
