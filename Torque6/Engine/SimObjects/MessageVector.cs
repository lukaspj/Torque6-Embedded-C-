using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class MessageVector : SimObject
   {
      
      public MessageVector()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.MessageVectorCreateInstance());
      }

      public MessageVector(uint pId) : base(pId)
      {
      }

      public MessageVector(string pName) : base(pName)
      {
      }

      public MessageVector(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public MessageVector(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public MessageVector(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MessageVectorCreateInstance();
         private static _MessageVectorCreateInstance _MessageVectorCreateInstanceFunc;
         internal static IntPtr MessageVectorCreateInstance()
         {
            if (_MessageVectorCreateInstanceFunc == null)
            {
               _MessageVectorCreateInstanceFunc =
                  (_MessageVectorCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorCreateInstance"), typeof(_MessageVectorCreateInstance));
            }

            return _MessageVectorCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MessageVectorClear(IntPtr messageVector);
         private static _MessageVectorClear _MessageVectorClearFunc;
         internal static void MessageVectorClear(IntPtr messageVector)
         {
            if (_MessageVectorClearFunc == null)
            {
               _MessageVectorClearFunc =
                  (_MessageVectorClear)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorClear"), typeof(_MessageVectorClear));
            }

            _MessageVectorClearFunc(messageVector);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MessageVectorPushBackLine(IntPtr messageVector, string msg, int tag);
         private static _MessageVectorPushBackLine _MessageVectorPushBackLineFunc;
         internal static void MessageVectorPushBackLine(IntPtr messageVector, string msg, int tag)
         {
            if (_MessageVectorPushBackLineFunc == null)
            {
               _MessageVectorPushBackLineFunc =
                  (_MessageVectorPushBackLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorPushBackLine"), typeof(_MessageVectorPushBackLine));
            }

            _MessageVectorPushBackLineFunc(messageVector, msg, tag);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _MessageVectorPopBackLine(IntPtr messageVector);
         private static _MessageVectorPopBackLine _MessageVectorPopBackLineFunc;
         internal static bool MessageVectorPopBackLine(IntPtr messageVector)
         {
            if (_MessageVectorPopBackLineFunc == null)
            {
               _MessageVectorPopBackLineFunc =
                  (_MessageVectorPopBackLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorPopBackLine"), typeof(_MessageVectorPopBackLine));
            }

            return _MessageVectorPopBackLineFunc(messageVector);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MessageVectorPushFrontLine(IntPtr messageVector, string msg, int tag);
         private static _MessageVectorPushFrontLine _MessageVectorPushFrontLineFunc;
         internal static void MessageVectorPushFrontLine(IntPtr messageVector, string msg, int tag)
         {
            if (_MessageVectorPushFrontLineFunc == null)
            {
               _MessageVectorPushFrontLineFunc =
                  (_MessageVectorPushFrontLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorPushFrontLine"), typeof(_MessageVectorPushFrontLine));
            }

            _MessageVectorPushFrontLineFunc(messageVector, msg, tag);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _MessageVectorPopFrontLine(IntPtr messageVector);
         private static _MessageVectorPopFrontLine _MessageVectorPopFrontLineFunc;
         internal static bool MessageVectorPopFrontLine(IntPtr messageVector)
         {
            if (_MessageVectorPopFrontLineFunc == null)
            {
               _MessageVectorPopFrontLineFunc =
                  (_MessageVectorPopFrontLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorPopFrontLine"), typeof(_MessageVectorPopFrontLine));
            }

            return _MessageVectorPopFrontLineFunc(messageVector);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _MessageVectorInsertLine(IntPtr messageVector, int pos, string msg, int tag);
         private static _MessageVectorInsertLine _MessageVectorInsertLineFunc;
         internal static bool MessageVectorInsertLine(IntPtr messageVector, int pos, string msg, int tag)
         {
            if (_MessageVectorInsertLineFunc == null)
            {
               _MessageVectorInsertLineFunc =
                  (_MessageVectorInsertLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorInsertLine"), typeof(_MessageVectorInsertLine));
            }

            return _MessageVectorInsertLineFunc(messageVector, pos, msg, tag);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _MessageVectorDeleteLine(IntPtr messageVector, uint lineIndex);
         private static _MessageVectorDeleteLine _MessageVectorDeleteLineFunc;
         internal static bool MessageVectorDeleteLine(IntPtr messageVector, uint lineIndex)
         {
            if (_MessageVectorDeleteLineFunc == null)
            {
               _MessageVectorDeleteLineFunc =
                  (_MessageVectorDeleteLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorDeleteLine"), typeof(_MessageVectorDeleteLine));
            }

            return _MessageVectorDeleteLineFunc(messageVector, lineIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MessageVectorDump(IntPtr messageVector, string filename, string header);
         private static _MessageVectorDump _MessageVectorDumpFunc;
         internal static void MessageVectorDump(IntPtr messageVector, string filename, string header)
         {
            if (_MessageVectorDumpFunc == null)
            {
               _MessageVectorDumpFunc =
                  (_MessageVectorDump)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorDump"), typeof(_MessageVectorDump));
            }

            _MessageVectorDumpFunc(messageVector, filename, header);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _MessageVectorGetNumLines(IntPtr messageVector);
         private static _MessageVectorGetNumLines _MessageVectorGetNumLinesFunc;
         internal static int MessageVectorGetNumLines(IntPtr messageVector)
         {
            if (_MessageVectorGetNumLinesFunc == null)
            {
               _MessageVectorGetNumLinesFunc =
                  (_MessageVectorGetNumLines)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorGetNumLines"), typeof(_MessageVectorGetNumLines));
            }

            return _MessageVectorGetNumLinesFunc(messageVector);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MessageVectorGetLineTextByTag(IntPtr messageVector, int tag);
         private static _MessageVectorGetLineTextByTag _MessageVectorGetLineTextByTagFunc;
         internal static IntPtr MessageVectorGetLineTextByTag(IntPtr messageVector, int tag)
         {
            if (_MessageVectorGetLineTextByTagFunc == null)
            {
               _MessageVectorGetLineTextByTagFunc =
                  (_MessageVectorGetLineTextByTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorGetLineTextByTag"), typeof(_MessageVectorGetLineTextByTag));
            }

            return _MessageVectorGetLineTextByTagFunc(messageVector, tag);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _MessageVectorGetLineIndexByTag(IntPtr messageVector, int tag);
         private static _MessageVectorGetLineIndexByTag _MessageVectorGetLineIndexByTagFunc;
         internal static int MessageVectorGetLineIndexByTag(IntPtr messageVector, int tag)
         {
            if (_MessageVectorGetLineIndexByTagFunc == null)
            {
               _MessageVectorGetLineIndexByTagFunc =
                  (_MessageVectorGetLineIndexByTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorGetLineIndexByTag"), typeof(_MessageVectorGetLineIndexByTag));
            }

            return _MessageVectorGetLineIndexByTagFunc(messageVector, tag);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MessageVectorGetLineText(IntPtr messageVector, uint index);
         private static _MessageVectorGetLineText _MessageVectorGetLineTextFunc;
         internal static IntPtr MessageVectorGetLineText(IntPtr messageVector, uint index)
         {
            if (_MessageVectorGetLineTextFunc == null)
            {
               _MessageVectorGetLineTextFunc =
                  (_MessageVectorGetLineText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorGetLineText"), typeof(_MessageVectorGetLineText));
            }

            return _MessageVectorGetLineTextFunc(messageVector, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _MessageVectorGetLineTag(IntPtr messageVector, uint index);
         private static _MessageVectorGetLineTag _MessageVectorGetLineTagFunc;
         internal static int MessageVectorGetLineTag(IntPtr messageVector, uint index)
         {
            if (_MessageVectorGetLineTagFunc == null)
            {
               _MessageVectorGetLineTagFunc =
                  (_MessageVectorGetLineTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageVectorGetLineTag"), typeof(_MessageVectorGetLineTag));
            }

            return _MessageVectorGetLineTagFunc(messageVector, index);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void Clear()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.MessageVectorClear(ObjectPtr->ObjPtr);
      }

      public void PushBackLine(string msg, int tag)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.MessageVectorPushBackLine(ObjectPtr->ObjPtr, msg, tag);
      }

      public bool PopBackLine()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.MessageVectorPopBackLine(ObjectPtr->ObjPtr);
      }

      public void PushFrontLine(string msg, int tag)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.MessageVectorPushFrontLine(ObjectPtr->ObjPtr, msg, tag);
      }

      public bool PopFrontLine()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.MessageVectorPopFrontLine(ObjectPtr->ObjPtr);
      }

      public bool InsertLine(int pos, string msg, int tag)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.MessageVectorInsertLine(ObjectPtr->ObjPtr, pos, msg, tag);
      }

      public bool DeleteLine(uint lineIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.MessageVectorDeleteLine(ObjectPtr->ObjPtr, lineIndex);
      }

      public void Dump(string filename, string header)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.MessageVectorDump(ObjectPtr->ObjPtr, filename, header);
      }

      public int GetNumLines()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.MessageVectorGetNumLines(ObjectPtr->ObjPtr);
      }

      public string GetLineTextByTag(int tag)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.MessageVectorGetLineTextByTag(ObjectPtr->ObjPtr, tag));
      }

      public int GetLineIndexByTag(int tag)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.MessageVectorGetLineIndexByTag(ObjectPtr->ObjPtr, tag);
      }

      public string GetLineText(uint index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.MessageVectorGetLineText(ObjectPtr->ObjPtr, index));
      }

      public int GetLineTag(uint index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.MessageVectorGetLineTag(ObjectPtr->ObjPtr, index);
      }
      
      #endregion

      
   }
}