using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class SimXMLDocument : SimObject
   {
      
      public SimXMLDocument()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SimXMLDocumentCreateInstance());
      }

      public SimXMLDocument(uint pId) : base(pId)
      {
      }

      public SimXMLDocument(string pName) : base(pName)
      {
      }

      public SimXMLDocument(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SimXMLDocument(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SimXMLDocument(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentCreateInstance();
         private static _SimXMLDocumentCreateInstance _SimXMLDocumentCreateInstanceFunc;
         internal static IntPtr SimXMLDocumentCreateInstance()
         {
            if (_SimXMLDocumentCreateInstanceFunc == null)
            {
               _SimXMLDocumentCreateInstanceFunc =
                  (_SimXMLDocumentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentCreateInstance"), typeof(_SimXMLDocumentCreateInstance));
            }

            return _SimXMLDocumentCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentReset(IntPtr xmlDocument);
         private static _SimXMLDocumentReset _SimXMLDocumentResetFunc;
         internal static void SimXMLDocumentReset(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentResetFunc == null)
            {
               _SimXMLDocumentResetFunc =
                  (_SimXMLDocumentReset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentReset"), typeof(_SimXMLDocumentReset));
            }

            _SimXMLDocumentResetFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimXMLDocumentLoadFile(IntPtr xmlDocument, string fileName);
         private static _SimXMLDocumentLoadFile _SimXMLDocumentLoadFileFunc;
         internal static bool SimXMLDocumentLoadFile(IntPtr xmlDocument, string fileName)
         {
            if (_SimXMLDocumentLoadFileFunc == null)
            {
               _SimXMLDocumentLoadFileFunc =
                  (_SimXMLDocumentLoadFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentLoadFile"), typeof(_SimXMLDocumentLoadFile));
            }

            return _SimXMLDocumentLoadFileFunc(xmlDocument, fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimXMLDocumentSaveFile(IntPtr xmlDocument, string fileName);
         private static _SimXMLDocumentSaveFile _SimXMLDocumentSaveFileFunc;
         internal static bool SimXMLDocumentSaveFile(IntPtr xmlDocument, string fileName)
         {
            if (_SimXMLDocumentSaveFileFunc == null)
            {
               _SimXMLDocumentSaveFileFunc =
                  (_SimXMLDocumentSaveFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentSaveFile"), typeof(_SimXMLDocumentSaveFile));
            }

            return _SimXMLDocumentSaveFileFunc(xmlDocument, fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimXMLDocumentParse(IntPtr xmlDocument, string textXML);
         private static _SimXMLDocumentParse _SimXMLDocumentParseFunc;
         internal static bool SimXMLDocumentParse(IntPtr xmlDocument, string textXML)
         {
            if (_SimXMLDocumentParseFunc == null)
            {
               _SimXMLDocumentParseFunc =
                  (_SimXMLDocumentParse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentParse"), typeof(_SimXMLDocumentParse));
            }

            return _SimXMLDocumentParseFunc(xmlDocument, textXML);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentClear(IntPtr xmlDocument);
         private static _SimXMLDocumentClear _SimXMLDocumentClearFunc;
         internal static void SimXMLDocumentClear(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentClearFunc == null)
            {
               _SimXMLDocumentClearFunc =
                  (_SimXMLDocumentClear)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentClear"), typeof(_SimXMLDocumentClear));
            }

            _SimXMLDocumentClearFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentGetErrorDesc(IntPtr xmlDocument);
         private static _SimXMLDocumentGetErrorDesc _SimXMLDocumentGetErrorDescFunc;
         internal static IntPtr SimXMLDocumentGetErrorDesc(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentGetErrorDescFunc == null)
            {
               _SimXMLDocumentGetErrorDescFunc =
                  (_SimXMLDocumentGetErrorDesc)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentGetErrorDesc"), typeof(_SimXMLDocumentGetErrorDesc));
            }

            return _SimXMLDocumentGetErrorDescFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentClearError(IntPtr xmlDocument);
         private static _SimXMLDocumentClearError _SimXMLDocumentClearErrorFunc;
         internal static void SimXMLDocumentClearError(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentClearErrorFunc == null)
            {
               _SimXMLDocumentClearErrorFunc =
                  (_SimXMLDocumentClearError)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentClearError"), typeof(_SimXMLDocumentClearError));
            }

            _SimXMLDocumentClearErrorFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimXMLDocumentPushFirstChildElement(IntPtr xmlDocument, string name);
         private static _SimXMLDocumentPushFirstChildElement _SimXMLDocumentPushFirstChildElementFunc;
         internal static bool SimXMLDocumentPushFirstChildElement(IntPtr xmlDocument, string name)
         {
            if (_SimXMLDocumentPushFirstChildElementFunc == null)
            {
               _SimXMLDocumentPushFirstChildElementFunc =
                  (_SimXMLDocumentPushFirstChildElement)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentPushFirstChildElement"), typeof(_SimXMLDocumentPushFirstChildElement));
            }

            return _SimXMLDocumentPushFirstChildElementFunc(xmlDocument, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimXMLDocumentPushChildElement(IntPtr xmlDocument, int index);
         private static _SimXMLDocumentPushChildElement _SimXMLDocumentPushChildElementFunc;
         internal static bool SimXMLDocumentPushChildElement(IntPtr xmlDocument, int index)
         {
            if (_SimXMLDocumentPushChildElementFunc == null)
            {
               _SimXMLDocumentPushChildElementFunc =
                  (_SimXMLDocumentPushChildElement)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentPushChildElement"), typeof(_SimXMLDocumentPushChildElement));
            }

            return _SimXMLDocumentPushChildElementFunc(xmlDocument, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimXMLDocumentNextSiblingElement(IntPtr xmlDocument, string name);
         private static _SimXMLDocumentNextSiblingElement _SimXMLDocumentNextSiblingElementFunc;
         internal static bool SimXMLDocumentNextSiblingElement(IntPtr xmlDocument, string name)
         {
            if (_SimXMLDocumentNextSiblingElementFunc == null)
            {
               _SimXMLDocumentNextSiblingElementFunc =
                  (_SimXMLDocumentNextSiblingElement)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentNextSiblingElement"), typeof(_SimXMLDocumentNextSiblingElement));
            }

            return _SimXMLDocumentNextSiblingElementFunc(xmlDocument, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentElementValue(IntPtr xmlDocument);
         private static _SimXMLDocumentElementValue _SimXMLDocumentElementValueFunc;
         internal static IntPtr SimXMLDocumentElementValue(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentElementValueFunc == null)
            {
               _SimXMLDocumentElementValueFunc =
                  (_SimXMLDocumentElementValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentElementValue"), typeof(_SimXMLDocumentElementValue));
            }

            return _SimXMLDocumentElementValueFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentPopElement(IntPtr xmlDocument);
         private static _SimXMLDocumentPopElement _SimXMLDocumentPopElementFunc;
         internal static void SimXMLDocumentPopElement(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentPopElementFunc == null)
            {
               _SimXMLDocumentPopElementFunc =
                  (_SimXMLDocumentPopElement)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentPopElement"), typeof(_SimXMLDocumentPopElement));
            }

            _SimXMLDocumentPopElementFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentAttribute(IntPtr xmlDocument, string attribute);
         private static _SimXMLDocumentAttribute _SimXMLDocumentAttributeFunc;
         internal static IntPtr SimXMLDocumentAttribute(IntPtr xmlDocument, string attribute)
         {
            if (_SimXMLDocumentAttributeFunc == null)
            {
               _SimXMLDocumentAttributeFunc =
                  (_SimXMLDocumentAttribute)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentAttribute"), typeof(_SimXMLDocumentAttribute));
            }

            return _SimXMLDocumentAttributeFunc(xmlDocument, attribute);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _SimXMLDocumentAttributeF32(IntPtr xmlDocument, string attribute);
         private static _SimXMLDocumentAttributeF32 _SimXMLDocumentAttributeF32Func;
         internal static float SimXMLDocumentAttributeF32(IntPtr xmlDocument, string attribute)
         {
            if (_SimXMLDocumentAttributeF32Func == null)
            {
               _SimXMLDocumentAttributeF32Func =
                  (_SimXMLDocumentAttributeF32)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentAttributeF32"), typeof(_SimXMLDocumentAttributeF32));
            }

            return _SimXMLDocumentAttributeF32Func(xmlDocument, attribute);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SimXMLDocumentAttributeS32(IntPtr xmlDocument, string attribute);
         private static _SimXMLDocumentAttributeS32 _SimXMLDocumentAttributeS32Func;
         internal static int SimXMLDocumentAttributeS32(IntPtr xmlDocument, string attribute)
         {
            if (_SimXMLDocumentAttributeS32Func == null)
            {
               _SimXMLDocumentAttributeS32Func =
                  (_SimXMLDocumentAttributeS32)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentAttributeS32"), typeof(_SimXMLDocumentAttributeS32));
            }

            return _SimXMLDocumentAttributeS32Func(xmlDocument, attribute);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimXMLDocumentAttributeExists(IntPtr xmlDocument, string attribute);
         private static _SimXMLDocumentAttributeExists _SimXMLDocumentAttributeExistsFunc;
         internal static bool SimXMLDocumentAttributeExists(IntPtr xmlDocument, string attribute)
         {
            if (_SimXMLDocumentAttributeExistsFunc == null)
            {
               _SimXMLDocumentAttributeExistsFunc =
                  (_SimXMLDocumentAttributeExists)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentAttributeExists"), typeof(_SimXMLDocumentAttributeExists));
            }

            return _SimXMLDocumentAttributeExistsFunc(xmlDocument, attribute);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentFirstAttribute(IntPtr xmlDocument);
         private static _SimXMLDocumentFirstAttribute _SimXMLDocumentFirstAttributeFunc;
         internal static IntPtr SimXMLDocumentFirstAttribute(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentFirstAttributeFunc == null)
            {
               _SimXMLDocumentFirstAttributeFunc =
                  (_SimXMLDocumentFirstAttribute)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentFirstAttribute"), typeof(_SimXMLDocumentFirstAttribute));
            }

            return _SimXMLDocumentFirstAttributeFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentLastAttribute(IntPtr xmlDocument);
         private static _SimXMLDocumentLastAttribute _SimXMLDocumentLastAttributeFunc;
         internal static IntPtr SimXMLDocumentLastAttribute(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentLastAttributeFunc == null)
            {
               _SimXMLDocumentLastAttributeFunc =
                  (_SimXMLDocumentLastAttribute)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentLastAttribute"), typeof(_SimXMLDocumentLastAttribute));
            }

            return _SimXMLDocumentLastAttributeFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentNextAttribute(IntPtr xmlDocument);
         private static _SimXMLDocumentNextAttribute _SimXMLDocumentNextAttributeFunc;
         internal static IntPtr SimXMLDocumentNextAttribute(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentNextAttributeFunc == null)
            {
               _SimXMLDocumentNextAttributeFunc =
                  (_SimXMLDocumentNextAttribute)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentNextAttribute"), typeof(_SimXMLDocumentNextAttribute));
            }

            return _SimXMLDocumentNextAttributeFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentPrevAttribute(IntPtr xmlDocument);
         private static _SimXMLDocumentPrevAttribute _SimXMLDocumentPrevAttributeFunc;
         internal static IntPtr SimXMLDocumentPrevAttribute(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentPrevAttributeFunc == null)
            {
               _SimXMLDocumentPrevAttributeFunc =
                  (_SimXMLDocumentPrevAttribute)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentPrevAttribute"), typeof(_SimXMLDocumentPrevAttribute));
            }

            return _SimXMLDocumentPrevAttributeFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentSetAttribute(IntPtr xmlDocument, string attribute, string attributeValue);
         private static _SimXMLDocumentSetAttribute _SimXMLDocumentSetAttributeFunc;
         internal static void SimXMLDocumentSetAttribute(IntPtr xmlDocument, string attribute, string attributeValue)
         {
            if (_SimXMLDocumentSetAttributeFunc == null)
            {
               _SimXMLDocumentSetAttributeFunc =
                  (_SimXMLDocumentSetAttribute)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentSetAttribute"), typeof(_SimXMLDocumentSetAttribute));
            }

            _SimXMLDocumentSetAttributeFunc(xmlDocument, attribute, attributeValue);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentSetObjectAttributes(IntPtr xmlDocument, string attributeValue);
         private static _SimXMLDocumentSetObjectAttributes _SimXMLDocumentSetObjectAttributesFunc;
         internal static void SimXMLDocumentSetObjectAttributes(IntPtr xmlDocument, string attributeValue)
         {
            if (_SimXMLDocumentSetObjectAttributesFunc == null)
            {
               _SimXMLDocumentSetObjectAttributesFunc =
                  (_SimXMLDocumentSetObjectAttributes)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentSetObjectAttributes"), typeof(_SimXMLDocumentSetObjectAttributes));
            }

            _SimXMLDocumentSetObjectAttributesFunc(xmlDocument, attributeValue);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentPushNewElement(IntPtr xmlDocument, string name);
         private static _SimXMLDocumentPushNewElement _SimXMLDocumentPushNewElementFunc;
         internal static void SimXMLDocumentPushNewElement(IntPtr xmlDocument, string name)
         {
            if (_SimXMLDocumentPushNewElementFunc == null)
            {
               _SimXMLDocumentPushNewElementFunc =
                  (_SimXMLDocumentPushNewElement)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentPushNewElement"), typeof(_SimXMLDocumentPushNewElement));
            }

            _SimXMLDocumentPushNewElementFunc(xmlDocument, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentAddNewElement(IntPtr xmlDocument, string name);
         private static _SimXMLDocumentAddNewElement _SimXMLDocumentAddNewElementFunc;
         internal static void SimXMLDocumentAddNewElement(IntPtr xmlDocument, string name)
         {
            if (_SimXMLDocumentAddNewElementFunc == null)
            {
               _SimXMLDocumentAddNewElementFunc =
                  (_SimXMLDocumentAddNewElement)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentAddNewElement"), typeof(_SimXMLDocumentAddNewElement));
            }

            _SimXMLDocumentAddNewElementFunc(xmlDocument, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentAddHeader(IntPtr xmlDocument);
         private static _SimXMLDocumentAddHeader _SimXMLDocumentAddHeaderFunc;
         internal static void SimXMLDocumentAddHeader(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentAddHeaderFunc == null)
            {
               _SimXMLDocumentAddHeaderFunc =
                  (_SimXMLDocumentAddHeader)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentAddHeader"), typeof(_SimXMLDocumentAddHeader));
            }

            _SimXMLDocumentAddHeaderFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentAddComment(IntPtr xmlDocument, string comment);
         private static _SimXMLDocumentAddComment _SimXMLDocumentAddCommentFunc;
         internal static void SimXMLDocumentAddComment(IntPtr xmlDocument, string comment)
         {
            if (_SimXMLDocumentAddCommentFunc == null)
            {
               _SimXMLDocumentAddCommentFunc =
                  (_SimXMLDocumentAddComment)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentAddComment"), typeof(_SimXMLDocumentAddComment));
            }

            _SimXMLDocumentAddCommentFunc(xmlDocument, comment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentReadComment(IntPtr xmlDocument, int index);
         private static _SimXMLDocumentReadComment _SimXMLDocumentReadCommentFunc;
         internal static IntPtr SimXMLDocumentReadComment(IntPtr xmlDocument, int index)
         {
            if (_SimXMLDocumentReadCommentFunc == null)
            {
               _SimXMLDocumentReadCommentFunc =
                  (_SimXMLDocumentReadComment)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentReadComment"), typeof(_SimXMLDocumentReadComment));
            }

            return _SimXMLDocumentReadCommentFunc(xmlDocument, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentAddText(IntPtr xmlDocument, string text);
         private static _SimXMLDocumentAddText _SimXMLDocumentAddTextFunc;
         internal static void SimXMLDocumentAddText(IntPtr xmlDocument, string text)
         {
            if (_SimXMLDocumentAddTextFunc == null)
            {
               _SimXMLDocumentAddTextFunc =
                  (_SimXMLDocumentAddText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentAddText"), typeof(_SimXMLDocumentAddText));
            }

            _SimXMLDocumentAddTextFunc(xmlDocument, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentGetText(IntPtr xmlDocument);
         private static _SimXMLDocumentGetText _SimXMLDocumentGetTextFunc;
         internal static IntPtr SimXMLDocumentGetText(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentGetTextFunc == null)
            {
               _SimXMLDocumentGetTextFunc =
                  (_SimXMLDocumentGetText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentGetText"), typeof(_SimXMLDocumentGetText));
            }

            return _SimXMLDocumentGetTextFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentRemoveText(IntPtr xmlDocument);
         private static _SimXMLDocumentRemoveText _SimXMLDocumentRemoveTextFunc;
         internal static void SimXMLDocumentRemoveText(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentRemoveTextFunc == null)
            {
               _SimXMLDocumentRemoveTextFunc =
                  (_SimXMLDocumentRemoveText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentRemoveText"), typeof(_SimXMLDocumentRemoveText));
            }

            _SimXMLDocumentRemoveTextFunc(xmlDocument);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimXMLDocumentAddData(IntPtr xmlDocument, string text);
         private static _SimXMLDocumentAddData _SimXMLDocumentAddDataFunc;
         internal static void SimXMLDocumentAddData(IntPtr xmlDocument, string text)
         {
            if (_SimXMLDocumentAddDataFunc == null)
            {
               _SimXMLDocumentAddDataFunc =
                  (_SimXMLDocumentAddData)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentAddData"), typeof(_SimXMLDocumentAddData));
            }

            _SimXMLDocumentAddDataFunc(xmlDocument, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocumentGetData(IntPtr xmlDocument);
         private static _SimXMLDocumentGetData _SimXMLDocumentGetDataFunc;
         internal static IntPtr SimXMLDocumentGetData(IntPtr xmlDocument)
         {
            if (_SimXMLDocumentGetDataFunc == null)
            {
               _SimXMLDocumentGetDataFunc =
                  (_SimXMLDocumentGetData)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimXMLDocumentGetData"), typeof(_SimXMLDocumentGetData));
            }

            return _SimXMLDocumentGetDataFunc(xmlDocument);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void Reset()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentReset(ObjectPtr->ObjPtr);
      }

      public bool LoadFile(string fileName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimXMLDocumentLoadFile(ObjectPtr->ObjPtr, fileName);
      }

      public bool SaveFile(string fileName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimXMLDocumentSaveFile(ObjectPtr->ObjPtr, fileName);
      }

      public bool Parse(string textXML)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimXMLDocumentParse(ObjectPtr->ObjPtr, textXML);
      }

      public void Clear()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentClear(ObjectPtr->ObjPtr);
      }

      public string GetErrorDesc()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimXMLDocumentGetErrorDesc(ObjectPtr->ObjPtr));
      }

      public void ClearError()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentClearError(ObjectPtr->ObjPtr);
      }

      public bool PushFirstChildElement(string name)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimXMLDocumentPushFirstChildElement(ObjectPtr->ObjPtr, name);
      }

      public bool PushChildElement(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimXMLDocumentPushChildElement(ObjectPtr->ObjPtr, index);
      }

      public bool NextSiblingElement(string name)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimXMLDocumentNextSiblingElement(ObjectPtr->ObjPtr, name);
      }

      public string ElementValue()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimXMLDocumentElementValue(ObjectPtr->ObjPtr));
      }

      public void PopElement()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentPopElement(ObjectPtr->ObjPtr);
      }

      public string Attribute(string attribute)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimXMLDocumentAttribute(ObjectPtr->ObjPtr, attribute));
      }

      public float AttributeF32(string attribute)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimXMLDocumentAttributeF32(ObjectPtr->ObjPtr, attribute);
      }

      public int AttributeS32(string attribute)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimXMLDocumentAttributeS32(ObjectPtr->ObjPtr, attribute);
      }

      public bool AttributeExists(string attribute)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimXMLDocumentAttributeExists(ObjectPtr->ObjPtr, attribute);
      }

      public string FirstAttribute()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimXMLDocumentFirstAttribute(ObjectPtr->ObjPtr));
      }

      public string LastAttribute()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimXMLDocumentLastAttribute(ObjectPtr->ObjPtr));
      }

      public string NextAttribute()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimXMLDocumentNextAttribute(ObjectPtr->ObjPtr));
      }

      public string PrevAttribute()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimXMLDocumentPrevAttribute(ObjectPtr->ObjPtr));
      }

      public void SetAttribute(string attribute, string attributeValue)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentSetAttribute(ObjectPtr->ObjPtr, attribute, attributeValue);
      }

      public void SetObjectAttributes(string attributeValue)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentSetObjectAttributes(ObjectPtr->ObjPtr, attributeValue);
      }

      public void PushNewElement(string name)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentPushNewElement(ObjectPtr->ObjPtr, name);
      }

      public void AddNewElement(string name)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentAddNewElement(ObjectPtr->ObjPtr, name);
      }

      public void AddHeader()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentAddHeader(ObjectPtr->ObjPtr);
      }

      public void AddComment(string comment)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentAddComment(ObjectPtr->ObjPtr, comment);
      }

      public string ReadComment(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimXMLDocumentReadComment(ObjectPtr->ObjPtr, index));
      }

      public void AddText(string text)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentAddText(ObjectPtr->ObjPtr, text);
      }

      public string GetText()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimXMLDocumentGetText(ObjectPtr->ObjPtr));
      }

      public void RemoveText()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentRemoveText(ObjectPtr->ObjPtr);
      }

      public void AddData(string text)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimXMLDocumentAddData(ObjectPtr->ObjPtr, text);
      }

      public string GetData()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimXMLDocumentGetData(ObjectPtr->ObjPtr));
      }
      
      #endregion

      
   }
}