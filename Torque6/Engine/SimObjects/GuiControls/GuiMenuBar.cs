using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiMenuBar : GuiTickCtrl
   {
      
      public GuiMenuBar()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiMenuBarCreateInstance());
      }

      public GuiMenuBar(uint pId) : base(pId)
      {
      }

      public GuiMenuBar(string pName) : base(pName)
      {
      }

      public GuiMenuBar(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMenuBar(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMenuBar(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiMenuBarGetPadding(IntPtr menuBar);
         private static _GuiMenuBarGetPadding _GuiMenuBarGetPaddingFunc;
         internal static int GuiMenuBarGetPadding(IntPtr menuBar)
         {
            if (_GuiMenuBarGetPaddingFunc == null)
            {
               _GuiMenuBarGetPaddingFunc =
                  (_GuiMenuBarGetPadding)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarGetPadding"), typeof(_GuiMenuBarGetPadding));
            }

            return _GuiMenuBarGetPaddingFunc(menuBar);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetPadding(IntPtr menuBar, int padding);
         private static _GuiMenuBarSetPadding _GuiMenuBarSetPaddingFunc;
         internal static void GuiMenuBarSetPadding(IntPtr menuBar, int padding)
         {
            if (_GuiMenuBarSetPaddingFunc == null)
            {
               _GuiMenuBarSetPaddingFunc =
                  (_GuiMenuBarSetPadding)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetPadding"), typeof(_GuiMenuBarSetPadding));
            }

            _GuiMenuBarSetPaddingFunc(menuBar, padding);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMenuBarCreateInstance();
         private static _GuiMenuBarCreateInstance _GuiMenuBarCreateInstanceFunc;
         internal static IntPtr GuiMenuBarCreateInstance()
         {
            if (_GuiMenuBarCreateInstanceFunc == null)
            {
               _GuiMenuBarCreateInstanceFunc =
                  (_GuiMenuBarCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarCreateInstance"), typeof(_GuiMenuBarCreateInstance));
            }

            return _GuiMenuBarCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarClearMenus(IntPtr menuBar);
         private static _GuiMenuBarClearMenus _GuiMenuBarClearMenusFunc;
         internal static void GuiMenuBarClearMenus(IntPtr menuBar)
         {
            if (_GuiMenuBarClearMenusFunc == null)
            {
               _GuiMenuBarClearMenusFunc =
                  (_GuiMenuBarClearMenus)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarClearMenus"), typeof(_GuiMenuBarClearMenus));
            }

            _GuiMenuBarClearMenusFunc(menuBar);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetMenuMargins(IntPtr menuBar, int horizontalMargin, int verticalMargin, int bitmapToTextSpacing);
         private static _GuiMenuBarSetMenuMargins _GuiMenuBarSetMenuMarginsFunc;
         internal static void GuiMenuBarSetMenuMargins(IntPtr menuBar, int horizontalMargin, int verticalMargin, int bitmapToTextSpacing)
         {
            if (_GuiMenuBarSetMenuMarginsFunc == null)
            {
               _GuiMenuBarSetMenuMarginsFunc =
                  (_GuiMenuBarSetMenuMargins)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetMenuMargins"), typeof(_GuiMenuBarSetMenuMargins));
            }

            _GuiMenuBarSetMenuMarginsFunc(menuBar, horizontalMargin, verticalMargin, bitmapToTextSpacing);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarAddMenu(IntPtr menuBar, string menuName, int menuID);
         private static _GuiMenuBarAddMenu _GuiMenuBarAddMenuFunc;
         internal static void GuiMenuBarAddMenu(IntPtr menuBar, string menuName, int menuID)
         {
            if (_GuiMenuBarAddMenuFunc == null)
            {
               _GuiMenuBarAddMenuFunc =
                  (_GuiMenuBarAddMenu)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarAddMenu"), typeof(_GuiMenuBarAddMenu));
            }

            _GuiMenuBarAddMenuFunc(menuBar, menuName, menuID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarAddMenuItem(IntPtr menuBar, string menuName, string menuItemName, int menuItemID, string accelerator, int checkGroup);
         private static _GuiMenuBarAddMenuItem _GuiMenuBarAddMenuItemFunc;
         internal static void GuiMenuBarAddMenuItem(IntPtr menuBar, string menuName, string menuItemName, int menuItemID, string accelerator, int checkGroup)
         {
            if (_GuiMenuBarAddMenuItemFunc == null)
            {
               _GuiMenuBarAddMenuItemFunc =
                  (_GuiMenuBarAddMenuItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarAddMenuItem"), typeof(_GuiMenuBarAddMenuItem));
            }

            _GuiMenuBarAddMenuItemFunc(menuBar, menuName, menuItemName, menuItemID, accelerator, checkGroup);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetMenuItemEnable(IntPtr menuBar, string menuName, string menuItemName, bool enabled);
         private static _GuiMenuBarSetMenuItemEnable _GuiMenuBarSetMenuItemEnableFunc;
         internal static void GuiMenuBarSetMenuItemEnable(IntPtr menuBar, string menuName, string menuItemName, bool enabled)
         {
            if (_GuiMenuBarSetMenuItemEnableFunc == null)
            {
               _GuiMenuBarSetMenuItemEnableFunc =
                  (_GuiMenuBarSetMenuItemEnable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetMenuItemEnable"), typeof(_GuiMenuBarSetMenuItemEnable));
            }

            _GuiMenuBarSetMenuItemEnableFunc(menuBar, menuName, menuItemName, enabled);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetCheckmarkBitmapIndex(IntPtr menuBar, int bitmapIndex);
         private static _GuiMenuBarSetCheckmarkBitmapIndex _GuiMenuBarSetCheckmarkBitmapIndexFunc;
         internal static void GuiMenuBarSetCheckmarkBitmapIndex(IntPtr menuBar, int bitmapIndex)
         {
            if (_GuiMenuBarSetCheckmarkBitmapIndexFunc == null)
            {
               _GuiMenuBarSetCheckmarkBitmapIndexFunc =
                  (_GuiMenuBarSetCheckmarkBitmapIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetCheckmarkBitmapIndex"), typeof(_GuiMenuBarSetCheckmarkBitmapIndex));
            }

            _GuiMenuBarSetCheckmarkBitmapIndexFunc(menuBar, bitmapIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetMenuItemChecked(IntPtr menuBar, string menuName, string menuItemName, bool check);
         private static _GuiMenuBarSetMenuItemChecked _GuiMenuBarSetMenuItemCheckedFunc;
         internal static void GuiMenuBarSetMenuItemChecked(IntPtr menuBar, string menuName, string menuItemName, bool check)
         {
            if (_GuiMenuBarSetMenuItemCheckedFunc == null)
            {
               _GuiMenuBarSetMenuItemCheckedFunc =
                  (_GuiMenuBarSetMenuItemChecked)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetMenuItemChecked"), typeof(_GuiMenuBarSetMenuItemChecked));
            }

            _GuiMenuBarSetMenuItemCheckedFunc(menuBar, menuName, menuItemName, check);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetMenuText(IntPtr menuBar, string menuName, string newMenuText);
         private static _GuiMenuBarSetMenuText _GuiMenuBarSetMenuTextFunc;
         internal static void GuiMenuBarSetMenuText(IntPtr menuBar, string menuName, string newMenuText)
         {
            if (_GuiMenuBarSetMenuTextFunc == null)
            {
               _GuiMenuBarSetMenuTextFunc =
                  (_GuiMenuBarSetMenuText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetMenuText"), typeof(_GuiMenuBarSetMenuText));
            }

            _GuiMenuBarSetMenuTextFunc(menuBar, menuName, newMenuText);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetMenuBitmapIndex(IntPtr menuBar, string menuName, int bitmapIndex, bool bitmapOnly, bool drawBorder);
         private static _GuiMenuBarSetMenuBitmapIndex _GuiMenuBarSetMenuBitmapIndexFunc;
         internal static void GuiMenuBarSetMenuBitmapIndex(IntPtr menuBar, string menuName, int bitmapIndex, bool bitmapOnly, bool drawBorder)
         {
            if (_GuiMenuBarSetMenuBitmapIndexFunc == null)
            {
               _GuiMenuBarSetMenuBitmapIndexFunc =
                  (_GuiMenuBarSetMenuBitmapIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetMenuBitmapIndex"), typeof(_GuiMenuBarSetMenuBitmapIndex));
            }

            _GuiMenuBarSetMenuBitmapIndexFunc(menuBar, menuName, bitmapIndex, bitmapOnly, drawBorder);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetMenuVisible(IntPtr menuBar, string menuName, bool visible);
         private static _GuiMenuBarSetMenuVisible _GuiMenuBarSetMenuVisibleFunc;
         internal static void GuiMenuBarSetMenuVisible(IntPtr menuBar, string menuName, bool visible)
         {
            if (_GuiMenuBarSetMenuVisibleFunc == null)
            {
               _GuiMenuBarSetMenuVisibleFunc =
                  (_GuiMenuBarSetMenuVisible)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetMenuVisible"), typeof(_GuiMenuBarSetMenuVisible));
            }

            _GuiMenuBarSetMenuVisibleFunc(menuBar, menuName, visible);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetMenuItemText(IntPtr menuBar, string menuName, string menuItemName, string newMenuItemText);
         private static _GuiMenuBarSetMenuItemText _GuiMenuBarSetMenuItemTextFunc;
         internal static void GuiMenuBarSetMenuItemText(IntPtr menuBar, string menuName, string menuItemName, string newMenuItemText)
         {
            if (_GuiMenuBarSetMenuItemTextFunc == null)
            {
               _GuiMenuBarSetMenuItemTextFunc =
                  (_GuiMenuBarSetMenuItemText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetMenuItemText"), typeof(_GuiMenuBarSetMenuItemText));
            }

            _GuiMenuBarSetMenuItemTextFunc(menuBar, menuName, menuItemName, newMenuItemText);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetMenuItemVisible(IntPtr menuBar, string menuName, string menuItemName, bool visible);
         private static _GuiMenuBarSetMenuItemVisible _GuiMenuBarSetMenuItemVisibleFunc;
         internal static void GuiMenuBarSetMenuItemVisible(IntPtr menuBar, string menuName, string menuItemName, bool visible)
         {
            if (_GuiMenuBarSetMenuItemVisibleFunc == null)
            {
               _GuiMenuBarSetMenuItemVisibleFunc =
                  (_GuiMenuBarSetMenuItemVisible)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetMenuItemVisible"), typeof(_GuiMenuBarSetMenuItemVisible));
            }

            _GuiMenuBarSetMenuItemVisibleFunc(menuBar, menuName, menuItemName, visible);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetMenuItemBitmap(IntPtr menuBar, string menuName, string menuItemName, int bitmapIndex);
         private static _GuiMenuBarSetMenuItemBitmap _GuiMenuBarSetMenuItemBitmapFunc;
         internal static void GuiMenuBarSetMenuItemBitmap(IntPtr menuBar, string menuName, string menuItemName, int bitmapIndex)
         {
            if (_GuiMenuBarSetMenuItemBitmapFunc == null)
            {
               _GuiMenuBarSetMenuItemBitmapFunc =
                  (_GuiMenuBarSetMenuItemBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetMenuItemBitmap"), typeof(_GuiMenuBarSetMenuItemBitmap));
            }

            _GuiMenuBarSetMenuItemBitmapFunc(menuBar, menuName, menuItemName, bitmapIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarRemoveMenuItem(IntPtr menuBar, string menuName, string menuItemName);
         private static _GuiMenuBarRemoveMenuItem _GuiMenuBarRemoveMenuItemFunc;
         internal static void GuiMenuBarRemoveMenuItem(IntPtr menuBar, string menuName, string menuItemName)
         {
            if (_GuiMenuBarRemoveMenuItemFunc == null)
            {
               _GuiMenuBarRemoveMenuItemFunc =
                  (_GuiMenuBarRemoveMenuItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarRemoveMenuItem"), typeof(_GuiMenuBarRemoveMenuItem));
            }

            _GuiMenuBarRemoveMenuItemFunc(menuBar, menuName, menuItemName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarClearMenuItems(IntPtr menuBar, string menuName);
         private static _GuiMenuBarClearMenuItems _GuiMenuBarClearMenuItemsFunc;
         internal static void GuiMenuBarClearMenuItems(IntPtr menuBar, string menuName)
         {
            if (_GuiMenuBarClearMenuItemsFunc == null)
            {
               _GuiMenuBarClearMenuItemsFunc =
                  (_GuiMenuBarClearMenuItems)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarClearMenuItems"), typeof(_GuiMenuBarClearMenuItems));
            }

            _GuiMenuBarClearMenuItemsFunc(menuBar, menuName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarRemoveMenu(IntPtr menuBar, string menuName);
         private static _GuiMenuBarRemoveMenu _GuiMenuBarRemoveMenuFunc;
         internal static void GuiMenuBarRemoveMenu(IntPtr menuBar, string menuName)
         {
            if (_GuiMenuBarRemoveMenuFunc == null)
            {
               _GuiMenuBarRemoveMenuFunc =
                  (_GuiMenuBarRemoveMenu)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarRemoveMenu"), typeof(_GuiMenuBarRemoveMenu));
            }

            _GuiMenuBarRemoveMenuFunc(menuBar, menuName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetMenuItemSubmenuState(IntPtr menuBar, string menuName, string menuItemName, bool inSubmenu);
         private static _GuiMenuBarSetMenuItemSubmenuState _GuiMenuBarSetMenuItemSubmenuStateFunc;
         internal static void GuiMenuBarSetMenuItemSubmenuState(IntPtr menuBar, string menuName, string menuItemName, bool inSubmenu)
         {
            if (_GuiMenuBarSetMenuItemSubmenuStateFunc == null)
            {
               _GuiMenuBarSetMenuItemSubmenuStateFunc =
                  (_GuiMenuBarSetMenuItemSubmenuState)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetMenuItemSubmenuState"), typeof(_GuiMenuBarSetMenuItemSubmenuState));
            }

            _GuiMenuBarSetMenuItemSubmenuStateFunc(menuBar, menuName, menuItemName, inSubmenu);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarAddSubmenuItem(IntPtr menuBar, string menuName, string menuItemName, string submenuItemText, int submenuItemId, string accelerator, int checkGroup);
         private static _GuiMenuBarAddSubmenuItem _GuiMenuBarAddSubmenuItemFunc;
         internal static void GuiMenuBarAddSubmenuItem(IntPtr menuBar, string menuName, string menuItemName, string submenuItemText, int submenuItemId, string accelerator, int checkGroup)
         {
            if (_GuiMenuBarAddSubmenuItemFunc == null)
            {
               _GuiMenuBarAddSubmenuItemFunc =
                  (_GuiMenuBarAddSubmenuItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarAddSubmenuItem"), typeof(_GuiMenuBarAddSubmenuItem));
            }

            _GuiMenuBarAddSubmenuItemFunc(menuBar, menuName, menuItemName, submenuItemText, submenuItemId, accelerator, checkGroup);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarClearSubmenuItems(IntPtr menuBar, string menuName, string menuItemName);
         private static _GuiMenuBarClearSubmenuItems _GuiMenuBarClearSubmenuItemsFunc;
         internal static void GuiMenuBarClearSubmenuItems(IntPtr menuBar, string menuName, string menuItemName)
         {
            if (_GuiMenuBarClearSubmenuItemsFunc == null)
            {
               _GuiMenuBarClearSubmenuItemsFunc =
                  (_GuiMenuBarClearSubmenuItems)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarClearSubmenuItems"), typeof(_GuiMenuBarClearSubmenuItems));
            }

            _GuiMenuBarClearSubmenuItemsFunc(menuBar, menuName, menuItemName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMenuBarSetSubmenuItemChecked(IntPtr menuBar, string menuName, string menuItemName, string submenuItemText, bool check);
         private static _GuiMenuBarSetSubmenuItemChecked _GuiMenuBarSetSubmenuItemCheckedFunc;
         internal static void GuiMenuBarSetSubmenuItemChecked(IntPtr menuBar, string menuName, string menuItemName, string submenuItemText, bool check)
         {
            if (_GuiMenuBarSetSubmenuItemCheckedFunc == null)
            {
               _GuiMenuBarSetSubmenuItemCheckedFunc =
                  (_GuiMenuBarSetSubmenuItemChecked)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMenuBarSetSubmenuItemChecked"), typeof(_GuiMenuBarSetSubmenuItemChecked));
            }

            _GuiMenuBarSetSubmenuItemCheckedFunc(menuBar, menuName, menuItemName, submenuItemText, check);
         }
      }
      
      #endregion

      #region Properties

      public int Padding
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiMenuBarGetPadding(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMenuBarSetPadding(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void ClearMenus()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarClearMenus(ObjectPtr->ObjPtr);
      }

      public void SetMenuMargins(int horizontalMargin, int verticalMargin, int bitmapToTextSpacing)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetMenuMargins(ObjectPtr->ObjPtr, horizontalMargin, verticalMargin, bitmapToTextSpacing);
      }

      public void AddMenu(string menuName, int menuID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarAddMenu(ObjectPtr->ObjPtr, menuName, menuID);
      }

      public void AddMenuItem(string menuName, string menuItemName, int menuItemID, string accelerator, int checkGroup)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarAddMenuItem(ObjectPtr->ObjPtr, menuName, menuItemName, menuItemID, accelerator, checkGroup);
      }

      public void SetMenuItemEnable(string menuName, string menuItemName, bool enabled)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetMenuItemEnable(ObjectPtr->ObjPtr, menuName, menuItemName, enabled);
      }

      public void SetCheckmarkBitmapIndex(int bitmapIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetCheckmarkBitmapIndex(ObjectPtr->ObjPtr, bitmapIndex);
      }

      public void SetMenuItemChecked(string menuName, string menuItemName, bool check)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetMenuItemChecked(ObjectPtr->ObjPtr, menuName, menuItemName, check);
      }

      public void SetMenuText(string menuName, string newMenuText)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetMenuText(ObjectPtr->ObjPtr, menuName, newMenuText);
      }

      public void SetMenuBitmapIndex(string menuName, int bitmapIndex, bool bitmapOnly, bool drawBorder)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetMenuBitmapIndex(ObjectPtr->ObjPtr, menuName, bitmapIndex, bitmapOnly, drawBorder);
      }

      public void SetMenuVisible(string menuName, bool visible)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetMenuVisible(ObjectPtr->ObjPtr, menuName, visible);
      }

      public void SetMenuItemText(string menuName, string menuItemName, string newMenuItemText)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetMenuItemText(ObjectPtr->ObjPtr, menuName, menuItemName, newMenuItemText);
      }

      public void SetMenuItemVisible(string menuName, string menuItemName, bool visible)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetMenuItemVisible(ObjectPtr->ObjPtr, menuName, menuItemName, visible);
      }

      public void SetMenuItemBitmap(string menuName, string menuItemName, int bitmapIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetMenuItemBitmap(ObjectPtr->ObjPtr, menuName, menuItemName, bitmapIndex);
      }

      public void RemoveMenuItem(string menuName, string menuItemName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarRemoveMenuItem(ObjectPtr->ObjPtr, menuName, menuItemName);
      }

      public void ClearMenuItems(string menuName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarClearMenuItems(ObjectPtr->ObjPtr, menuName);
      }

      public void RemoveMenu(string menuName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarRemoveMenu(ObjectPtr->ObjPtr, menuName);
      }

      public void SetMenuItemSubmenuState(string menuName, string menuItemName, bool inSubmenu)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetMenuItemSubmenuState(ObjectPtr->ObjPtr, menuName, menuItemName, inSubmenu);
      }

      public void AddSubmenuItem(string menuName, string menuItemName, string submenuItemText, int submenuItemId, string accelerator, int checkGroup)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarAddSubmenuItem(ObjectPtr->ObjPtr, menuName, menuItemName, submenuItemText, submenuItemId, accelerator, checkGroup);
      }

      public void ClearSubmenuItems(string menuName, string menuItemName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarClearSubmenuItems(ObjectPtr->ObjPtr, menuName, menuItemName);
      }

      public void SetSubmenuItemChecked(string menuName, string menuItemName, string submenuItemText, bool check)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMenuBarSetSubmenuItemChecked(ObjectPtr->ObjPtr, menuName, menuItemName, submenuItemText, check);
      }
      
      #endregion

      
   }
}