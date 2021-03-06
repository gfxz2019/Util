﻿namespace Util.Ui.Zorro.Tables.Configs {
    /// <summary>
    /// 列配置信息
    /// </summary>
    public class ColumnInfo {
        /// <summary>
        /// 初始化列配置信息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="column">列名</param>
        /// <param name="isSort">是否排序</param>
        public ColumnInfo( string title,string column,bool isSort ) {
            Title = title;
            Column = column;
            IsSort = isSort;
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; }
        /// <summary>
        /// 列名
        /// </summary>
        public string Column { get; }
        /// <summary>
        /// 是否排序
        /// </summary>
        public bool IsSort { get; }

        /// <summary>
        /// 获取排序字段
        /// </summary>
        public string GetSortKey() {
            if ( IsSort )
                return Column;
            return null;
        }
    }
}
