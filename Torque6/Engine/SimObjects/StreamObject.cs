using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class StreamObject : SimObject
   {
      
      public StreamObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.StreamObjectCreateInstance());
      }

      public StreamObject(uint pId) : base(pId)
      {
      }

      public StreamObject(string pName) : base(pName)
      {
      }

      public StreamObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public StreamObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public StreamObject(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StreamObjectCreateInstance();
         private static _StreamObjectCreateInstance _StreamObjectCreateInstanceFunc;
         internal static IntPtr StreamObjectCreateInstance()
         {
            if (_StreamObjectCreateInstanceFunc == null)
            {
               _StreamObjectCreateInstanceFunc =
                  (_StreamObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectCreateInstance"), typeof(_StreamObjectCreateInstance));
            }

            return _StreamObjectCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StreamObjectGetStatus(IntPtr streamObj);
         private static _StreamObjectGetStatus _StreamObjectGetStatusFunc;
         internal static IntPtr StreamObjectGetStatus(IntPtr streamObj)
         {
            if (_StreamObjectGetStatusFunc == null)
            {
               _StreamObjectGetStatusFunc =
                  (_StreamObjectGetStatus)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectGetStatus"), typeof(_StreamObjectGetStatus));
            }

            return _StreamObjectGetStatusFunc(streamObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _StreamObjectIsEOS(IntPtr streamObj);
         private static _StreamObjectIsEOS _StreamObjectIsEOSFunc;
         internal static bool StreamObjectIsEOS(IntPtr streamObj)
         {
            if (_StreamObjectIsEOSFunc == null)
            {
               _StreamObjectIsEOSFunc =
                  (_StreamObjectIsEOS)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectIsEOS"), typeof(_StreamObjectIsEOS));
            }

            return _StreamObjectIsEOSFunc(streamObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _StreamObjectIsEOF(IntPtr streamObj);
         private static _StreamObjectIsEOF _StreamObjectIsEOFFunc;
         internal static bool StreamObjectIsEOF(IntPtr streamObj)
         {
            if (_StreamObjectIsEOFFunc == null)
            {
               _StreamObjectIsEOFFunc =
                  (_StreamObjectIsEOF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectIsEOF"), typeof(_StreamObjectIsEOF));
            }

            return _StreamObjectIsEOFFunc(streamObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _StreamObjectGetPosition(IntPtr streamObj);
         private static _StreamObjectGetPosition _StreamObjectGetPositionFunc;
         internal static int StreamObjectGetPosition(IntPtr streamObj)
         {
            if (_StreamObjectGetPositionFunc == null)
            {
               _StreamObjectGetPositionFunc =
                  (_StreamObjectGetPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectGetPosition"), typeof(_StreamObjectGetPosition));
            }

            return _StreamObjectGetPositionFunc(streamObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _StreamObjectSetPosition(IntPtr streamObj, int newPos);
         private static _StreamObjectSetPosition _StreamObjectSetPositionFunc;
         internal static bool StreamObjectSetPosition(IntPtr streamObj, int newPos)
         {
            if (_StreamObjectSetPositionFunc == null)
            {
               _StreamObjectSetPositionFunc =
                  (_StreamObjectSetPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectSetPosition"), typeof(_StreamObjectSetPosition));
            }

            return _StreamObjectSetPositionFunc(streamObj, newPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _StreamObjectGetStreamSize(IntPtr streamObj);
         private static _StreamObjectGetStreamSize _StreamObjectGetStreamSizeFunc;
         internal static int StreamObjectGetStreamSize(IntPtr streamObj)
         {
            if (_StreamObjectGetStreamSizeFunc == null)
            {
               _StreamObjectGetStreamSizeFunc =
                  (_StreamObjectGetStreamSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectGetStreamSize"), typeof(_StreamObjectGetStreamSize));
            }

            return _StreamObjectGetStreamSizeFunc(streamObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StreamObjectReadLine(IntPtr streamObj);
         private static _StreamObjectReadLine _StreamObjectReadLineFunc;
         internal static IntPtr StreamObjectReadLine(IntPtr streamObj)
         {
            if (_StreamObjectReadLineFunc == null)
            {
               _StreamObjectReadLineFunc =
                  (_StreamObjectReadLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectReadLine"), typeof(_StreamObjectReadLine));
            }

            return _StreamObjectReadLineFunc(streamObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _StreamObjectWriteLine(IntPtr streamObj, string line);
         private static _StreamObjectWriteLine _StreamObjectWriteLineFunc;
         internal static void StreamObjectWriteLine(IntPtr streamObj, string line)
         {
            if (_StreamObjectWriteLineFunc == null)
            {
               _StreamObjectWriteLineFunc =
                  (_StreamObjectWriteLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectWriteLine"), typeof(_StreamObjectWriteLine));
            }

            _StreamObjectWriteLineFunc(streamObj, line);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StreamObjectReadSTString(IntPtr streamObj, bool caseSensitive);
         private static _StreamObjectReadSTString _StreamObjectReadSTStringFunc;
         internal static IntPtr StreamObjectReadSTString(IntPtr streamObj, bool caseSensitive)
         {
            if (_StreamObjectReadSTStringFunc == null)
            {
               _StreamObjectReadSTStringFunc =
                  (_StreamObjectReadSTString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectReadSTString"), typeof(_StreamObjectReadSTString));
            }

            return _StreamObjectReadSTStringFunc(streamObj, caseSensitive);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StreamObjectReadString(IntPtr streamObj);
         private static _StreamObjectReadString _StreamObjectReadStringFunc;
         internal static IntPtr StreamObjectReadString(IntPtr streamObj)
         {
            if (_StreamObjectReadStringFunc == null)
            {
               _StreamObjectReadStringFunc =
                  (_StreamObjectReadString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectReadString"), typeof(_StreamObjectReadString));
            }

            return _StreamObjectReadStringFunc(streamObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StreamObjectReadLongString(IntPtr streamObj, int maxLength);
         private static _StreamObjectReadLongString _StreamObjectReadLongStringFunc;
         internal static IntPtr StreamObjectReadLongString(IntPtr streamObj, int maxLength)
         {
            if (_StreamObjectReadLongStringFunc == null)
            {
               _StreamObjectReadLongStringFunc =
                  (_StreamObjectReadLongString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectReadLongString"), typeof(_StreamObjectReadLongString));
            }

            return _StreamObjectReadLongStringFunc(streamObj, maxLength);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _StreamObjectWriteLongString(IntPtr streamObj, int maxLength, string longString);
         private static _StreamObjectWriteLongString _StreamObjectWriteLongStringFunc;
         internal static void StreamObjectWriteLongString(IntPtr streamObj, int maxLength, string longString)
         {
            if (_StreamObjectWriteLongStringFunc == null)
            {
               _StreamObjectWriteLongStringFunc =
                  (_StreamObjectWriteLongString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectWriteLongString"), typeof(_StreamObjectWriteLongString));
            }

            _StreamObjectWriteLongStringFunc(streamObj, maxLength, longString);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _StreamObjectWriteString(IntPtr streamObj, string longString, int maxLength);
         private static _StreamObjectWriteString _StreamObjectWriteStringFunc;
         internal static void StreamObjectWriteString(IntPtr streamObj, string longString, int maxLength)
         {
            if (_StreamObjectWriteStringFunc == null)
            {
               _StreamObjectWriteStringFunc =
                  (_StreamObjectWriteString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectWriteString"), typeof(_StreamObjectWriteString));
            }

            _StreamObjectWriteStringFunc(streamObj, longString, maxLength);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _StreamObjectCopyFrom(IntPtr streamObj, IntPtr other);
         private static _StreamObjectCopyFrom _StreamObjectCopyFromFunc;
         internal static bool StreamObjectCopyFrom(IntPtr streamObj, IntPtr other)
         {
            if (_StreamObjectCopyFromFunc == null)
            {
               _StreamObjectCopyFromFunc =
                  (_StreamObjectCopyFrom)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "StreamObjectCopyFrom"), typeof(_StreamObjectCopyFrom));
            }

            return _StreamObjectCopyFromFunc(streamObj, other);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public string GetStatus()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.StreamObjectGetStatus(ObjectPtr->ObjPtr));
      }

      public bool IsEOS()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.StreamObjectIsEOS(ObjectPtr->ObjPtr);
      }

      public bool IsEOF()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.StreamObjectIsEOF(ObjectPtr->ObjPtr);
      }

      public int GetPosition()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.StreamObjectGetPosition(ObjectPtr->ObjPtr);
      }

      public bool SetPosition(int newPos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.StreamObjectSetPosition(ObjectPtr->ObjPtr, newPos);
      }

      public int GetStreamSize()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.StreamObjectGetStreamSize(ObjectPtr->ObjPtr);
      }

      public string ReadLine()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.StreamObjectReadLine(ObjectPtr->ObjPtr));
      }

      public void WriteLine(string line)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.StreamObjectWriteLine(ObjectPtr->ObjPtr, line);
      }

      public string ReadSTString(bool caseSensitive = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.StreamObjectReadSTString(ObjectPtr->ObjPtr, caseSensitive));
      }

      public string ReadString()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.StreamObjectReadString(ObjectPtr->ObjPtr));
      }

      public string ReadLongString(int maxLength)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.StreamObjectReadLongString(ObjectPtr->ObjPtr, maxLength));
      }

      public void WriteLongString(int maxLength, string longString)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.StreamObjectWriteLongString(ObjectPtr->ObjPtr, maxLength, longString);
      }

      public void WriteString(string longString, int maxLength = 255)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.StreamObjectWriteString(ObjectPtr->ObjPtr, longString, maxLength);
      }

      public bool CopyFrom(StreamObject other)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.StreamObjectCopyFrom(ObjectPtr->ObjPtr, other.ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}