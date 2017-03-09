using System;

namespace Itam.Core
{
    public class BaseEntity
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreatedOn { get; set; } = DateTime.Now;


        /// <summary>
        /// 更新时间
        /// </summary>
        public virtual DateTime UpdatedOn { get; set; }
    }
}
