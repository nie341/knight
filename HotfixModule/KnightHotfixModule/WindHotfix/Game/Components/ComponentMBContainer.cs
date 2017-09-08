﻿using Framework.Hotfix;
using System;
using System.Collections.Generic;
using WindHotfix.Core;
using UnityEngine;

namespace WindHotfix.Game
{
    public class ComponentMBContainer : Component
    {
        public HotfixMBContainer    MBContainer;

        public void Initialize(HotfixMBContainer rMBContainer)
        {
            this.MBContainer = rMBContainer;   
            // 绑定数据
            HotfixDataBindingAssist.BindComponent(this);
        }

        public UnityObject GetUnityObject(string rDataName) 
        {
            if (this.MBContainer == null || this.MBContainer.Objects == null) return null;
            return this.MBContainer.Objects.Find((rItem) => { return rItem.Name.Equals(rDataName); });
        }

        public UnityObject GetUnityObject(int nIndex)
        {
            if (this.MBContainer == null || this.MBContainer.Objects == null) return null;
            if (nIndex < 0 || nIndex >= this.MBContainer.Objects.Count) return null;
            return this.MBContainer.Objects[nIndex];
        }

        public GameObject GameObject 
        {
            get
            {
                if (this.MBContainer == null) return null;
                return this.MBContainer.gameObject;
            }
        }
    }
}
