﻿using System;
using System.IO;
using Util.Ui.Components;
using Util.Ui.Material.Tabs.Renders;
using Util.Ui.Renders;

namespace Util.Ui.Material.Tabs {
    /// <summary>
    /// 选项卡
    /// </summary>
    public class Tab : ContainerBase<IDisposable>, ITab {
        /// <summary>
        /// 初始化选项卡
        /// </summary>
        /// <param name="writer">流写入器</param>
        public Tab( TextWriter writer ) : base( writer ) {
        }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        protected override IRender GetRender() {
            return new TabRender( OptionConfig );
        }

        /// <summary>
        /// 获取容器包装器
        /// </summary>
        protected override IDisposable GetWrapper() {
            return new ContainerWrapper( this );
        }
    }
}