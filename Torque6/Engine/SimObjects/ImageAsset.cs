using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ImageAsset : AssetBase
   {
      
      public ImageAsset()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ImageAssetCreateInstance());
      }

      public ImageAsset(uint pId) : base(pId)
      {
      }

      public ImageAsset(string pName) : base(pName)
      {
      }

      public ImageAsset(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ImageAsset(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ImageAsset(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ImageAssetGetImageFile(IntPtr imageAsset);
         private static _ImageAssetGetImageFile _ImageAssetGetImageFileFunc;
         internal static IntPtr ImageAssetGetImageFile(IntPtr imageAsset)
         {
            if (_ImageAssetGetImageFileFunc == null)
            {
               _ImageAssetGetImageFileFunc =
                  (_ImageAssetGetImageFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetImageFile"), typeof(_ImageAssetGetImageFile));
            }

            return _ImageAssetGetImageFileFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetImageFile(IntPtr imageAsset, string imageFile);
         private static _ImageAssetSetImageFile _ImageAssetSetImageFileFunc;
         internal static void ImageAssetSetImageFile(IntPtr imageAsset, string imageFile)
         {
            if (_ImageAssetSetImageFileFunc == null)
            {
               _ImageAssetSetImageFileFunc =
                  (_ImageAssetSetImageFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetImageFile"), typeof(_ImageAssetSetImageFile));
            }

            _ImageAssetSetImageFileFunc(imageAsset, imageFile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ImageAssetGetForce16Bit(IntPtr imageAsset);
         private static _ImageAssetGetForce16Bit _ImageAssetGetForce16BitFunc;
         internal static bool ImageAssetGetForce16Bit(IntPtr imageAsset)
         {
            if (_ImageAssetGetForce16BitFunc == null)
            {
               _ImageAssetGetForce16BitFunc =
                  (_ImageAssetGetForce16Bit)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetForce16Bit"), typeof(_ImageAssetGetForce16Bit));
            }

            return _ImageAssetGetForce16BitFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetForce16Bit(IntPtr imageAsset, bool value);
         private static _ImageAssetSetForce16Bit _ImageAssetSetForce16BitFunc;
         internal static void ImageAssetSetForce16Bit(IntPtr imageAsset, bool value)
         {
            if (_ImageAssetSetForce16BitFunc == null)
            {
               _ImageAssetSetForce16BitFunc =
                  (_ImageAssetSetForce16Bit)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetForce16Bit"), typeof(_ImageAssetSetForce16Bit));
            }

            _ImageAssetSetForce16BitFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ImageAssetGetFilterMode(IntPtr imageAsset);
         private static _ImageAssetGetFilterMode _ImageAssetGetFilterModeFunc;
         internal static IntPtr ImageAssetGetFilterMode(IntPtr imageAsset)
         {
            if (_ImageAssetGetFilterModeFunc == null)
            {
               _ImageAssetGetFilterModeFunc =
                  (_ImageAssetGetFilterMode)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetFilterMode"), typeof(_ImageAssetGetFilterMode));
            }

            return _ImageAssetGetFilterModeFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetFilterMode(IntPtr imageAsset, string filterMode);
         private static _ImageAssetSetFilterMode _ImageAssetSetFilterModeFunc;
         internal static void ImageAssetSetFilterMode(IntPtr imageAsset, string filterMode)
         {
            if (_ImageAssetSetFilterModeFunc == null)
            {
               _ImageAssetSetFilterModeFunc =
                  (_ImageAssetSetFilterMode)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetFilterMode"), typeof(_ImageAssetSetFilterMode));
            }

            _ImageAssetSetFilterModeFunc(imageAsset, filterMode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ImageAssetGetExplicitMode(IntPtr imageAsset);
         private static _ImageAssetGetExplicitMode _ImageAssetGetExplicitModeFunc;
         internal static bool ImageAssetGetExplicitMode(IntPtr imageAsset)
         {
            if (_ImageAssetGetExplicitModeFunc == null)
            {
               _ImageAssetGetExplicitModeFunc =
                  (_ImageAssetGetExplicitMode)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetExplicitMode"), typeof(_ImageAssetGetExplicitMode));
            }

            return _ImageAssetGetExplicitModeFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetExplicitMode(IntPtr imageAsset, bool value);
         private static _ImageAssetSetExplicitMode _ImageAssetSetExplicitModeFunc;
         internal static void ImageAssetSetExplicitMode(IntPtr imageAsset, bool value)
         {
            if (_ImageAssetSetExplicitModeFunc == null)
            {
               _ImageAssetSetExplicitModeFunc =
                  (_ImageAssetSetExplicitMode)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetExplicitMode"), typeof(_ImageAssetSetExplicitMode));
            }

            _ImageAssetSetExplicitModeFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ImageAssetGetCellRowOrder(IntPtr imageAsset);
         private static _ImageAssetGetCellRowOrder _ImageAssetGetCellRowOrderFunc;
         internal static bool ImageAssetGetCellRowOrder(IntPtr imageAsset)
         {
            if (_ImageAssetGetCellRowOrderFunc == null)
            {
               _ImageAssetGetCellRowOrderFunc =
                  (_ImageAssetGetCellRowOrder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetCellRowOrder"), typeof(_ImageAssetGetCellRowOrder));
            }

            return _ImageAssetGetCellRowOrderFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetCellRowOrder(IntPtr imageAsset, bool value);
         private static _ImageAssetSetCellRowOrder _ImageAssetSetCellRowOrderFunc;
         internal static void ImageAssetSetCellRowOrder(IntPtr imageAsset, bool value)
         {
            if (_ImageAssetSetCellRowOrderFunc == null)
            {
               _ImageAssetSetCellRowOrderFunc =
                  (_ImageAssetSetCellRowOrder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetCellRowOrder"), typeof(_ImageAssetSetCellRowOrder));
            }

            _ImageAssetSetCellRowOrderFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetCellOffsetX(IntPtr imageAsset);
         private static _ImageAssetGetCellOffsetX _ImageAssetGetCellOffsetXFunc;
         internal static int ImageAssetGetCellOffsetX(IntPtr imageAsset)
         {
            if (_ImageAssetGetCellOffsetXFunc == null)
            {
               _ImageAssetGetCellOffsetXFunc =
                  (_ImageAssetGetCellOffsetX)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetCellOffsetX"), typeof(_ImageAssetGetCellOffsetX));
            }

            return _ImageAssetGetCellOffsetXFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetCellOffsetX(IntPtr imageAsset, int value);
         private static _ImageAssetSetCellOffsetX _ImageAssetSetCellOffsetXFunc;
         internal static void ImageAssetSetCellOffsetX(IntPtr imageAsset, int value)
         {
            if (_ImageAssetSetCellOffsetXFunc == null)
            {
               _ImageAssetSetCellOffsetXFunc =
                  (_ImageAssetSetCellOffsetX)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetCellOffsetX"), typeof(_ImageAssetSetCellOffsetX));
            }

            _ImageAssetSetCellOffsetXFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetCellOffsetY(IntPtr imageAsset);
         private static _ImageAssetGetCellOffsetY _ImageAssetGetCellOffsetYFunc;
         internal static int ImageAssetGetCellOffsetY(IntPtr imageAsset)
         {
            if (_ImageAssetGetCellOffsetYFunc == null)
            {
               _ImageAssetGetCellOffsetYFunc =
                  (_ImageAssetGetCellOffsetY)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetCellOffsetY"), typeof(_ImageAssetGetCellOffsetY));
            }

            return _ImageAssetGetCellOffsetYFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetCellOffsetY(IntPtr imageAsset, int value);
         private static _ImageAssetSetCellOffsetY _ImageAssetSetCellOffsetYFunc;
         internal static void ImageAssetSetCellOffsetY(IntPtr imageAsset, int value)
         {
            if (_ImageAssetSetCellOffsetYFunc == null)
            {
               _ImageAssetSetCellOffsetYFunc =
                  (_ImageAssetSetCellOffsetY)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetCellOffsetY"), typeof(_ImageAssetSetCellOffsetY));
            }

            _ImageAssetSetCellOffsetYFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetCellStrideX(IntPtr imageAsset);
         private static _ImageAssetGetCellStrideX _ImageAssetGetCellStrideXFunc;
         internal static int ImageAssetGetCellStrideX(IntPtr imageAsset)
         {
            if (_ImageAssetGetCellStrideXFunc == null)
            {
               _ImageAssetGetCellStrideXFunc =
                  (_ImageAssetGetCellStrideX)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetCellStrideX"), typeof(_ImageAssetGetCellStrideX));
            }

            return _ImageAssetGetCellStrideXFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetCellStrideX(IntPtr imageAsset, int value);
         private static _ImageAssetSetCellStrideX _ImageAssetSetCellStrideXFunc;
         internal static void ImageAssetSetCellStrideX(IntPtr imageAsset, int value)
         {
            if (_ImageAssetSetCellStrideXFunc == null)
            {
               _ImageAssetSetCellStrideXFunc =
                  (_ImageAssetSetCellStrideX)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetCellStrideX"), typeof(_ImageAssetSetCellStrideX));
            }

            _ImageAssetSetCellStrideXFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetCellStrideY(IntPtr imageAsset);
         private static _ImageAssetGetCellStrideY _ImageAssetGetCellStrideYFunc;
         internal static int ImageAssetGetCellStrideY(IntPtr imageAsset)
         {
            if (_ImageAssetGetCellStrideYFunc == null)
            {
               _ImageAssetGetCellStrideYFunc =
                  (_ImageAssetGetCellStrideY)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetCellStrideY"), typeof(_ImageAssetGetCellStrideY));
            }

            return _ImageAssetGetCellStrideYFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetCellStrideY(IntPtr imageAsset, int value);
         private static _ImageAssetSetCellStrideY _ImageAssetSetCellStrideYFunc;
         internal static void ImageAssetSetCellStrideY(IntPtr imageAsset, int value)
         {
            if (_ImageAssetSetCellStrideYFunc == null)
            {
               _ImageAssetSetCellStrideYFunc =
                  (_ImageAssetSetCellStrideY)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetCellStrideY"), typeof(_ImageAssetSetCellStrideY));
            }

            _ImageAssetSetCellStrideYFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetCellCountX(IntPtr imageAsset);
         private static _ImageAssetGetCellCountX _ImageAssetGetCellCountXFunc;
         internal static int ImageAssetGetCellCountX(IntPtr imageAsset)
         {
            if (_ImageAssetGetCellCountXFunc == null)
            {
               _ImageAssetGetCellCountXFunc =
                  (_ImageAssetGetCellCountX)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetCellCountX"), typeof(_ImageAssetGetCellCountX));
            }

            return _ImageAssetGetCellCountXFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetCellCountX(IntPtr imageAsset, int value);
         private static _ImageAssetSetCellCountX _ImageAssetSetCellCountXFunc;
         internal static void ImageAssetSetCellCountX(IntPtr imageAsset, int value)
         {
            if (_ImageAssetSetCellCountXFunc == null)
            {
               _ImageAssetSetCellCountXFunc =
                  (_ImageAssetSetCellCountX)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetCellCountX"), typeof(_ImageAssetSetCellCountX));
            }

            _ImageAssetSetCellCountXFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetCellCountY(IntPtr imageAsset);
         private static _ImageAssetGetCellCountY _ImageAssetGetCellCountYFunc;
         internal static int ImageAssetGetCellCountY(IntPtr imageAsset)
         {
            if (_ImageAssetGetCellCountYFunc == null)
            {
               _ImageAssetGetCellCountYFunc =
                  (_ImageAssetGetCellCountY)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetCellCountY"), typeof(_ImageAssetGetCellCountY));
            }

            return _ImageAssetGetCellCountYFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetCellCountY(IntPtr imageAsset, int value);
         private static _ImageAssetSetCellCountY _ImageAssetSetCellCountYFunc;
         internal static void ImageAssetSetCellCountY(IntPtr imageAsset, int value)
         {
            if (_ImageAssetSetCellCountYFunc == null)
            {
               _ImageAssetSetCellCountYFunc =
                  (_ImageAssetSetCellCountY)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetCellCountY"), typeof(_ImageAssetSetCellCountY));
            }

            _ImageAssetSetCellCountYFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetCellWidth(IntPtr imageAsset);
         private static _ImageAssetGetCellWidth _ImageAssetGetCellWidthFunc;
         internal static int ImageAssetGetCellWidth(IntPtr imageAsset)
         {
            if (_ImageAssetGetCellWidthFunc == null)
            {
               _ImageAssetGetCellWidthFunc =
                  (_ImageAssetGetCellWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetCellWidth"), typeof(_ImageAssetGetCellWidth));
            }

            return _ImageAssetGetCellWidthFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetCellWidth(IntPtr imageAsset, int value);
         private static _ImageAssetSetCellWidth _ImageAssetSetCellWidthFunc;
         internal static void ImageAssetSetCellWidth(IntPtr imageAsset, int value)
         {
            if (_ImageAssetSetCellWidthFunc == null)
            {
               _ImageAssetSetCellWidthFunc =
                  (_ImageAssetSetCellWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetCellWidth"), typeof(_ImageAssetSetCellWidth));
            }

            _ImageAssetSetCellWidthFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetCellHeight(IntPtr imageAsset);
         private static _ImageAssetGetCellHeight _ImageAssetGetCellHeightFunc;
         internal static int ImageAssetGetCellHeight(IntPtr imageAsset)
         {
            if (_ImageAssetGetCellHeightFunc == null)
            {
               _ImageAssetGetCellHeightFunc =
                  (_ImageAssetGetCellHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetCellHeight"), typeof(_ImageAssetGetCellHeight));
            }

            return _ImageAssetGetCellHeightFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ImageAssetSetCellHeight(IntPtr imageAsset, int value);
         private static _ImageAssetSetCellHeight _ImageAssetSetCellHeightFunc;
         internal static void ImageAssetSetCellHeight(IntPtr imageAsset, int value)
         {
            if (_ImageAssetSetCellHeightFunc == null)
            {
               _ImageAssetSetCellHeightFunc =
                  (_ImageAssetSetCellHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetCellHeight"), typeof(_ImageAssetSetCellHeight));
            }

            _ImageAssetSetCellHeightFunc(imageAsset, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ImageAssetCreateInstance();
         private static _ImageAssetCreateInstance _ImageAssetCreateInstanceFunc;
         internal static IntPtr ImageAssetCreateInstance()
         {
            if (_ImageAssetCreateInstanceFunc == null)
            {
               _ImageAssetCreateInstanceFunc =
                  (_ImageAssetCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetCreateInstance"), typeof(_ImageAssetCreateInstance));
            }

            return _ImageAssetCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetImageWidth(IntPtr imageAsset);
         private static _ImageAssetGetImageWidth _ImageAssetGetImageWidthFunc;
         internal static int ImageAssetGetImageWidth(IntPtr imageAsset)
         {
            if (_ImageAssetGetImageWidthFunc == null)
            {
               _ImageAssetGetImageWidthFunc =
                  (_ImageAssetGetImageWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetImageWidth"), typeof(_ImageAssetGetImageWidth));
            }

            return _ImageAssetGetImageWidthFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetImageHeight(IntPtr imageAsset);
         private static _ImageAssetGetImageHeight _ImageAssetGetImageHeightFunc;
         internal static int ImageAssetGetImageHeight(IntPtr imageAsset)
         {
            if (_ImageAssetGetImageHeightFunc == null)
            {
               _ImageAssetGetImageHeightFunc =
                  (_ImageAssetGetImageHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetImageHeight"), typeof(_ImageAssetGetImageHeight));
            }

            return _ImageAssetGetImageHeightFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ImageAssetGetImageSize(IntPtr imageAsset);
         private static _ImageAssetGetImageSize _ImageAssetGetImageSizeFunc;
         internal static IntPtr ImageAssetGetImageSize(IntPtr imageAsset)
         {
            if (_ImageAssetGetImageSizeFunc == null)
            {
               _ImageAssetGetImageSizeFunc =
                  (_ImageAssetGetImageSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetImageSize"), typeof(_ImageAssetGetImageSize));
            }

            return _ImageAssetGetImageSizeFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ImageAssetGetIsImagePOT(IntPtr imageAsset);
         private static _ImageAssetGetIsImagePOT _ImageAssetGetIsImagePOTFunc;
         internal static bool ImageAssetGetIsImagePOT(IntPtr imageAsset)
         {
            if (_ImageAssetGetIsImagePOTFunc == null)
            {
               _ImageAssetGetIsImagePOTFunc =
                  (_ImageAssetGetIsImagePOT)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetIsImagePOT"), typeof(_ImageAssetGetIsImagePOT));
            }

            return _ImageAssetGetIsImagePOTFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetFrameCount(IntPtr imageAsset);
         private static _ImageAssetGetFrameCount _ImageAssetGetFrameCountFunc;
         internal static int ImageAssetGetFrameCount(IntPtr imageAsset)
         {
            if (_ImageAssetGetFrameCountFunc == null)
            {
               _ImageAssetGetFrameCountFunc =
                  (_ImageAssetGetFrameCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetFrameCount"), typeof(_ImageAssetGetFrameCount));
            }

            return _ImageAssetGetFrameCountFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ImageAssetGetFrameSize(IntPtr imageAsset, int frame);
         private static _ImageAssetGetFrameSize _ImageAssetGetFrameSizeFunc;
         internal static IntPtr ImageAssetGetFrameSize(IntPtr imageAsset, int frame)
         {
            if (_ImageAssetGetFrameSizeFunc == null)
            {
               _ImageAssetGetFrameSizeFunc =
                  (_ImageAssetGetFrameSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetFrameSize"), typeof(_ImageAssetGetFrameSize));
            }

            return _ImageAssetGetFrameSizeFunc(imageAsset, frame);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ImageAssetClearExplicitCells(IntPtr imageAsset);
         private static _ImageAssetClearExplicitCells _ImageAssetClearExplicitCellsFunc;
         internal static bool ImageAssetClearExplicitCells(IntPtr imageAsset)
         {
            if (_ImageAssetClearExplicitCellsFunc == null)
            {
               _ImageAssetClearExplicitCellsFunc =
                  (_ImageAssetClearExplicitCells)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetClearExplicitCells"), typeof(_ImageAssetClearExplicitCells));
            }

            return _ImageAssetClearExplicitCellsFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ImageAssetAddExplicitCell(IntPtr imageAsset, int cellOffsetX, int cellOffsetY, int cellWidth, int cellHeight, string cellName);
         private static _ImageAssetAddExplicitCell _ImageAssetAddExplicitCellFunc;
         internal static bool ImageAssetAddExplicitCell(IntPtr imageAsset, int cellOffsetX, int cellOffsetY, int cellWidth, int cellHeight, string cellName)
         {
            if (_ImageAssetAddExplicitCellFunc == null)
            {
               _ImageAssetAddExplicitCellFunc =
                  (_ImageAssetAddExplicitCell)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetAddExplicitCell"), typeof(_ImageAssetAddExplicitCell));
            }

            return _ImageAssetAddExplicitCellFunc(imageAsset, cellOffsetX, cellOffsetY, cellWidth, cellHeight, cellName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ImageAssetInsertExplicitCell(IntPtr imageAsset, int cellIndex, int cellOffsetX, int cellOffsetY, int cellWidth, int cellHeight, string cellName);
         private static _ImageAssetInsertExplicitCell _ImageAssetInsertExplicitCellFunc;
         internal static bool ImageAssetInsertExplicitCell(IntPtr imageAsset, int cellIndex, int cellOffsetX, int cellOffsetY, int cellWidth, int cellHeight, string cellName)
         {
            if (_ImageAssetInsertExplicitCellFunc == null)
            {
               _ImageAssetInsertExplicitCellFunc =
                  (_ImageAssetInsertExplicitCell)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetInsertExplicitCell"), typeof(_ImageAssetInsertExplicitCell));
            }

            return _ImageAssetInsertExplicitCellFunc(imageAsset, cellIndex, cellOffsetX, cellOffsetY, cellWidth, cellHeight, cellName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ImageAssetRemoveExplicitCell(IntPtr imageAsset, int cellIdx);
         private static _ImageAssetRemoveExplicitCell _ImageAssetRemoveExplicitCellFunc;
         internal static bool ImageAssetRemoveExplicitCell(IntPtr imageAsset, int cellIdx)
         {
            if (_ImageAssetRemoveExplicitCellFunc == null)
            {
               _ImageAssetRemoveExplicitCellFunc =
                  (_ImageAssetRemoveExplicitCell)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetRemoveExplicitCell"), typeof(_ImageAssetRemoveExplicitCell));
            }

            return _ImageAssetRemoveExplicitCellFunc(imageAsset, cellIdx);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ImageAssetSetExplicitCell(IntPtr imageAsset, int cellIndex, int cellOffsetX, int cellOffsetY, int cellWidth, int cellHeight, string cellName);
         private static _ImageAssetSetExplicitCell _ImageAssetSetExplicitCellFunc;
         internal static bool ImageAssetSetExplicitCell(IntPtr imageAsset, int cellIndex, int cellOffsetX, int cellOffsetY, int cellWidth, int cellHeight, string cellName)
         {
            if (_ImageAssetSetExplicitCellFunc == null)
            {
               _ImageAssetSetExplicitCellFunc =
                  (_ImageAssetSetExplicitCell)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetSetExplicitCell"), typeof(_ImageAssetSetExplicitCell));
            }

            return _ImageAssetSetExplicitCellFunc(imageAsset, cellIndex, cellOffsetX, cellOffsetY, cellWidth, cellHeight, cellName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetExplicitCellCount(IntPtr imageAsset);
         private static _ImageAssetGetExplicitCellCount _ImageAssetGetExplicitCellCountFunc;
         internal static int ImageAssetGetExplicitCellCount(IntPtr imageAsset)
         {
            if (_ImageAssetGetExplicitCellCountFunc == null)
            {
               _ImageAssetGetExplicitCellCountFunc =
                  (_ImageAssetGetExplicitCellCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetExplicitCellCount"), typeof(_ImageAssetGetExplicitCellCount));
            }

            return _ImageAssetGetExplicitCellCountFunc(imageAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ImageAssetGetExplicitCellOffset(IntPtr imageAsset, int cellIdx);
         private static _ImageAssetGetExplicitCellOffset _ImageAssetGetExplicitCellOffsetFunc;
         internal static IntPtr ImageAssetGetExplicitCellOffset(IntPtr imageAsset, int cellIdx)
         {
            if (_ImageAssetGetExplicitCellOffsetFunc == null)
            {
               _ImageAssetGetExplicitCellOffsetFunc =
                  (_ImageAssetGetExplicitCellOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetExplicitCellOffset"), typeof(_ImageAssetGetExplicitCellOffset));
            }

            return _ImageAssetGetExplicitCellOffsetFunc(imageAsset, cellIdx);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ImageAssetGetExplicitCellOffsetByName(IntPtr imageAsset, string cellName);
         private static _ImageAssetGetExplicitCellOffsetByName _ImageAssetGetExplicitCellOffsetByNameFunc;
         internal static IntPtr ImageAssetGetExplicitCellOffsetByName(IntPtr imageAsset, string cellName)
         {
            if (_ImageAssetGetExplicitCellOffsetByNameFunc == null)
            {
               _ImageAssetGetExplicitCellOffsetByNameFunc =
                  (_ImageAssetGetExplicitCellOffsetByName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetExplicitCellOffsetByName"), typeof(_ImageAssetGetExplicitCellOffsetByName));
            }

            return _ImageAssetGetExplicitCellOffsetByNameFunc(imageAsset, cellName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetExplicitCellWidth(IntPtr imageAsset, int cellIdx);
         private static _ImageAssetGetExplicitCellWidth _ImageAssetGetExplicitCellWidthFunc;
         internal static int ImageAssetGetExplicitCellWidth(IntPtr imageAsset, int cellIdx)
         {
            if (_ImageAssetGetExplicitCellWidthFunc == null)
            {
               _ImageAssetGetExplicitCellWidthFunc =
                  (_ImageAssetGetExplicitCellWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetExplicitCellWidth"), typeof(_ImageAssetGetExplicitCellWidth));
            }

            return _ImageAssetGetExplicitCellWidthFunc(imageAsset, cellIdx);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetExplicitCellWidthByName(IntPtr imageAsset, string cellName);
         private static _ImageAssetGetExplicitCellWidthByName _ImageAssetGetExplicitCellWidthByNameFunc;
         internal static int ImageAssetGetExplicitCellWidthByName(IntPtr imageAsset, string cellName)
         {
            if (_ImageAssetGetExplicitCellWidthByNameFunc == null)
            {
               _ImageAssetGetExplicitCellWidthByNameFunc =
                  (_ImageAssetGetExplicitCellWidthByName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetExplicitCellWidthByName"), typeof(_ImageAssetGetExplicitCellWidthByName));
            }

            return _ImageAssetGetExplicitCellWidthByNameFunc(imageAsset, cellName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetExplicitCellHeight(IntPtr imageAsset, int cellIdx);
         private static _ImageAssetGetExplicitCellHeight _ImageAssetGetExplicitCellHeightFunc;
         internal static int ImageAssetGetExplicitCellHeight(IntPtr imageAsset, int cellIdx)
         {
            if (_ImageAssetGetExplicitCellHeightFunc == null)
            {
               _ImageAssetGetExplicitCellHeightFunc =
                  (_ImageAssetGetExplicitCellHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetExplicitCellHeight"), typeof(_ImageAssetGetExplicitCellHeight));
            }

            return _ImageAssetGetExplicitCellHeightFunc(imageAsset, cellIdx);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetExplicitCellHeightByName(IntPtr imageAsset, string cellName);
         private static _ImageAssetGetExplicitCellHeightByName _ImageAssetGetExplicitCellHeightByNameFunc;
         internal static int ImageAssetGetExplicitCellHeightByName(IntPtr imageAsset, string cellName)
         {
            if (_ImageAssetGetExplicitCellHeightByNameFunc == null)
            {
               _ImageAssetGetExplicitCellHeightByNameFunc =
                  (_ImageAssetGetExplicitCellHeightByName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetExplicitCellHeightByName"), typeof(_ImageAssetGetExplicitCellHeightByName));
            }

            return _ImageAssetGetExplicitCellHeightByNameFunc(imageAsset, cellName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ImageAssetGetExplicitCellName(IntPtr imageAsset, int cellIdx);
         private static _ImageAssetGetExplicitCellName _ImageAssetGetExplicitCellNameFunc;
         internal static IntPtr ImageAssetGetExplicitCellName(IntPtr imageAsset, int cellIdx)
         {
            if (_ImageAssetGetExplicitCellNameFunc == null)
            {
               _ImageAssetGetExplicitCellNameFunc =
                  (_ImageAssetGetExplicitCellName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetExplicitCellName"), typeof(_ImageAssetGetExplicitCellName));
            }

            return _ImageAssetGetExplicitCellNameFunc(imageAsset, cellIdx);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ImageAssetGetExplicitCellIndex(IntPtr imageAsset, string cellName);
         private static _ImageAssetGetExplicitCellIndex _ImageAssetGetExplicitCellIndexFunc;
         internal static int ImageAssetGetExplicitCellIndex(IntPtr imageAsset, string cellName)
         {
            if (_ImageAssetGetExplicitCellIndexFunc == null)
            {
               _ImageAssetGetExplicitCellIndexFunc =
                  (_ImageAssetGetExplicitCellIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ImageAssetGetExplicitCellIndex"), typeof(_ImageAssetGetExplicitCellIndex));
            }

            return _ImageAssetGetExplicitCellIndexFunc(imageAsset, cellName);
         }
      }
      
      #endregion

      #region Properties

      public string ImageFile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ImageAssetGetImageFile(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetImageFile(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Force16bit
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetForce16Bit(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetForce16Bit(ObjectPtr->ObjPtr, value);
         }
      }
      public string FilterMode
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ImageAssetGetFilterMode(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetFilterMode(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ExplicitMode
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetExplicitMode(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetExplicitMode(ObjectPtr->ObjPtr, value);
         }
      }
      public bool CellRowOrder
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetCellRowOrder(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetCellRowOrder(ObjectPtr->ObjPtr, value);
         }
      }
      public int CellOffsetX
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetCellOffsetX(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetCellOffsetX(ObjectPtr->ObjPtr, value);
         }
      }
      public int CellOffsetY
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetCellOffsetY(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetCellOffsetY(ObjectPtr->ObjPtr, value);
         }
      }
      public int CellStrideX
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetCellStrideX(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetCellStrideX(ObjectPtr->ObjPtr, value);
         }
      }
      public int CellStrideY
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetCellStrideY(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetCellStrideY(ObjectPtr->ObjPtr, value);
         }
      }
      public int CellCountX
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetCellCountX(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetCellCountX(ObjectPtr->ObjPtr, value);
         }
      }
      public int CellCountY
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetCellCountY(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetCellCountY(ObjectPtr->ObjPtr, value);
         }
      }
      public int CellWidth
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetCellWidth(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetCellWidth(ObjectPtr->ObjPtr, value);
         }
      }
      public int CellHeight
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ImageAssetGetCellHeight(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ImageAssetSetCellHeight(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public int GetImageWidth()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetGetImageWidth(ObjectPtr->ObjPtr);
      }

      public int GetImageHeight()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetGetImageHeight(ObjectPtr->ObjPtr);
      }

      public string GetImageSize()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ImageAssetGetImageSize(ObjectPtr->ObjPtr));
      }

      public bool GetIsImagePOT()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetGetIsImagePOT(ObjectPtr->ObjPtr);
      }

      public int GetFrameCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetGetFrameCount(ObjectPtr->ObjPtr);
      }

      public string GetFrameSize(int frame)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ImageAssetGetFrameSize(ObjectPtr->ObjPtr, frame));
      }

      public bool ClearExplicitCells()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetClearExplicitCells(ObjectPtr->ObjPtr);
      }

      public bool AddExplicitCell(int cellOffsetX, int cellOffsetY, int cellWidth, int cellHeight, string cellName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetAddExplicitCell(ObjectPtr->ObjPtr, cellOffsetX, cellOffsetY, cellWidth, cellHeight, cellName);
      }

      public bool InsertExplicitCell(int cellIndex, int cellOffsetX, int cellOffsetY, int cellWidth, int cellHeight, string cellName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetInsertExplicitCell(ObjectPtr->ObjPtr, cellIndex, cellOffsetX, cellOffsetY, cellWidth, cellHeight, cellName);
      }

      public bool RemoveExplicitCell(int cellIdx)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetRemoveExplicitCell(ObjectPtr->ObjPtr, cellIdx);
      }

      public bool SetExplicitCell(int cellIndex, int cellOffsetX, int cellOffsetY, int cellWidth, int cellHeight, string cellName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetSetExplicitCell(ObjectPtr->ObjPtr, cellIndex, cellOffsetX, cellOffsetY, cellWidth, cellHeight, cellName);
      }

      public int GetExplicitCellCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetGetExplicitCellCount(ObjectPtr->ObjPtr);
      }

      public string GetExplicitCellOffset(int cellIdx)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ImageAssetGetExplicitCellOffset(ObjectPtr->ObjPtr, cellIdx));
      }

      public string GetExplicitCellOffsetByName(string cellName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ImageAssetGetExplicitCellOffsetByName(ObjectPtr->ObjPtr, cellName));
      }

      public int GetExplicitCellWidth(int cellIdx)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetGetExplicitCellWidth(ObjectPtr->ObjPtr, cellIdx);
      }

      public int GetExplicitCellWidthByName(string cellName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetGetExplicitCellWidthByName(ObjectPtr->ObjPtr, cellName);
      }

      public int GetExplicitCellHeight(int cellIdx)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetGetExplicitCellHeight(ObjectPtr->ObjPtr, cellIdx);
      }

      public int GetExplicitCellHeightByName(string cellName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetGetExplicitCellHeightByName(ObjectPtr->ObjPtr, cellName);
      }

      public string GetExplicitCellName(int cellIdx)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ImageAssetGetExplicitCellName(ObjectPtr->ObjPtr, cellIdx));
      }

      public int GetExplicitCellIndex(string cellName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ImageAssetGetExplicitCellIndex(ObjectPtr->ObjPtr, cellName);
      }
      
      #endregion

      
   }
}