using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiRolloutCtrl : GuiTickCtrl
   {
      
      public GuiRolloutCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiRolloutCtrlCreateInstance());
      }

      public GuiRolloutCtrl(uint pId) : base(pId)
      {
      }

      public GuiRolloutCtrl(string pName) : base(pName)
      {
      }

      public GuiRolloutCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiRolloutCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiRolloutCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiRolloutCtrlGetCaption(IntPtr ctrl);
         private static _GuiRolloutCtrlGetCaption _GuiRolloutCtrlGetCaptionFunc;
         internal static IntPtr GuiRolloutCtrlGetCaption(IntPtr ctrl)
         {
            if (_GuiRolloutCtrlGetCaptionFunc == null)
            {
               _GuiRolloutCtrlGetCaptionFunc =
                  (_GuiRolloutCtrlGetCaption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlGetCaption"), typeof(_GuiRolloutCtrlGetCaption));
            }

            return _GuiRolloutCtrlGetCaptionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlSetCaption(IntPtr ctrl, string caption);
         private static _GuiRolloutCtrlSetCaption _GuiRolloutCtrlSetCaptionFunc;
         internal static void GuiRolloutCtrlSetCaption(IntPtr ctrl, string caption)
         {
            if (_GuiRolloutCtrlSetCaptionFunc == null)
            {
               _GuiRolloutCtrlSetCaptionFunc =
                  (_GuiRolloutCtrlSetCaption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlSetCaption"), typeof(_GuiRolloutCtrlSetCaption));
            }

            _GuiRolloutCtrlSetCaptionFunc(ctrl, caption);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlGetMargin(IntPtr ctrl, out Point2I outMargin);
         private static _GuiRolloutCtrlGetMargin _GuiRolloutCtrlGetMarginFunc;
         internal static void GuiRolloutCtrlGetMargin(IntPtr ctrl, out Point2I outMargin)
         {
            if (_GuiRolloutCtrlGetMarginFunc == null)
            {
               _GuiRolloutCtrlGetMarginFunc =
                  (_GuiRolloutCtrlGetMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlGetMargin"), typeof(_GuiRolloutCtrlGetMargin));
            }

            _GuiRolloutCtrlGetMarginFunc(ctrl, out outMargin);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlSetMargin(IntPtr ctrl, Point2I margin);
         private static _GuiRolloutCtrlSetMargin _GuiRolloutCtrlSetMarginFunc;
         internal static void GuiRolloutCtrlSetMargin(IntPtr ctrl, Point2I margin)
         {
            if (_GuiRolloutCtrlSetMarginFunc == null)
            {
               _GuiRolloutCtrlSetMarginFunc =
                  (_GuiRolloutCtrlSetMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlSetMargin"), typeof(_GuiRolloutCtrlSetMargin));
            }

            _GuiRolloutCtrlSetMarginFunc(ctrl, margin);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiRolloutCtrlGetDefaultHeight(IntPtr ctrl);
         private static _GuiRolloutCtrlGetDefaultHeight _GuiRolloutCtrlGetDefaultHeightFunc;
         internal static int GuiRolloutCtrlGetDefaultHeight(IntPtr ctrl)
         {
            if (_GuiRolloutCtrlGetDefaultHeightFunc == null)
            {
               _GuiRolloutCtrlGetDefaultHeightFunc =
                  (_GuiRolloutCtrlGetDefaultHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlGetDefaultHeight"), typeof(_GuiRolloutCtrlGetDefaultHeight));
            }

            return _GuiRolloutCtrlGetDefaultHeightFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlSetDefaultHeight(IntPtr ctrl, int height);
         private static _GuiRolloutCtrlSetDefaultHeight _GuiRolloutCtrlSetDefaultHeightFunc;
         internal static void GuiRolloutCtrlSetDefaultHeight(IntPtr ctrl, int height)
         {
            if (_GuiRolloutCtrlSetDefaultHeightFunc == null)
            {
               _GuiRolloutCtrlSetDefaultHeightFunc =
                  (_GuiRolloutCtrlSetDefaultHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlSetDefaultHeight"), typeof(_GuiRolloutCtrlSetDefaultHeight));
            }

            _GuiRolloutCtrlSetDefaultHeightFunc(ctrl, height);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiRolloutCtrlGetCollapsed(IntPtr ctrl);
         private static _GuiRolloutCtrlGetCollapsed _GuiRolloutCtrlGetCollapsedFunc;
         internal static bool GuiRolloutCtrlGetCollapsed(IntPtr ctrl)
         {
            if (_GuiRolloutCtrlGetCollapsedFunc == null)
            {
               _GuiRolloutCtrlGetCollapsedFunc =
                  (_GuiRolloutCtrlGetCollapsed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlGetCollapsed"), typeof(_GuiRolloutCtrlGetCollapsed));
            }

            return _GuiRolloutCtrlGetCollapsedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlSetCollapsed(IntPtr ctrl, bool enable);
         private static _GuiRolloutCtrlSetCollapsed _GuiRolloutCtrlSetCollapsedFunc;
         internal static void GuiRolloutCtrlSetCollapsed(IntPtr ctrl, bool enable)
         {
            if (_GuiRolloutCtrlSetCollapsedFunc == null)
            {
               _GuiRolloutCtrlSetCollapsedFunc =
                  (_GuiRolloutCtrlSetCollapsed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlSetCollapsed"), typeof(_GuiRolloutCtrlSetCollapsed));
            }

            _GuiRolloutCtrlSetCollapsedFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiRolloutCtrlGetClickCollapse(IntPtr ctrl);
         private static _GuiRolloutCtrlGetClickCollapse _GuiRolloutCtrlGetClickCollapseFunc;
         internal static bool GuiRolloutCtrlGetClickCollapse(IntPtr ctrl)
         {
            if (_GuiRolloutCtrlGetClickCollapseFunc == null)
            {
               _GuiRolloutCtrlGetClickCollapseFunc =
                  (_GuiRolloutCtrlGetClickCollapse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlGetClickCollapse"), typeof(_GuiRolloutCtrlGetClickCollapse));
            }

            return _GuiRolloutCtrlGetClickCollapseFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlSetClickCollapse(IntPtr ctrl, bool enable);
         private static _GuiRolloutCtrlSetClickCollapse _GuiRolloutCtrlSetClickCollapseFunc;
         internal static void GuiRolloutCtrlSetClickCollapse(IntPtr ctrl, bool enable)
         {
            if (_GuiRolloutCtrlSetClickCollapseFunc == null)
            {
               _GuiRolloutCtrlSetClickCollapseFunc =
                  (_GuiRolloutCtrlSetClickCollapse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlSetClickCollapse"), typeof(_GuiRolloutCtrlSetClickCollapse));
            }

            _GuiRolloutCtrlSetClickCollapseFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiRolloutCtrlCreateInstance();
         private static _GuiRolloutCtrlCreateInstance _GuiRolloutCtrlCreateInstanceFunc;
         internal static IntPtr GuiRolloutCtrlCreateInstance()
         {
            if (_GuiRolloutCtrlCreateInstanceFunc == null)
            {
               _GuiRolloutCtrlCreateInstanceFunc =
                  (_GuiRolloutCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlCreateInstance"), typeof(_GuiRolloutCtrlCreateInstance));
            }

            return _GuiRolloutCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiRolloutCtrlIsExpanded(IntPtr ctrl);
         private static _GuiRolloutCtrlIsExpanded _GuiRolloutCtrlIsExpandedFunc;
         internal static bool GuiRolloutCtrlIsExpanded(IntPtr ctrl)
         {
            if (_GuiRolloutCtrlIsExpandedFunc == null)
            {
               _GuiRolloutCtrlIsExpandedFunc =
                  (_GuiRolloutCtrlIsExpanded)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlIsExpanded"), typeof(_GuiRolloutCtrlIsExpanded));
            }

            return _GuiRolloutCtrlIsExpandedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlCollapse(IntPtr ctrl);
         private static _GuiRolloutCtrlCollapse _GuiRolloutCtrlCollapseFunc;
         internal static void GuiRolloutCtrlCollapse(IntPtr ctrl)
         {
            if (_GuiRolloutCtrlCollapseFunc == null)
            {
               _GuiRolloutCtrlCollapseFunc =
                  (_GuiRolloutCtrlCollapse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlCollapse"), typeof(_GuiRolloutCtrlCollapse));
            }

            _GuiRolloutCtrlCollapseFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlExpand(IntPtr ctrl);
         private static _GuiRolloutCtrlExpand _GuiRolloutCtrlExpandFunc;
         internal static void GuiRolloutCtrlExpand(IntPtr ctrl)
         {
            if (_GuiRolloutCtrlExpandFunc == null)
            {
               _GuiRolloutCtrlExpandFunc =
                  (_GuiRolloutCtrlExpand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlExpand"), typeof(_GuiRolloutCtrlExpand));
            }

            _GuiRolloutCtrlExpandFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlInstantCollapse(IntPtr ctrl);
         private static _GuiRolloutCtrlInstantCollapse _GuiRolloutCtrlInstantCollapseFunc;
         internal static void GuiRolloutCtrlInstantCollapse(IntPtr ctrl)
         {
            if (_GuiRolloutCtrlInstantCollapseFunc == null)
            {
               _GuiRolloutCtrlInstantCollapseFunc =
                  (_GuiRolloutCtrlInstantCollapse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlInstantCollapse"), typeof(_GuiRolloutCtrlInstantCollapse));
            }

            _GuiRolloutCtrlInstantCollapseFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlInstantExpand(IntPtr ctrl);
         private static _GuiRolloutCtrlInstantExpand _GuiRolloutCtrlInstantExpandFunc;
         internal static void GuiRolloutCtrlInstantExpand(IntPtr ctrl)
         {
            if (_GuiRolloutCtrlInstantExpandFunc == null)
            {
               _GuiRolloutCtrlInstantExpandFunc =
                  (_GuiRolloutCtrlInstantExpand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlInstantExpand"), typeof(_GuiRolloutCtrlInstantExpand));
            }

            _GuiRolloutCtrlInstantExpandFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiRolloutCtrlSizeToContents(IntPtr ctrl);
         private static _GuiRolloutCtrlSizeToContents _GuiRolloutCtrlSizeToContentsFunc;
         internal static void GuiRolloutCtrlSizeToContents(IntPtr ctrl)
         {
            if (_GuiRolloutCtrlSizeToContentsFunc == null)
            {
               _GuiRolloutCtrlSizeToContentsFunc =
                  (_GuiRolloutCtrlSizeToContents)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiRolloutCtrlSizeToContents"), typeof(_GuiRolloutCtrlSizeToContents));
            }

            _GuiRolloutCtrlSizeToContentsFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public string Caption
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiRolloutCtrlGetCaption(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiRolloutCtrlSetCaption(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2I Margin
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiRolloutCtrlGetMargin(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiRolloutCtrlSetMargin(ObjectPtr->ObjPtr, value);
         }
      }
      public int DefaultHeight
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiRolloutCtrlGetDefaultHeight(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiRolloutCtrlSetDefaultHeight(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Collapsed
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiRolloutCtrlGetCollapsed(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiRolloutCtrlSetCollapsed(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ClickCollapse
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiRolloutCtrlGetClickCollapse(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiRolloutCtrlSetClickCollapse(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool IsExpanded()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiRolloutCtrlIsExpanded(ObjectPtr->ObjPtr);
      }

      public void Collapse()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiRolloutCtrlCollapse(ObjectPtr->ObjPtr);
      }

      public void Expand()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiRolloutCtrlExpand(ObjectPtr->ObjPtr);
      }

      public void InstantCollapse()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiRolloutCtrlInstantCollapse(ObjectPtr->ObjPtr);
      }

      public void InstantExpand()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiRolloutCtrlInstantExpand(ObjectPtr->ObjPtr);
      }

      public void SizeToContents()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiRolloutCtrlSizeToContents(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}