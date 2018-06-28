using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MaterialDesign.Class.Utils
{
    public class ObjectUtility
    {
        public static bool CheckInherit(Type child, Type parent)
        {
            return child.IsSubclassOf(parent) || child == parent;
        }
    }
}