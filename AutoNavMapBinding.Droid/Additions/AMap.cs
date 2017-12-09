using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amap.Api.Maps
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']"
    [global::Android.Runtime.Register("com/amap/api/maps/AMap", DoNotGenerateAcw = true)]
    public sealed partial class AMap : global::Java.Lang.Object
    {


        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='CHINESE']"
        [Register("CHINESE")]
        public const string Chinese = (string)"zh_cn";

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='ENGLISH']"
        [Register("ENGLISH")]
        public const string English = (string)"en";

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='LOCATION_TYPE_LOCATE']"
        [Register("LOCATION_TYPE_LOCATE")]
        public const int LocationTypeLocate = (int)1;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='LOCATION_TYPE_MAP_FOLLOW']"
        [Register("LOCATION_TYPE_MAP_FOLLOW")]
        public const int LocationTypeMapFollow = (int)2;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='LOCATION_TYPE_MAP_ROTATE']"
        [Register("LOCATION_TYPE_MAP_ROTATE")]
        public const int LocationTypeMapRotate = (int)3;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='MAP_TYPE_BUS']"
        [Register("MAP_TYPE_BUS")]
        public const int MapTypeBus = (int)5;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='MAP_TYPE_NAVI']"
        [Register("MAP_TYPE_NAVI")]
        public const int MapTypeNavi = (int)4;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='MAP_TYPE_NIGHT']"
        [Register("MAP_TYPE_NIGHT")]
        public const int MapTypeNight = (int)3;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='MAP_TYPE_NORMAL']"
        [Register("MAP_TYPE_NORMAL")]
        public const int MapTypeNormal = (int)1;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='MAP_TYPE_SATELLITE']"
        [Register("MAP_TYPE_SATELLITE")]
        public const int MapTypeSatellite = (int)2;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='MASK_LAYER_NONE']"
        [Register("MASK_LAYER_NONE")]
        public const int MaskLayerNone = (int)-1;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='MASK_LAYER_UNDER_LINE']"
        [Register("MASK_LAYER_UNDER_LINE")]
        public const int MaskLayerUnderLine = (int)1;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/field[@name='MASK_LAYER_UNDER_MARKER']"
        [Register("MASK_LAYER_UNDER_MARKER")]
        public const int MaskLayerUnderMarker = (int)0;
        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.CancelableCallback']"
        [Register("com/amap/api/maps/AMap$CancelableCallback", "", "Com.Amap.Api.Maps.AMap/ICancelableCallbackInvoker")]
        public partial interface ICancelableCallback : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.CancelableCallback']/method[@name='onCancel' and count(parameter)=0]"
            [Register("onCancel", "()V", "GetOnCancelHandler:Com.Amap.Api.Maps.AMap/ICancelableCallbackInvoker, AutoNavMapBinding.Droid")]
            void OnCancel();

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.CancelableCallback']/method[@name='onFinish' and count(parameter)=0]"
            [Register("onFinish", "()V", "GetOnFinishHandler:Com.Amap.Api.Maps.AMap/ICancelableCallbackInvoker, AutoNavMapBinding.Droid")]
            void OnFinish();

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$CancelableCallback", DoNotGenerateAcw = true)]
        internal class ICancelableCallbackInvoker : global::Java.Lang.Object, ICancelableCallback
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$CancelableCallback");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(ICancelableCallbackInvoker); }
            }

            IntPtr class_ref;

            public static ICancelableCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<ICancelableCallback>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.CancelableCallback"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public ICancelableCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onCancel;
#pragma warning disable 0169
            static Delegate GetOnCancelHandler()
            {
                if (cb_onCancel == null)
                    cb_onCancel = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_OnCancel);
                return cb_onCancel;
            }

            static void n_OnCancel(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Amap.Api.Maps.AMap.ICancelableCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.ICancelableCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                __this.OnCancel();
            }
#pragma warning restore 0169

            IntPtr id_onCancel;
            public unsafe void OnCancel()
            {
                if (id_onCancel == IntPtr.Zero)
                    id_onCancel = JNIEnv.GetMethodID(class_ref, "onCancel", "()V");
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onCancel);
            }

            static Delegate cb_onFinish;
#pragma warning disable 0169
            static Delegate GetOnFinishHandler()
            {
                if (cb_onFinish == null)
                    cb_onFinish = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_OnFinish);
                return cb_onFinish;
            }

            static void n_OnFinish(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Amap.Api.Maps.AMap.ICancelableCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.ICancelableCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                __this.OnFinish();
            }
#pragma warning restore 0169

            IntPtr id_onFinish;
            public unsafe void OnFinish()
            {
                if (id_onFinish == IntPtr.Zero)
                    id_onFinish = JNIEnv.GetMethodID(class_ref, "onFinish", "()V");
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onFinish);
            }

        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.ImageInfoWindowAdapter']"
        [Register("com/amap/api/maps/AMap$ImageInfoWindowAdapter", "", "Com.Amap.Api.Maps.AMap/IImageInfoWindowAdapterInvoker")]
        public partial interface IImageInfoWindowAdapter : global::Com.Amap.Api.Maps.AMap.IInfoWindowAdapter
        {

            long InfoWindowUpdateTime
            {
                // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.ImageInfoWindowAdapter']/method[@name='getInfoWindowUpdateTime' and count(parameter)=0]"
                [Register("getInfoWindowUpdateTime", "()J", "GetGetInfoWindowUpdateTimeHandler:Com.Amap.Api.Maps.AMap/IImageInfoWindowAdapterInvoker, AutoNavMapBinding.Droid")]
                get;
            }

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$ImageInfoWindowAdapter", DoNotGenerateAcw = true)]
        internal class IImageInfoWindowAdapterInvoker : global::Java.Lang.Object, IImageInfoWindowAdapter
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$ImageInfoWindowAdapter");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IImageInfoWindowAdapterInvoker); }
            }

            IntPtr class_ref;

            public static IImageInfoWindowAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IImageInfoWindowAdapter>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.ImageInfoWindowAdapter"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IImageInfoWindowAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_getInfoWindowUpdateTime;
#pragma warning disable 0169
            static Delegate GetGetInfoWindowUpdateTimeHandler()
            {
                if (cb_getInfoWindowUpdateTime == null)
                    cb_getInfoWindowUpdateTime = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, long>)n_GetInfoWindowUpdateTime);
                return cb_getInfoWindowUpdateTime;
            }

            static long n_GetInfoWindowUpdateTime(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Amap.Api.Maps.AMap.IImageInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IImageInfoWindowAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return __this.InfoWindowUpdateTime;
            }
#pragma warning restore 0169

            IntPtr id_getInfoWindowUpdateTime;
            public unsafe long InfoWindowUpdateTime
            {
                get
                {
                    if (id_getInfoWindowUpdateTime == IntPtr.Zero)
                        id_getInfoWindowUpdateTime = JNIEnv.GetMethodID(class_ref, "getInfoWindowUpdateTime", "()J");
                    return JNIEnv.CallLongMethod(((global::Java.Lang.Object)this).Handle, id_getInfoWindowUpdateTime);
                }
            }

            static Delegate cb_getInfoContents_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetGetInfoContents_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_getInfoContents_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_getInfoContents_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_GetInfoContents_Lcom_amap_api_maps_model_Marker_);
                return cb_getInfoContents_Lcom_amap_api_maps_model_Marker_;
            }

            static IntPtr n_GetInfoContents_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IImageInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IImageInfoWindowAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetInfoContents(p0));
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_getInfoContents_Lcom_amap_api_maps_model_Marker_;
            public unsafe global::Android.Views.View GetInfoContents(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_getInfoContents_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_getInfoContents_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "getInfoContents", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getInfoContents_Lcom_amap_api_maps_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }

            static Delegate cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetGetInfoWindow_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_GetInfoWindow_Lcom_amap_api_maps_model_Marker_);
                return cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_;
            }

            static IntPtr n_GetInfoWindow_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IImageInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IImageInfoWindowAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetInfoWindow(p0));
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_getInfoWindow_Lcom_amap_api_maps_model_Marker_;
            public unsafe global::Android.Views.View GetInfoWindow(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_getInfoWindow_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_getInfoWindow_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "getInfoWindow", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getInfoWindow_Lcom_amap_api_maps_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }

        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.InfoWindowAdapter']"
        [Register("com/amap/api/maps/AMap$InfoWindowAdapter", "", "Com.Amap.Api.Maps.AMap/IInfoWindowAdapterInvoker")]
        public partial interface IInfoWindowAdapter : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.InfoWindowAdapter']/method[@name='getInfoContents' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Marker']]"
            [Register("getInfoContents", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;", "GetGetInfoContents_Lcom_amap_api_maps_model_Marker_Handler:Com.Amap.Api.Maps.AMap/IInfoWindowAdapterInvoker, AutoNavMapBinding.Droid")]
            global::Android.Views.View GetInfoContents(global::Com.Amap.Api.Maps.Model.Marker p0);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.InfoWindowAdapter']/method[@name='getInfoWindow' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Marker']]"
            [Register("getInfoWindow", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;", "GetGetInfoWindow_Lcom_amap_api_maps_model_Marker_Handler:Com.Amap.Api.Maps.AMap/IInfoWindowAdapterInvoker, AutoNavMapBinding.Droid")]
            global::Android.Views.View GetInfoWindow(global::Com.Amap.Api.Maps.Model.Marker p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$InfoWindowAdapter", DoNotGenerateAcw = true)]
        internal class IInfoWindowAdapterInvoker : global::Java.Lang.Object, IInfoWindowAdapter
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$InfoWindowAdapter");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IInfoWindowAdapterInvoker); }
            }

            IntPtr class_ref;

            public static IInfoWindowAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IInfoWindowAdapter>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.InfoWindowAdapter"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IInfoWindowAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_getInfoContents_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetGetInfoContents_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_getInfoContents_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_getInfoContents_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_GetInfoContents_Lcom_amap_api_maps_model_Marker_);
                return cb_getInfoContents_Lcom_amap_api_maps_model_Marker_;
            }

            static IntPtr n_GetInfoContents_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IInfoWindowAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetInfoContents(p0));
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_getInfoContents_Lcom_amap_api_maps_model_Marker_;
            public unsafe global::Android.Views.View GetInfoContents(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_getInfoContents_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_getInfoContents_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "getInfoContents", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getInfoContents_Lcom_amap_api_maps_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }

            static Delegate cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetGetInfoWindow_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_GetInfoWindow_Lcom_amap_api_maps_model_Marker_);
                return cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_;
            }

            static IntPtr n_GetInfoWindow_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IInfoWindowAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetInfoWindow(p0));
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_getInfoWindow_Lcom_amap_api_maps_model_Marker_;
            public unsafe global::Android.Views.View GetInfoWindow(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_getInfoWindow_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_getInfoWindow_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "getInfoWindow", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getInfoWindow_Lcom_amap_api_maps_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }

        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.MultiPositionInfoWindowAdapter']"
        [Register("com/amap/api/maps/AMap$MultiPositionInfoWindowAdapter", "", "Com.Amap.Api.Maps.AMap/IMultiPositionInfoWindowAdapterInvoker")]
        public partial interface IMultiPositionInfoWindowAdapter : global::Com.Amap.Api.Maps.AMap.IInfoWindowAdapter
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.MultiPositionInfoWindowAdapter']/method[@name='getInfoWindowClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Marker']]"
            [Register("getInfoWindowClick", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;", "GetGetInfoWindowClick_Lcom_amap_api_maps_model_Marker_Handler:Com.Amap.Api.Maps.AMap/IMultiPositionInfoWindowAdapterInvoker, AutoNavMapBinding.Droid")]
            global::Android.Views.View GetInfoWindowClick(global::Com.Amap.Api.Maps.Model.Marker p0);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.MultiPositionInfoWindowAdapter']/method[@name='getOverturnInfoWindow' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Marker']]"
            [Register("getOverturnInfoWindow", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;", "GetGetOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_Handler:Com.Amap.Api.Maps.AMap/IMultiPositionInfoWindowAdapterInvoker, AutoNavMapBinding.Droid")]
            global::Android.Views.View GetOverturnInfoWindow(global::Com.Amap.Api.Maps.Model.Marker p0);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.MultiPositionInfoWindowAdapter']/method[@name='getOverturnInfoWindowClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Marker']]"
            [Register("getOverturnInfoWindowClick", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;", "GetGetOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_Handler:Com.Amap.Api.Maps.AMap/IMultiPositionInfoWindowAdapterInvoker, AutoNavMapBinding.Droid")]
            global::Android.Views.View GetOverturnInfoWindowClick(global::Com.Amap.Api.Maps.Model.Marker p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$MultiPositionInfoWindowAdapter", DoNotGenerateAcw = true)]
        internal class IMultiPositionInfoWindowAdapterInvoker : global::Java.Lang.Object, IMultiPositionInfoWindowAdapter
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$MultiPositionInfoWindowAdapter");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IMultiPositionInfoWindowAdapterInvoker); }
            }

            IntPtr class_ref;

            public static IMultiPositionInfoWindowAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IMultiPositionInfoWindowAdapter>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.MultiPositionInfoWindowAdapter"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IMultiPositionInfoWindowAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_getInfoWindowClick_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetGetInfoWindowClick_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_getInfoWindowClick_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_getInfoWindowClick_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_GetInfoWindowClick_Lcom_amap_api_maps_model_Marker_);
                return cb_getInfoWindowClick_Lcom_amap_api_maps_model_Marker_;
            }

            static IntPtr n_GetInfoWindowClick_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IMultiPositionInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IMultiPositionInfoWindowAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetInfoWindowClick(p0));
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_getInfoWindowClick_Lcom_amap_api_maps_model_Marker_;
            public unsafe global::Android.Views.View GetInfoWindowClick(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_getInfoWindowClick_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_getInfoWindowClick_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "getInfoWindowClick", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getInfoWindowClick_Lcom_amap_api_maps_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }

            static Delegate cb_getOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetGetOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_getOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_getOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_GetOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_);
                return cb_getOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_;
            }

            static IntPtr n_GetOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IMultiPositionInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IMultiPositionInfoWindowAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetOverturnInfoWindow(p0));
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_getOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_;
            public unsafe global::Android.Views.View GetOverturnInfoWindow(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_getOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_getOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "getOverturnInfoWindow", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getOverturnInfoWindow_Lcom_amap_api_maps_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }

            static Delegate cb_getOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetGetOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_getOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_getOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_GetOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_);
                return cb_getOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_;
            }

            static IntPtr n_GetOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IMultiPositionInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IMultiPositionInfoWindowAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetOverturnInfoWindowClick(p0));
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_getOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_;
            public unsafe global::Android.Views.View GetOverturnInfoWindowClick(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_getOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_getOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "getOverturnInfoWindowClick", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getOverturnInfoWindowClick_Lcom_amap_api_maps_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }

            static Delegate cb_getInfoContents_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetGetInfoContents_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_getInfoContents_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_getInfoContents_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_GetInfoContents_Lcom_amap_api_maps_model_Marker_);
                return cb_getInfoContents_Lcom_amap_api_maps_model_Marker_;
            }

            static IntPtr n_GetInfoContents_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IMultiPositionInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IMultiPositionInfoWindowAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetInfoContents(p0));
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_getInfoContents_Lcom_amap_api_maps_model_Marker_;
            public unsafe global::Android.Views.View GetInfoContents(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_getInfoContents_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_getInfoContents_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "getInfoContents", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getInfoContents_Lcom_amap_api_maps_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }

            static Delegate cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetGetInfoWindow_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_GetInfoWindow_Lcom_amap_api_maps_model_Marker_);
                return cb_getInfoWindow_Lcom_amap_api_maps_model_Marker_;
            }

            static IntPtr n_GetInfoWindow_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IMultiPositionInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IMultiPositionInfoWindowAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetInfoWindow(p0));
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_getInfoWindow_Lcom_amap_api_maps_model_Marker_;
            public unsafe global::Android.Views.View GetInfoWindow(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_getInfoWindow_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_getInfoWindow_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "getInfoWindow", "(Lcom/amap/api/maps/model/Marker;)Landroid/view/View;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getInfoWindow_Lcom_amap_api_maps_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }

        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnCacheRemoveListener']"
        [Register("com/amap/api/maps/AMap$OnCacheRemoveListener", "", "Com.Amap.Api.Maps.AMap/IOnCacheRemoveListenerInvoker")]
        public partial interface IOnCacheRemoveListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnCacheRemoveListener']/method[@name='onRemoveCacheFinish' and count(parameter)=1 and parameter[1][@type='boolean']]"
            [Register("onRemoveCacheFinish", "(Z)V", "GetOnRemoveCacheFinish_ZHandler:Com.Amap.Api.Maps.AMap/IOnCacheRemoveListenerInvoker, AutoNavMapBinding.Droid")]
            void OnRemoveCacheFinish(bool p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnCacheRemoveListener", DoNotGenerateAcw = true)]
        internal class IOnCacheRemoveListenerInvoker : global::Java.Lang.Object, IOnCacheRemoveListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnCacheRemoveListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnCacheRemoveListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnCacheRemoveListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnCacheRemoveListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnCacheRemoveListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnCacheRemoveListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onRemoveCacheFinish_Z;
#pragma warning disable 0169
            static Delegate GetOnRemoveCacheFinish_ZHandler()
            {
                if (cb_onRemoveCacheFinish_Z == null)
                    cb_onRemoveCacheFinish_Z = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, bool>)n_OnRemoveCacheFinish_Z);
                return cb_onRemoveCacheFinish_Z;
            }

            static void n_OnRemoveCacheFinish_Z(IntPtr jnienv, IntPtr native__this, bool p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnCacheRemoveListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnCacheRemoveListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                __this.OnRemoveCacheFinish(p0);
            }
#pragma warning restore 0169

            IntPtr id_onRemoveCacheFinish_Z;
            public unsafe void OnRemoveCacheFinish(bool p0)
            {
                if (id_onRemoveCacheFinish_Z == IntPtr.Zero)
                    id_onRemoveCacheFinish_Z = JNIEnv.GetMethodID(class_ref, "onRemoveCacheFinish", "(Z)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onRemoveCacheFinish_Z, __args);
            }

        }

        public partial class CacheRemoveEventArgs : global::System.EventArgs
        {

            public CacheRemoveEventArgs(bool p0)
            {
                this.p0 = p0;
            }

            bool p0;
            public bool P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnCacheRemoveListenerImplementor")]
        internal sealed partial class IOnCacheRemoveListenerImplementor : global::Java.Lang.Object, IOnCacheRemoveListener
        {

            object sender;

            public IOnCacheRemoveListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnCacheRemoveListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<CacheRemoveEventArgs> Handler;
#pragma warning restore 0649

            public void OnRemoveCacheFinish(bool p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new CacheRemoveEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnCacheRemoveListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnCameraChangeListener']"
        [Register("com/amap/api/maps/AMap$OnCameraChangeListener", "", "Com.Amap.Api.Maps.AMap/IOnCameraChangeListenerInvoker")]
        public partial interface IOnCameraChangeListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnCameraChangeListener']/method[@name='onCameraChange' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.CameraPosition']]"
            [Register("onCameraChange", "(Lcom/amap/api/maps/model/CameraPosition;)V", "GetOnCameraChange_Lcom_amap_api_maps_model_CameraPosition_Handler:Com.Amap.Api.Maps.AMap/IOnCameraChangeListenerInvoker, AutoNavMapBinding.Droid")]
            void OnCameraChange(global::Com.Amap.Api.Maps.Model.CameraPosition p0);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnCameraChangeListener']/method[@name='onCameraChangeFinish' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.CameraPosition']]"
            [Register("onCameraChangeFinish", "(Lcom/amap/api/maps/model/CameraPosition;)V", "GetOnCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_Handler:Com.Amap.Api.Maps.AMap/IOnCameraChangeListenerInvoker, AutoNavMapBinding.Droid")]
            void OnCameraChangeFinish(global::Com.Amap.Api.Maps.Model.CameraPosition p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnCameraChangeListener", DoNotGenerateAcw = true)]
        internal class IOnCameraChangeListenerInvoker : global::Java.Lang.Object, IOnCameraChangeListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnCameraChangeListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnCameraChangeListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnCameraChangeListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnCameraChangeListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnCameraChangeListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnCameraChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onCameraChange_Lcom_amap_api_maps_model_CameraPosition_;
#pragma warning disable 0169
            static Delegate GetOnCameraChange_Lcom_amap_api_maps_model_CameraPosition_Handler()
            {
                if (cb_onCameraChange_Lcom_amap_api_maps_model_CameraPosition_ == null)
                    cb_onCameraChange_Lcom_amap_api_maps_model_CameraPosition_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnCameraChange_Lcom_amap_api_maps_model_CameraPosition_);
                return cb_onCameraChange_Lcom_amap_api_maps_model_CameraPosition_;
            }

            static void n_OnCameraChange_Lcom_amap_api_maps_model_CameraPosition_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.CameraPosition p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.CameraPosition>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnCameraChange(p0);
            }
#pragma warning restore 0169

            IntPtr id_onCameraChange_Lcom_amap_api_maps_model_CameraPosition_;
            public unsafe void OnCameraChange(global::Com.Amap.Api.Maps.Model.CameraPosition p0)
            {
                if (id_onCameraChange_Lcom_amap_api_maps_model_CameraPosition_ == IntPtr.Zero)
                    id_onCameraChange_Lcom_amap_api_maps_model_CameraPosition_ = JNIEnv.GetMethodID(class_ref, "onCameraChange", "(Lcom/amap/api/maps/model/CameraPosition;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onCameraChange_Lcom_amap_api_maps_model_CameraPosition_, __args);
            }

            static Delegate cb_onCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_;
#pragma warning disable 0169
            static Delegate GetOnCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_Handler()
            {
                if (cb_onCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_ == null)
                    cb_onCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_);
                return cb_onCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_;
            }

            static void n_OnCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.CameraPosition p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.CameraPosition>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnCameraChangeFinish(p0);
            }
#pragma warning restore 0169

            IntPtr id_onCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_;
            public unsafe void OnCameraChangeFinish(global::Com.Amap.Api.Maps.Model.CameraPosition p0)
            {
                if (id_onCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_ == IntPtr.Zero)
                    id_onCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_ = JNIEnv.GetMethodID(class_ref, "onCameraChangeFinish", "(Lcom/amap/api/maps/model/CameraPosition;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onCameraChangeFinish_Lcom_amap_api_maps_model_CameraPosition_, __args);
            }

        }

        public partial class CameraChangeEventArgs : global::System.EventArgs
        {

            public CameraChangeEventArgs(global::Com.Amap.Api.Maps.Model.CameraPosition p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.CameraPosition p0;
            public global::Com.Amap.Api.Maps.Model.CameraPosition P0
            {
                get { return p0; }
            }
        }

        public partial class CameraChangeFinishEventArgs : global::System.EventArgs
        {

            public CameraChangeFinishEventArgs(global::Com.Amap.Api.Maps.Model.CameraPosition p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.CameraPosition p0;
            public global::Com.Amap.Api.Maps.Model.CameraPosition P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnCameraChangeListenerImplementor")]
        internal sealed partial class IOnCameraChangeListenerImplementor : global::Java.Lang.Object, IOnCameraChangeListener
        {

            object sender;

            public IOnCameraChangeListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnCameraChangeListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<CameraChangeEventArgs> OnCameraChangeHandler;
#pragma warning restore 0649

            public void OnCameraChange(global::Com.Amap.Api.Maps.Model.CameraPosition p0)
            {
                var __h = OnCameraChangeHandler;
                if (__h != null)
                    __h(sender, new CameraChangeEventArgs(p0));
            }
#pragma warning disable 0649
            public EventHandler<CameraChangeFinishEventArgs> OnCameraChangeFinishHandler;
#pragma warning restore 0649

            public void OnCameraChangeFinish(global::Com.Amap.Api.Maps.Model.CameraPosition p0)
            {
                var __h = OnCameraChangeFinishHandler;
                if (__h != null)
                    __h(sender, new CameraChangeFinishEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnCameraChangeListenerImplementor value)
            {
                return value.OnCameraChangeHandler == null && value.OnCameraChangeFinishHandler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnIndoorBuildingActiveListener']"
        [Register("com/amap/api/maps/AMap$OnIndoorBuildingActiveListener", "", "Com.Amap.Api.Maps.AMap/IOnIndoorBuildingActiveListenerInvoker")]
        public partial interface IOnIndoorBuildingActiveListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnIndoorBuildingActiveListener']/method[@name='OnIndoorBuilding' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.IndoorBuildingInfo']]"
            [Register("OnIndoorBuilding", "(Lcom/amap/api/maps/model/IndoorBuildingInfo;)V", "GetOnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_Handler:Com.Amap.Api.Maps.AMap/IOnIndoorBuildingActiveListenerInvoker, AutoNavMapBinding.Droid")]
            void OnIndoorBuilding(global::Com.Amap.Api.Maps.Model.IndoorBuildingInfo p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnIndoorBuildingActiveListener", DoNotGenerateAcw = true)]
        internal class IOnIndoorBuildingActiveListenerInvoker : global::Java.Lang.Object, IOnIndoorBuildingActiveListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnIndoorBuildingActiveListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnIndoorBuildingActiveListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnIndoorBuildingActiveListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnIndoorBuildingActiveListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnIndoorBuildingActiveListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnIndoorBuildingActiveListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_OnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_;
#pragma warning disable 0169
            static Delegate GetOnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_Handler()
            {
                if (cb_OnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_ == null)
                    cb_OnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_);
                return cb_OnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_;
            }

            static void n_OnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.IndoorBuildingInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.IndoorBuildingInfo>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnIndoorBuilding(p0);
            }
#pragma warning restore 0169

            IntPtr id_OnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_;
            public unsafe void OnIndoorBuilding(global::Com.Amap.Api.Maps.Model.IndoorBuildingInfo p0)
            {
                if (id_OnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_ == IntPtr.Zero)
                    id_OnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_ = JNIEnv.GetMethodID(class_ref, "OnIndoorBuilding", "(Lcom/amap/api/maps/model/IndoorBuildingInfo;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_OnIndoorBuilding_Lcom_amap_api_maps_model_IndoorBuildingInfo_, __args);
            }

        }

        public partial class IndoorBuildingActiveEventArgs : global::System.EventArgs
        {

            public IndoorBuildingActiveEventArgs(global::Com.Amap.Api.Maps.Model.IndoorBuildingInfo p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.IndoorBuildingInfo p0;
            public global::Com.Amap.Api.Maps.Model.IndoorBuildingInfo P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnIndoorBuildingActiveListenerImplementor")]
        internal sealed partial class IOnIndoorBuildingActiveListenerImplementor : global::Java.Lang.Object, IOnIndoorBuildingActiveListener
        {

            object sender;

            public IOnIndoorBuildingActiveListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnIndoorBuildingActiveListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<IndoorBuildingActiveEventArgs> Handler;
#pragma warning restore 0649

            public void OnIndoorBuilding(global::Com.Amap.Api.Maps.Model.IndoorBuildingInfo p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new IndoorBuildingActiveEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnIndoorBuildingActiveListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnInfoWindowClickListener']"
        [Register("com/amap/api/maps/AMap$OnInfoWindowClickListener", "", "Com.Amap.Api.Maps.AMap/IOnInfoWindowClickListenerInvoker")]
        public partial interface IOnInfoWindowClickListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnInfoWindowClickListener']/method[@name='onInfoWindowClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Marker']]"
            [Register("onInfoWindowClick", "(Lcom/amap/api/maps/model/Marker;)V", "GetOnInfoWindowClick_Lcom_amap_api_maps_model_Marker_Handler:Com.Amap.Api.Maps.AMap/IOnInfoWindowClickListenerInvoker, AutoNavMapBinding.Droid")]
            void OnInfoWindowClick(global::Com.Amap.Api.Maps.Model.Marker p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnInfoWindowClickListener", DoNotGenerateAcw = true)]
        internal class IOnInfoWindowClickListenerInvoker : global::Java.Lang.Object, IOnInfoWindowClickListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnInfoWindowClickListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnInfoWindowClickListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnInfoWindowClickListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnInfoWindowClickListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnInfoWindowClickListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnInfoWindowClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onInfoWindowClick_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetOnInfoWindowClick_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_onInfoWindowClick_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_onInfoWindowClick_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnInfoWindowClick_Lcom_amap_api_maps_model_Marker_);
                return cb_onInfoWindowClick_Lcom_amap_api_maps_model_Marker_;
            }

            static void n_OnInfoWindowClick_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnInfoWindowClick(p0);
            }
#pragma warning restore 0169

            IntPtr id_onInfoWindowClick_Lcom_amap_api_maps_model_Marker_;
            public unsafe void OnInfoWindowClick(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_onInfoWindowClick_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_onInfoWindowClick_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "onInfoWindowClick", "(Lcom/amap/api/maps/model/Marker;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onInfoWindowClick_Lcom_amap_api_maps_model_Marker_, __args);
            }

        }

        public partial class InfoWindowClickEventArgs : global::System.EventArgs
        {

            public InfoWindowClickEventArgs(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.Marker p0;
            public global::Com.Amap.Api.Maps.Model.Marker P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnInfoWindowClickListenerImplementor")]
        internal sealed partial class IOnInfoWindowClickListenerImplementor : global::Java.Lang.Object, IOnInfoWindowClickListener
        {

            object sender;

            public IOnInfoWindowClickListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnInfoWindowClickListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<InfoWindowClickEventArgs> Handler;
#pragma warning restore 0649

            public void OnInfoWindowClick(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new InfoWindowClickEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnInfoWindowClickListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapClickListener']"
        [Register("com/amap/api/maps/AMap$OnMapClickListener", "", "Com.Amap.Api.Maps.AMap/IOnMapClickListenerInvoker")]
        public partial interface IOnMapClickListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapClickListener']/method[@name='onMapClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.LatLng']]"
            [Register("onMapClick", "(Lcom/amap/api/maps/model/LatLng;)V", "GetOnMapClick_Lcom_amap_api_maps_model_LatLng_Handler:Com.Amap.Api.Maps.AMap/IOnMapClickListenerInvoker, AutoNavMapBinding.Droid")]
            void OnMapClick(global::Com.Amap.Api.Maps.Model.LatLng p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnMapClickListener", DoNotGenerateAcw = true)]
        internal class IOnMapClickListenerInvoker : global::Java.Lang.Object, IOnMapClickListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnMapClickListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnMapClickListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnMapClickListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnMapClickListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnMapClickListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnMapClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onMapClick_Lcom_amap_api_maps_model_LatLng_;
#pragma warning disable 0169
            static Delegate GetOnMapClick_Lcom_amap_api_maps_model_LatLng_Handler()
            {
                if (cb_onMapClick_Lcom_amap_api_maps_model_LatLng_ == null)
                    cb_onMapClick_Lcom_amap_api_maps_model_LatLng_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMapClick_Lcom_amap_api_maps_model_LatLng_);
                return cb_onMapClick_Lcom_amap_api_maps_model_LatLng_;
            }

            static void n_OnMapClick_Lcom_amap_api_maps_model_LatLng_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMapClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMapClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.LatLng>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnMapClick(p0);
            }
#pragma warning restore 0169

            IntPtr id_onMapClick_Lcom_amap_api_maps_model_LatLng_;
            public unsafe void OnMapClick(global::Com.Amap.Api.Maps.Model.LatLng p0)
            {
                if (id_onMapClick_Lcom_amap_api_maps_model_LatLng_ == IntPtr.Zero)
                    id_onMapClick_Lcom_amap_api_maps_model_LatLng_ = JNIEnv.GetMethodID(class_ref, "onMapClick", "(Lcom/amap/api/maps/model/LatLng;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapClick_Lcom_amap_api_maps_model_LatLng_, __args);
            }

        }

        public partial class MapClickEventArgs : global::System.EventArgs
        {

            public MapClickEventArgs(global::Com.Amap.Api.Maps.Model.LatLng p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.LatLng p0;
            public global::Com.Amap.Api.Maps.Model.LatLng P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnMapClickListenerImplementor")]
        internal sealed partial class IOnMapClickListenerImplementor : global::Java.Lang.Object, IOnMapClickListener
        {

            object sender;

            public IOnMapClickListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnMapClickListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<MapClickEventArgs> Handler;
#pragma warning restore 0649

            public void OnMapClick(global::Com.Amap.Api.Maps.Model.LatLng p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new MapClickEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnMapClickListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapLoadedListener']"
        [Register("com/amap/api/maps/AMap$OnMapLoadedListener", "", "Com.Amap.Api.Maps.AMap/IOnMapLoadedListenerInvoker")]
        public partial interface IOnMapLoadedListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapLoadedListener']/method[@name='onMapLoaded' and count(parameter)=0]"
            [Register("onMapLoaded", "()V", "GetOnMapLoadedHandler:Com.Amap.Api.Maps.AMap/IOnMapLoadedListenerInvoker, AutoNavMapBinding.Droid")]
            void OnMapLoaded();

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnMapLoadedListener", DoNotGenerateAcw = true)]
        internal class IOnMapLoadedListenerInvoker : global::Java.Lang.Object, IOnMapLoadedListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnMapLoadedListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnMapLoadedListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnMapLoadedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnMapLoadedListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnMapLoadedListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnMapLoadedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onMapLoaded;
#pragma warning disable 0169
            static Delegate GetOnMapLoadedHandler()
            {
                if (cb_onMapLoaded == null)
                    cb_onMapLoaded = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_OnMapLoaded);
                return cb_onMapLoaded;
            }

            static void n_OnMapLoaded(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMapLoadedListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMapLoadedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                __this.OnMapLoaded();
            }
#pragma warning restore 0169

            IntPtr id_onMapLoaded;
            public unsafe void OnMapLoaded()
            {
                if (id_onMapLoaded == IntPtr.Zero)
                    id_onMapLoaded = JNIEnv.GetMethodID(class_ref, "onMapLoaded", "()V");
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapLoaded);
            }

        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnMapLoadedListenerImplementor")]
        internal sealed partial class IOnMapLoadedListenerImplementor : global::Java.Lang.Object, IOnMapLoadedListener
        {

            object sender;

            public IOnMapLoadedListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnMapLoadedListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler Handler;
#pragma warning restore 0649

            public void OnMapLoaded()
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new EventArgs());
            }

            internal static bool __IsEmpty(IOnMapLoadedListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapLongClickListener']"
        [Register("com/amap/api/maps/AMap$OnMapLongClickListener", "", "Com.Amap.Api.Maps.AMap/IOnMapLongClickListenerInvoker")]
        public partial interface IOnMapLongClickListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapLongClickListener']/method[@name='onMapLongClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.LatLng']]"
            [Register("onMapLongClick", "(Lcom/amap/api/maps/model/LatLng;)V", "GetOnMapLongClick_Lcom_amap_api_maps_model_LatLng_Handler:Com.Amap.Api.Maps.AMap/IOnMapLongClickListenerInvoker, AutoNavMapBinding.Droid")]
            void OnMapLongClick(global::Com.Amap.Api.Maps.Model.LatLng p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnMapLongClickListener", DoNotGenerateAcw = true)]
        internal class IOnMapLongClickListenerInvoker : global::Java.Lang.Object, IOnMapLongClickListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnMapLongClickListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnMapLongClickListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnMapLongClickListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnMapLongClickListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnMapLongClickListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnMapLongClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onMapLongClick_Lcom_amap_api_maps_model_LatLng_;
#pragma warning disable 0169
            static Delegate GetOnMapLongClick_Lcom_amap_api_maps_model_LatLng_Handler()
            {
                if (cb_onMapLongClick_Lcom_amap_api_maps_model_LatLng_ == null)
                    cb_onMapLongClick_Lcom_amap_api_maps_model_LatLng_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMapLongClick_Lcom_amap_api_maps_model_LatLng_);
                return cb_onMapLongClick_Lcom_amap_api_maps_model_LatLng_;
            }

            static void n_OnMapLongClick_Lcom_amap_api_maps_model_LatLng_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMapLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMapLongClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.LatLng>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnMapLongClick(p0);
            }
#pragma warning restore 0169

            IntPtr id_onMapLongClick_Lcom_amap_api_maps_model_LatLng_;
            public unsafe void OnMapLongClick(global::Com.Amap.Api.Maps.Model.LatLng p0)
            {
                if (id_onMapLongClick_Lcom_amap_api_maps_model_LatLng_ == IntPtr.Zero)
                    id_onMapLongClick_Lcom_amap_api_maps_model_LatLng_ = JNIEnv.GetMethodID(class_ref, "onMapLongClick", "(Lcom/amap/api/maps/model/LatLng;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapLongClick_Lcom_amap_api_maps_model_LatLng_, __args);
            }

        }

        public partial class MapLongClickEventArgs : global::System.EventArgs
        {

            public MapLongClickEventArgs(global::Com.Amap.Api.Maps.Model.LatLng p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.LatLng p0;
            public global::Com.Amap.Api.Maps.Model.LatLng P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnMapLongClickListenerImplementor")]
        internal sealed partial class IOnMapLongClickListenerImplementor : global::Java.Lang.Object, IOnMapLongClickListener
        {

            object sender;

            public IOnMapLongClickListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnMapLongClickListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<MapLongClickEventArgs> Handler;
#pragma warning restore 0649

            public void OnMapLongClick(global::Com.Amap.Api.Maps.Model.LatLng p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new MapLongClickEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnMapLongClickListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapScreenShotListener']"
        [Register("com/amap/api/maps/AMap$OnMapScreenShotListener", "", "Com.Amap.Api.Maps.AMap/IOnMapScreenShotListenerInvoker")]
        public partial interface IOnMapScreenShotListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapScreenShotListener']/method[@name='onMapScreenShot' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
            [Register("onMapScreenShot", "(Landroid/graphics/Bitmap;)V", "GetOnMapScreenShot_Landroid_graphics_Bitmap_Handler:Com.Amap.Api.Maps.AMap/IOnMapScreenShotListenerInvoker, AutoNavMapBinding.Droid")]
            void OnMapScreenShot(global::Android.Graphics.Bitmap p0);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapScreenShotListener']/method[@name='onMapScreenShot' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
            [Register("onMapScreenShot", "(Landroid/graphics/Bitmap;I)V", "GetOnMapScreenShot_Landroid_graphics_Bitmap_IHandler:Com.Amap.Api.Maps.AMap/IOnMapScreenShotListenerInvoker, AutoNavMapBinding.Droid")]
            void OnMapScreenShot(global::Android.Graphics.Bitmap p0, int p1);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnMapScreenShotListener", DoNotGenerateAcw = true)]
        internal class IOnMapScreenShotListenerInvoker : global::Java.Lang.Object, IOnMapScreenShotListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnMapScreenShotListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnMapScreenShotListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnMapScreenShotListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnMapScreenShotListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnMapScreenShotListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnMapScreenShotListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onMapScreenShot_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
            static Delegate GetOnMapScreenShot_Landroid_graphics_Bitmap_Handler()
            {
                if (cb_onMapScreenShot_Landroid_graphics_Bitmap_ == null)
                    cb_onMapScreenShot_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMapScreenShot_Landroid_graphics_Bitmap_);
                return cb_onMapScreenShot_Landroid_graphics_Bitmap_;
            }

            static void n_OnMapScreenShot_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMapScreenShotListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMapScreenShotListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnMapScreenShot(p0);
            }
#pragma warning restore 0169

            IntPtr id_onMapScreenShot_Landroid_graphics_Bitmap_;
            public unsafe void OnMapScreenShot(global::Android.Graphics.Bitmap p0)
            {
                if (id_onMapScreenShot_Landroid_graphics_Bitmap_ == IntPtr.Zero)
                    id_onMapScreenShot_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID(class_ref, "onMapScreenShot", "(Landroid/graphics/Bitmap;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapScreenShot_Landroid_graphics_Bitmap_, __args);
            }

            static Delegate cb_onMapScreenShot_Landroid_graphics_Bitmap_I;
#pragma warning disable 0169
            static Delegate GetOnMapScreenShot_Landroid_graphics_Bitmap_IHandler()
            {
                if (cb_onMapScreenShot_Landroid_graphics_Bitmap_I == null)
                    cb_onMapScreenShot_Landroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int>)n_OnMapScreenShot_Landroid_graphics_Bitmap_I);
                return cb_onMapScreenShot_Landroid_graphics_Bitmap_I;
            }

            static void n_OnMapScreenShot_Landroid_graphics_Bitmap_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMapScreenShotListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMapScreenShotListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnMapScreenShot(p0, p1);
            }
#pragma warning restore 0169

            IntPtr id_onMapScreenShot_Landroid_graphics_Bitmap_I;
            public unsafe void OnMapScreenShot(global::Android.Graphics.Bitmap p0, int p1)
            {
                if (id_onMapScreenShot_Landroid_graphics_Bitmap_I == IntPtr.Zero)
                    id_onMapScreenShot_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID(class_ref, "onMapScreenShot", "(Landroid/graphics/Bitmap;I)V");
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapScreenShot_Landroid_graphics_Bitmap_I, __args);
            }

        }

        public partial class MapScreenShotEventArgs : global::System.EventArgs
        {

            public MapScreenShotEventArgs(global::Android.Graphics.Bitmap p0)
            {
                this.p0 = p0;
            }

            public MapScreenShotEventArgs(global::Android.Graphics.Bitmap p0, int p1)
            {
                this.p0 = p0;
                this.p1 = p1;
            }

            global::Android.Graphics.Bitmap p0;
            public global::Android.Graphics.Bitmap P0
            {
                get { return p0; }
            }

            int p1;
            public int P1
            {
                get { return p1; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnMapScreenShotListenerImplementor")]
        internal sealed partial class IOnMapScreenShotListenerImplementor : global::Java.Lang.Object, IOnMapScreenShotListener
        {

            object sender;

            public IOnMapScreenShotListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnMapScreenShotListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<MapScreenShotEventArgs> OnMapScreenShotHandler;
#pragma warning restore 0649

            public void OnMapScreenShot(global::Android.Graphics.Bitmap p0)
            {
                var __h = OnMapScreenShotHandler;
                if (__h != null)
                    __h(sender, new MapScreenShotEventArgs(p0));
            }

            public void OnMapScreenShot(global::Android.Graphics.Bitmap p0, int p1)
            {
                var __h = OnMapScreenShotHandler;
                if (__h != null)
                    __h(sender, new MapScreenShotEventArgs(p0, p1));
            }

            internal static bool __IsEmpty(IOnMapScreenShotListenerImplementor value)
            {
                return value.OnMapScreenShotHandler == null && value.OnMapScreenShotHandler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapTouchListener']"
        [Register("com/amap/api/maps/AMap$OnMapTouchListener", "", "Com.Amap.Api.Maps.AMap/IOnMapTouchListenerInvoker")]
        public partial interface IOnMapTouchListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMapTouchListener']/method[@name='onTouch' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
            [Register("onTouch", "(Landroid/view/MotionEvent;)V", "GetOnTouch_Landroid_view_MotionEvent_Handler:Com.Amap.Api.Maps.AMap/IOnMapTouchListenerInvoker, AutoNavMapBinding.Droid")]
            void OnTouch(global::Android.Views.MotionEvent p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnMapTouchListener", DoNotGenerateAcw = true)]
        internal class IOnMapTouchListenerInvoker : global::Java.Lang.Object, IOnMapTouchListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnMapTouchListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnMapTouchListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnMapTouchListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnMapTouchListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnMapTouchListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnMapTouchListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onTouch_Landroid_view_MotionEvent_;
#pragma warning disable 0169
            static Delegate GetOnTouch_Landroid_view_MotionEvent_Handler()
            {
                if (cb_onTouch_Landroid_view_MotionEvent_ == null)
                    cb_onTouch_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnTouch_Landroid_view_MotionEvent_);
                return cb_onTouch_Landroid_view_MotionEvent_;
            }

            static void n_OnTouch_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMapTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMapTouchListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnTouch(p0);
            }
#pragma warning restore 0169

            IntPtr id_onTouch_Landroid_view_MotionEvent_;
            public unsafe void OnTouch(global::Android.Views.MotionEvent p0)
            {
                if (id_onTouch_Landroid_view_MotionEvent_ == IntPtr.Zero)
                    id_onTouch_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID(class_ref, "onTouch", "(Landroid/view/MotionEvent;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onTouch_Landroid_view_MotionEvent_, __args);
            }

        }

        public partial class MapTouchEventArgs : global::System.EventArgs
        {

            public MapTouchEventArgs(global::Android.Views.MotionEvent p0)
            {
                this.p0 = p0;
            }

            global::Android.Views.MotionEvent p0;
            public global::Android.Views.MotionEvent P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnMapTouchListenerImplementor")]
        internal sealed partial class IOnMapTouchListenerImplementor : global::Java.Lang.Object, IOnMapTouchListener
        {

            object sender;

            public IOnMapTouchListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnMapTouchListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<MapTouchEventArgs> Handler;
#pragma warning restore 0649

            public void OnTouch(global::Android.Views.MotionEvent p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new MapTouchEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnMapTouchListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMarkerClickListener']"
        [Register("com/amap/api/maps/AMap$OnMarkerClickListener", "", "Com.Amap.Api.Maps.AMap/IOnMarkerClickListenerInvoker")]
        public partial interface IOnMarkerClickListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMarkerClickListener']/method[@name='onMarkerClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Marker']]"
            [Register("onMarkerClick", "(Lcom/amap/api/maps/model/Marker;)Z", "GetOnMarkerClick_Lcom_amap_api_maps_model_Marker_Handler:Com.Amap.Api.Maps.AMap/IOnMarkerClickListenerInvoker, AutoNavMapBinding.Droid")]
            bool OnMarkerClick(global::Com.Amap.Api.Maps.Model.Marker p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnMarkerClickListener", DoNotGenerateAcw = true)]
        internal class IOnMarkerClickListenerInvoker : global::Java.Lang.Object, IOnMarkerClickListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnMarkerClickListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnMarkerClickListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnMarkerClickListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnMarkerClickListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnMarkerClickListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnMarkerClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onMarkerClick_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetOnMarkerClick_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_onMarkerClick_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_onMarkerClick_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, bool>)n_OnMarkerClick_Lcom_amap_api_maps_model_Marker_);
                return cb_onMarkerClick_Lcom_amap_api_maps_model_Marker_;
            }

            static bool n_OnMarkerClick_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMarkerClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMarkerClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                bool __ret = __this.OnMarkerClick(p0);
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_onMarkerClick_Lcom_amap_api_maps_model_Marker_;
            public unsafe bool OnMarkerClick(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_onMarkerClick_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_onMarkerClick_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "onMarkerClick", "(Lcom/amap/api/maps/model/Marker;)Z");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                bool __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_onMarkerClick_Lcom_amap_api_maps_model_Marker_, __args);
                return __ret;
            }

        }

        public partial class MarkerClickEventArgs : global::System.EventArgs
        {

            public MarkerClickEventArgs(bool handled, global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                this.handled = handled;
                this.p0 = p0;
            }

            bool handled;
            public bool Handled
            {
                get { return handled; }
                set { handled = value; }
            }

            global::Com.Amap.Api.Maps.Model.Marker p0;
            public global::Com.Amap.Api.Maps.Model.Marker P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnMarkerClickListenerImplementor")]
        internal sealed partial class IOnMarkerClickListenerImplementor : global::Java.Lang.Object, IOnMarkerClickListener
        {

            object sender;

            public IOnMarkerClickListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnMarkerClickListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<MarkerClickEventArgs> Handler;
#pragma warning restore 0649

            public bool OnMarkerClick(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                var __h = Handler;
                if (__h == null)
                    return false;
                var __e = new MarkerClickEventArgs(true, p0);
                __h(sender, __e);
                return __e.Handled;
            }

            internal static bool __IsEmpty(IOnMarkerClickListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMarkerDragListener']"
        [Register("com/amap/api/maps/AMap$OnMarkerDragListener", "", "Com.Amap.Api.Maps.AMap/IOnMarkerDragListenerInvoker")]
        public partial interface IOnMarkerDragListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMarkerDragListener']/method[@name='onMarkerDrag' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Marker']]"
            [Register("onMarkerDrag", "(Lcom/amap/api/maps/model/Marker;)V", "GetOnMarkerDrag_Lcom_amap_api_maps_model_Marker_Handler:Com.Amap.Api.Maps.AMap/IOnMarkerDragListenerInvoker, AutoNavMapBinding.Droid")]
            void OnMarkerDrag(global::Com.Amap.Api.Maps.Model.Marker p0);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMarkerDragListener']/method[@name='onMarkerDragEnd' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Marker']]"
            [Register("onMarkerDragEnd", "(Lcom/amap/api/maps/model/Marker;)V", "GetOnMarkerDragEnd_Lcom_amap_api_maps_model_Marker_Handler:Com.Amap.Api.Maps.AMap/IOnMarkerDragListenerInvoker, AutoNavMapBinding.Droid")]
            void OnMarkerDragEnd(global::Com.Amap.Api.Maps.Model.Marker p0);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMarkerDragListener']/method[@name='onMarkerDragStart' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Marker']]"
            [Register("onMarkerDragStart", "(Lcom/amap/api/maps/model/Marker;)V", "GetOnMarkerDragStart_Lcom_amap_api_maps_model_Marker_Handler:Com.Amap.Api.Maps.AMap/IOnMarkerDragListenerInvoker, AutoNavMapBinding.Droid")]
            void OnMarkerDragStart(global::Com.Amap.Api.Maps.Model.Marker p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnMarkerDragListener", DoNotGenerateAcw = true)]
        internal class IOnMarkerDragListenerInvoker : global::Java.Lang.Object, IOnMarkerDragListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnMarkerDragListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnMarkerDragListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnMarkerDragListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnMarkerDragListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnMarkerDragListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnMarkerDragListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onMarkerDrag_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetOnMarkerDrag_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_onMarkerDrag_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_onMarkerDrag_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMarkerDrag_Lcom_amap_api_maps_model_Marker_);
                return cb_onMarkerDrag_Lcom_amap_api_maps_model_Marker_;
            }

            static void n_OnMarkerDrag_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnMarkerDrag(p0);
            }
#pragma warning restore 0169

            IntPtr id_onMarkerDrag_Lcom_amap_api_maps_model_Marker_;
            public unsafe void OnMarkerDrag(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_onMarkerDrag_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_onMarkerDrag_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "onMarkerDrag", "(Lcom/amap/api/maps/model/Marker;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMarkerDrag_Lcom_amap_api_maps_model_Marker_, __args);
            }

            static Delegate cb_onMarkerDragEnd_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetOnMarkerDragEnd_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_onMarkerDragEnd_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_onMarkerDragEnd_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMarkerDragEnd_Lcom_amap_api_maps_model_Marker_);
                return cb_onMarkerDragEnd_Lcom_amap_api_maps_model_Marker_;
            }

            static void n_OnMarkerDragEnd_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnMarkerDragEnd(p0);
            }
#pragma warning restore 0169

            IntPtr id_onMarkerDragEnd_Lcom_amap_api_maps_model_Marker_;
            public unsafe void OnMarkerDragEnd(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_onMarkerDragEnd_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_onMarkerDragEnd_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "onMarkerDragEnd", "(Lcom/amap/api/maps/model/Marker;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMarkerDragEnd_Lcom_amap_api_maps_model_Marker_, __args);
            }

            static Delegate cb_onMarkerDragStart_Lcom_amap_api_maps_model_Marker_;
#pragma warning disable 0169
            static Delegate GetOnMarkerDragStart_Lcom_amap_api_maps_model_Marker_Handler()
            {
                if (cb_onMarkerDragStart_Lcom_amap_api_maps_model_Marker_ == null)
                    cb_onMarkerDragStart_Lcom_amap_api_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMarkerDragStart_Lcom_amap_api_maps_model_Marker_);
                return cb_onMarkerDragStart_Lcom_amap_api_maps_model_Marker_;
            }

            static void n_OnMarkerDragStart_Lcom_amap_api_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnMarkerDragStart(p0);
            }
#pragma warning restore 0169

            IntPtr id_onMarkerDragStart_Lcom_amap_api_maps_model_Marker_;
            public unsafe void OnMarkerDragStart(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                if (id_onMarkerDragStart_Lcom_amap_api_maps_model_Marker_ == IntPtr.Zero)
                    id_onMarkerDragStart_Lcom_amap_api_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "onMarkerDragStart", "(Lcom/amap/api/maps/model/Marker;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMarkerDragStart_Lcom_amap_api_maps_model_Marker_, __args);
            }

        }

        public partial class MarkerDragEventArgs : global::System.EventArgs
        {

            public MarkerDragEventArgs(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.Marker p0;
            public global::Com.Amap.Api.Maps.Model.Marker P0
            {
                get { return p0; }
            }
        }

        public partial class MarkerDragEndEventArgs : global::System.EventArgs
        {

            public MarkerDragEndEventArgs(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.Marker p0;
            public global::Com.Amap.Api.Maps.Model.Marker P0
            {
                get { return p0; }
            }
        }

        public partial class MarkerDragStartEventArgs : global::System.EventArgs
        {

            public MarkerDragStartEventArgs(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.Marker p0;
            public global::Com.Amap.Api.Maps.Model.Marker P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnMarkerDragListenerImplementor")]
        internal sealed partial class IOnMarkerDragListenerImplementor : global::Java.Lang.Object, IOnMarkerDragListener
        {

            object sender;

            public IOnMarkerDragListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnMarkerDragListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<MarkerDragEventArgs> OnMarkerDragHandler;
#pragma warning restore 0649

            public void OnMarkerDrag(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                var __h = OnMarkerDragHandler;
                if (__h != null)
                    __h(sender, new MarkerDragEventArgs(p0));
            }
#pragma warning disable 0649
            public EventHandler<MarkerDragEndEventArgs> OnMarkerDragEndHandler;
#pragma warning restore 0649

            public void OnMarkerDragEnd(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                var __h = OnMarkerDragEndHandler;
                if (__h != null)
                    __h(sender, new MarkerDragEndEventArgs(p0));
            }
#pragma warning disable 0649
            public EventHandler<MarkerDragStartEventArgs> OnMarkerDragStartHandler;
#pragma warning restore 0649

            public void OnMarkerDragStart(global::Com.Amap.Api.Maps.Model.Marker p0)
            {
                var __h = OnMarkerDragStartHandler;
                if (__h != null)
                    __h(sender, new MarkerDragStartEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnMarkerDragListenerImplementor value)
            {
                return value.OnMarkerDragHandler == null && value.OnMarkerDragEndHandler == null && value.OnMarkerDragStartHandler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMultiPointClickListener']"
        [Register("com/amap/api/maps/AMap$OnMultiPointClickListener", "", "Com.Amap.Api.Maps.AMap/IOnMultiPointClickListenerInvoker")]
        public partial interface IOnMultiPointClickListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMultiPointClickListener']/method[@name='onPointClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.MultiPointItem']]"
            [Register("onPointClick", "(Lcom/amap/api/maps/model/MultiPointItem;)Z", "GetOnPointClick_Lcom_amap_api_maps_model_MultiPointItem_Handler:Com.Amap.Api.Maps.AMap/IOnMultiPointClickListenerInvoker, AutoNavMapBinding.Droid")]
            bool OnPointClick(global::Com.Amap.Api.Maps.Model.MultiPointItem p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnMultiPointClickListener", DoNotGenerateAcw = true)]
        internal class IOnMultiPointClickListenerInvoker : global::Java.Lang.Object, IOnMultiPointClickListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnMultiPointClickListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnMultiPointClickListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnMultiPointClickListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnMultiPointClickListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnMultiPointClickListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnMultiPointClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onPointClick_Lcom_amap_api_maps_model_MultiPointItem_;
#pragma warning disable 0169
            static Delegate GetOnPointClick_Lcom_amap_api_maps_model_MultiPointItem_Handler()
            {
                if (cb_onPointClick_Lcom_amap_api_maps_model_MultiPointItem_ == null)
                    cb_onPointClick_Lcom_amap_api_maps_model_MultiPointItem_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, bool>)n_OnPointClick_Lcom_amap_api_maps_model_MultiPointItem_);
                return cb_onPointClick_Lcom_amap_api_maps_model_MultiPointItem_;
            }

            static bool n_OnPointClick_Lcom_amap_api_maps_model_MultiPointItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMultiPointClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMultiPointClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.MultiPointItem p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.MultiPointItem>(native_p0, JniHandleOwnership.DoNotTransfer);
                bool __ret = __this.OnPointClick(p0);
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_onPointClick_Lcom_amap_api_maps_model_MultiPointItem_;
            public unsafe bool OnPointClick(global::Com.Amap.Api.Maps.Model.MultiPointItem p0)
            {
                if (id_onPointClick_Lcom_amap_api_maps_model_MultiPointItem_ == IntPtr.Zero)
                    id_onPointClick_Lcom_amap_api_maps_model_MultiPointItem_ = JNIEnv.GetMethodID(class_ref, "onPointClick", "(Lcom/amap/api/maps/model/MultiPointItem;)Z");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                bool __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_onPointClick_Lcom_amap_api_maps_model_MultiPointItem_, __args);
                return __ret;
            }

        }

        public partial class MultiPointClickEventArgs : global::System.EventArgs
        {

            public MultiPointClickEventArgs(bool handled, global::Com.Amap.Api.Maps.Model.MultiPointItem p0)
            {
                this.handled = handled;
                this.p0 = p0;
            }

            bool handled;
            public bool Handled
            {
                get { return handled; }
                set { handled = value; }
            }

            global::Com.Amap.Api.Maps.Model.MultiPointItem p0;
            public global::Com.Amap.Api.Maps.Model.MultiPointItem P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnMultiPointClickListenerImplementor")]
        internal sealed partial class IOnMultiPointClickListenerImplementor : global::Java.Lang.Object, IOnMultiPointClickListener
        {

            object sender;

            public IOnMultiPointClickListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnMultiPointClickListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<MultiPointClickEventArgs> Handler;
#pragma warning restore 0649

            public bool OnPointClick(global::Com.Amap.Api.Maps.Model.MultiPointItem p0)
            {
                var __h = Handler;
                if (__h == null)
                    return false;
                var __e = new MultiPointClickEventArgs(true, p0);
                __h(sender, __e);
                return __e.Handled;
            }

            internal static bool __IsEmpty(IOnMultiPointClickListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMyLocationChangeListener']"
        [Register("com/amap/api/maps/AMap$OnMyLocationChangeListener", "", "Com.Amap.Api.Maps.AMap/IOnMyLocationChangeListenerInvoker")]
        public partial interface IOnMyLocationChangeListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnMyLocationChangeListener']/method[@name='onMyLocationChange' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
            [Register("onMyLocationChange", "(Landroid/location/Location;)V", "GetOnMyLocationChange_Landroid_location_Location_Handler:Com.Amap.Api.Maps.AMap/IOnMyLocationChangeListenerInvoker, AutoNavMapBinding.Droid")]
            void OnMyLocationChange(global::Android.Locations.Location p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnMyLocationChangeListener", DoNotGenerateAcw = true)]
        internal class IOnMyLocationChangeListenerInvoker : global::Java.Lang.Object, IOnMyLocationChangeListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnMyLocationChangeListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnMyLocationChangeListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnMyLocationChangeListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnMyLocationChangeListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnMyLocationChangeListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnMyLocationChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onMyLocationChange_Landroid_location_Location_;
#pragma warning disable 0169
            static Delegate GetOnMyLocationChange_Landroid_location_Location_Handler()
            {
                if (cb_onMyLocationChange_Landroid_location_Location_ == null)
                    cb_onMyLocationChange_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMyLocationChange_Landroid_location_Location_);
                return cb_onMyLocationChange_Landroid_location_Location_;
            }

            static void n_OnMyLocationChange_Landroid_location_Location_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnMyLocationChange(p0);
            }
#pragma warning restore 0169

            IntPtr id_onMyLocationChange_Landroid_location_Location_;
            public unsafe void OnMyLocationChange(global::Android.Locations.Location p0)
            {
                if (id_onMyLocationChange_Landroid_location_Location_ == IntPtr.Zero)
                    id_onMyLocationChange_Landroid_location_Location_ = JNIEnv.GetMethodID(class_ref, "onMyLocationChange", "(Landroid/location/Location;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMyLocationChange_Landroid_location_Location_, __args);
            }

        }

        public partial class MyLocationChangeEventArgs : global::System.EventArgs
        {

            public MyLocationChangeEventArgs(global::Android.Locations.Location p0)
            {
                this.p0 = p0;
            }

            global::Android.Locations.Location p0;
            public global::Android.Locations.Location P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnMyLocationChangeListenerImplementor")]
        internal sealed partial class IOnMyLocationChangeListenerImplementor : global::Java.Lang.Object, IOnMyLocationChangeListener
        {

            object sender;

            public IOnMyLocationChangeListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnMyLocationChangeListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<MyLocationChangeEventArgs> Handler;
#pragma warning restore 0649

            public void OnMyLocationChange(global::Android.Locations.Location p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new MyLocationChangeEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnMyLocationChangeListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnPOIClickListener']"
        [Register("com/amap/api/maps/AMap$OnPOIClickListener", "", "Com.Amap.Api.Maps.AMap/IOnPOIClickListenerInvoker")]
        public partial interface IOnPOIClickListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnPOIClickListener']/method[@name='onPOIClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Poi']]"
            [Register("onPOIClick", "(Lcom/amap/api/maps/model/Poi;)V", "GetOnPOIClick_Lcom_amap_api_maps_model_Poi_Handler:Com.Amap.Api.Maps.AMap/IOnPOIClickListenerInvoker, AutoNavMapBinding.Droid")]
            void OnPOIClick(global::Com.Amap.Api.Maps.Model.Poi p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnPOIClickListener", DoNotGenerateAcw = true)]
        internal class IOnPOIClickListenerInvoker : global::Java.Lang.Object, IOnPOIClickListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnPOIClickListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnPOIClickListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnPOIClickListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnPOIClickListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnPOIClickListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnPOIClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onPOIClick_Lcom_amap_api_maps_model_Poi_;
#pragma warning disable 0169
            static Delegate GetOnPOIClick_Lcom_amap_api_maps_model_Poi_Handler()
            {
                if (cb_onPOIClick_Lcom_amap_api_maps_model_Poi_ == null)
                    cb_onPOIClick_Lcom_amap_api_maps_model_Poi_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnPOIClick_Lcom_amap_api_maps_model_Poi_);
                return cb_onPOIClick_Lcom_amap_api_maps_model_Poi_;
            }

            static void n_OnPOIClick_Lcom_amap_api_maps_model_Poi_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnPOIClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnPOIClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Poi p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Poi>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnPOIClick(p0);
            }
#pragma warning restore 0169

            IntPtr id_onPOIClick_Lcom_amap_api_maps_model_Poi_;
            public unsafe void OnPOIClick(global::Com.Amap.Api.Maps.Model.Poi p0)
            {
                if (id_onPOIClick_Lcom_amap_api_maps_model_Poi_ == IntPtr.Zero)
                    id_onPOIClick_Lcom_amap_api_maps_model_Poi_ = JNIEnv.GetMethodID(class_ref, "onPOIClick", "(Lcom/amap/api/maps/model/Poi;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onPOIClick_Lcom_amap_api_maps_model_Poi_, __args);
            }

        }

        public partial class POIClickEventArgs : global::System.EventArgs
        {

            public POIClickEventArgs(global::Com.Amap.Api.Maps.Model.Poi p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.Poi p0;
            public global::Com.Amap.Api.Maps.Model.Poi P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnPOIClickListenerImplementor")]
        internal sealed partial class IOnPOIClickListenerImplementor : global::Java.Lang.Object, IOnPOIClickListener
        {

            object sender;

            public IOnPOIClickListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnPOIClickListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<POIClickEventArgs> Handler;
#pragma warning restore 0649

            public void OnPOIClick(global::Com.Amap.Api.Maps.Model.Poi p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new POIClickEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnPOIClickListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnPolylineClickListener']"
        [Register("com/amap/api/maps/AMap$OnPolylineClickListener", "", "Com.Amap.Api.Maps.AMap/IOnPolylineClickListenerInvoker")]
        public partial interface IOnPolylineClickListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.OnPolylineClickListener']/method[@name='onPolylineClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.Polyline']]"
            [Register("onPolylineClick", "(Lcom/amap/api/maps/model/Polyline;)V", "GetOnPolylineClick_Lcom_amap_api_maps_model_Polyline_Handler:Com.Amap.Api.Maps.AMap/IOnPolylineClickListenerInvoker, AutoNavMapBinding.Droid")]
            void OnPolylineClick(global::Com.Amap.Api.Maps.Model.Polyline p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$OnPolylineClickListener", DoNotGenerateAcw = true)]
        internal class IOnPolylineClickListenerInvoker : global::Java.Lang.Object, IOnPolylineClickListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$OnPolylineClickListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnPolylineClickListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnPolylineClickListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnPolylineClickListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.OnPolylineClickListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnPolylineClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onPolylineClick_Lcom_amap_api_maps_model_Polyline_;
#pragma warning disable 0169
            static Delegate GetOnPolylineClick_Lcom_amap_api_maps_model_Polyline_Handler()
            {
                if (cb_onPolylineClick_Lcom_amap_api_maps_model_Polyline_ == null)
                    cb_onPolylineClick_Lcom_amap_api_maps_model_Polyline_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnPolylineClick_Lcom_amap_api_maps_model_Polyline_);
                return cb_onPolylineClick_Lcom_amap_api_maps_model_Polyline_;
            }

            static void n_OnPolylineClick_Lcom_amap_api_maps_model_Polyline_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnPolylineClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnPolylineClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Maps.Model.Polyline p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Polyline>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnPolylineClick(p0);
            }
#pragma warning restore 0169

            IntPtr id_onPolylineClick_Lcom_amap_api_maps_model_Polyline_;
            public unsafe void OnPolylineClick(global::Com.Amap.Api.Maps.Model.Polyline p0)
            {
                if (id_onPolylineClick_Lcom_amap_api_maps_model_Polyline_ == IntPtr.Zero)
                    id_onPolylineClick_Lcom_amap_api_maps_model_Polyline_ = JNIEnv.GetMethodID(class_ref, "onPolylineClick", "(Lcom/amap/api/maps/model/Polyline;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onPolylineClick_Lcom_amap_api_maps_model_Polyline_, __args);
            }

        }

        public partial class PolylineClickEventArgs : global::System.EventArgs
        {

            public PolylineClickEventArgs(global::Com.Amap.Api.Maps.Model.Polyline p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Maps.Model.Polyline p0;
            public global::Com.Amap.Api.Maps.Model.Polyline P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_OnPolylineClickListenerImplementor")]
        internal sealed partial class IOnPolylineClickListenerImplementor : global::Java.Lang.Object, IOnPolylineClickListener
        {

            object sender;

            public IOnPolylineClickListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_OnPolylineClickListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<PolylineClickEventArgs> Handler;
#pragma warning restore 0649

            public void OnPolylineClick(global::Com.Amap.Api.Maps.Model.Polyline p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new PolylineClickEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnPolylineClickListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.onMapPrintScreenListener']"
        [Register("com/amap/api/maps/AMap$onMapPrintScreenListener", "", "Com.Amap.Api.Maps.AMap/IOnMapPrintScreenListenerInvoker")]
        public partial interface IOnMapPrintScreenListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/interface[@name='AMap.onMapPrintScreenListener']/method[@name='onMapPrint' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
            [Register("onMapPrint", "(Landroid/graphics/drawable/Drawable;)V", "GetOnMapPrint_Landroid_graphics_drawable_Drawable_Handler:Com.Amap.Api.Maps.AMap/IOnMapPrintScreenListenerInvoker, AutoNavMapBinding.Droid")]
            void OnMapPrint(global::Android.Graphics.Drawables.Drawable p0);

        }

        [global::Android.Runtime.Register("com/amap/api/maps/AMap$onMapPrintScreenListener", DoNotGenerateAcw = true)]
        internal class IOnMapPrintScreenListenerInvoker : global::Java.Lang.Object, IOnMapPrintScreenListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/maps/AMap$onMapPrintScreenListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnMapPrintScreenListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnMapPrintScreenListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnMapPrintScreenListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.maps.AMap.onMapPrintScreenListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnMapPrintScreenListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onMapPrint_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
            static Delegate GetOnMapPrint_Landroid_graphics_drawable_Drawable_Handler()
            {
                if (cb_onMapPrint_Landroid_graphics_drawable_Drawable_ == null)
                    cb_onMapPrint_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMapPrint_Landroid_graphics_drawable_Drawable_);
                return cb_onMapPrint_Landroid_graphics_drawable_Drawable_;
            }

            static void n_OnMapPrint_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Maps.AMap.IOnMapPrintScreenListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.AMap.IOnMapPrintScreenListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnMapPrint(p0);
            }
#pragma warning restore 0169

            IntPtr id_onMapPrint_Landroid_graphics_drawable_Drawable_;
            public unsafe void OnMapPrint(global::Android.Graphics.Drawables.Drawable p0)
            {
                if (id_onMapPrint_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
                    id_onMapPrint_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(class_ref, "onMapPrint", "(Landroid/graphics/drawable/Drawable;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapPrint_Landroid_graphics_drawable_Drawable_, __args);
            }

        }

        public partial class MapPrintScreenEventArgs : global::System.EventArgs
        {

            public MapPrintScreenEventArgs(global::Android.Graphics.Drawables.Drawable p0)
            {
                this.p0 = p0;
            }

            global::Android.Graphics.Drawables.Drawable p0;
            public global::Android.Graphics.Drawables.Drawable P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/maps/AMap_onMapPrintScreenListenerImplementor")]
        internal sealed partial class IOnMapPrintScreenListenerImplementor : global::Java.Lang.Object, IOnMapPrintScreenListener
        {

            object sender;

            public IOnMapPrintScreenListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/maps/AMap_onMapPrintScreenListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<MapPrintScreenEventArgs> Handler;
#pragma warning restore 0649

            public void OnMapPrint(global::Android.Graphics.Drawables.Drawable p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new MapPrintScreenEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnMapPrintScreenListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        internal static new IntPtr java_class_handle;
        internal static new IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/amap/api/maps/AMap", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(AMap); }
        }

        internal AMap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_getCameraPosition;
        public unsafe global::Com.Amap.Api.Maps.Model.CameraPosition CameraPosition
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getCameraPosition' and count(parameter)=0]"
            [Register("getCameraPosition", "()Lcom/amap/api/maps/model/CameraPosition;", "GetGetCameraPositionHandler")]
            get
            {
                if (id_getCameraPosition == IntPtr.Zero)
                    id_getCameraPosition = JNIEnv.GetMethodID(class_ref, "getCameraPosition", "()Lcom/amap/api/maps/model/CameraPosition;");
                try
                {
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.CameraPosition>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getCameraPosition), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getInfoWindowAnimationManager;
        public unsafe global::Com.Amap.Api.Maps.InfoWindowAnimationManager InfoWindowAnimationManager
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getInfoWindowAnimationManager' and count(parameter)=0]"
            [Register("getInfoWindowAnimationManager", "()Lcom/amap/api/maps/InfoWindowAnimationManager;", "GetGetInfoWindowAnimationManagerHandler")]
            get
            {
                if (id_getInfoWindowAnimationManager == IntPtr.Zero)
                    id_getInfoWindowAnimationManager = JNIEnv.GetMethodID(class_ref, "getInfoWindowAnimationManager", "()Lcom/amap/api/maps/InfoWindowAnimationManager;");
                try
                {
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.InfoWindowAnimationManager>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getInfoWindowAnimationManager), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getMapContentApprovalNumber;
        public unsafe string MapContentApprovalNumber
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMapContentApprovalNumber' and count(parameter)=0]"
            [Register("getMapContentApprovalNumber", "()Ljava/lang/String;", "GetGetMapContentApprovalNumberHandler")]
            get
            {
                if (id_getMapContentApprovalNumber == IntPtr.Zero)
                    id_getMapContentApprovalNumber = JNIEnv.GetMethodID(class_ref, "getMapContentApprovalNumber", "()Ljava/lang/String;");
                try
                {
                    return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getMapContentApprovalNumber), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getMapScreenMarkers;
        public unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps.Model.Marker> MapScreenMarkers
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMapScreenMarkers' and count(parameter)=0]"
            [Register("getMapScreenMarkers", "()Ljava/util/List;", "GetGetMapScreenMarkersHandler")]
            get
            {
                if (id_getMapScreenMarkers == IntPtr.Zero)
                    id_getMapScreenMarkers = JNIEnv.GetMethodID(class_ref, "getMapScreenMarkers", "()Ljava/util/List;");
                try
                {
                    return global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps.Model.Marker>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getMapScreenMarkers), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getMapTextZIndex;
        static IntPtr id_setMapTextZIndex_I;
        public unsafe int MapTextZIndex
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMapTextZIndex' and count(parameter)=0]"
            [Register("getMapTextZIndex", "()I", "GetGetMapTextZIndexHandler")]
            get
            {
                if (id_getMapTextZIndex == IntPtr.Zero)
                    id_getMapTextZIndex = JNIEnv.GetMethodID(class_ref, "getMapTextZIndex", "()I");
                try
                {
                    return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_getMapTextZIndex);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMapTextZIndex' and count(parameter)=1 and parameter[1][@type='int']]"
            [Register("setMapTextZIndex", "(I)V", "GetSetMapTextZIndex_IHandler")]
            set
            {
                if (id_setMapTextZIndex_I == IntPtr.Zero)
                    id_setMapTextZIndex_I = JNIEnv.GetMethodID(class_ref, "setMapTextZIndex", "(I)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMapTextZIndex_I, __args);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getMapType;
        static IntPtr id_setMapType_I;
        public unsafe int MapType
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMapType' and count(parameter)=0]"
            [Register("getMapType", "()I", "GetGetMapTypeHandler")]
            get
            {
                if (id_getMapType == IntPtr.Zero)
                    id_getMapType = JNIEnv.GetMethodID(class_ref, "getMapType", "()I");
                try
                {
                    return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_getMapType);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMapType' and count(parameter)=1 and parameter[1][@type='int']]"
            [Register("setMapType", "(I)V", "GetSetMapType_IHandler")]
            set
            {
                if (id_setMapType_I == IntPtr.Zero)
                    id_setMapType_I = JNIEnv.GetMethodID(class_ref, "setMapType", "(I)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMapType_I, __args);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getMaxZoomLevel;
        static IntPtr id_setMaxZoomLevel_F;
        public unsafe float MaxZoomLevel
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
            [Register("getMaxZoomLevel", "()F", "GetGetMaxZoomLevelHandler")]
            get
            {
                if (id_getMaxZoomLevel == IntPtr.Zero)
                    id_getMaxZoomLevel = JNIEnv.GetMethodID(class_ref, "getMaxZoomLevel", "()F");
                try
                {
                    return JNIEnv.CallFloatMethod(((global::Java.Lang.Object)this).Handle, id_getMaxZoomLevel);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMaxZoomLevel' and count(parameter)=1 and parameter[1][@type='float']]"
            [Register("setMaxZoomLevel", "(F)V", "GetSetMaxZoomLevel_FHandler")]
            set
            {
                if (id_setMaxZoomLevel_F == IntPtr.Zero)
                    id_setMaxZoomLevel_F = JNIEnv.GetMethodID(class_ref, "setMaxZoomLevel", "(F)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMaxZoomLevel_F, __args);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getMinZoomLevel;
        static IntPtr id_setMinZoomLevel_F;
        public unsafe float MinZoomLevel
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMinZoomLevel' and count(parameter)=0]"
            [Register("getMinZoomLevel", "()F", "GetGetMinZoomLevelHandler")]
            get
            {
                if (id_getMinZoomLevel == IntPtr.Zero)
                    id_getMinZoomLevel = JNIEnv.GetMethodID(class_ref, "getMinZoomLevel", "()F");
                try
                {
                    return JNIEnv.CallFloatMethod(((global::Java.Lang.Object)this).Handle, id_getMinZoomLevel);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMinZoomLevel' and count(parameter)=1 and parameter[1][@type='float']]"
            [Register("setMinZoomLevel", "(F)V", "GetSetMinZoomLevel_FHandler")]
            set
            {
                if (id_setMinZoomLevel_F == IntPtr.Zero)
                    id_setMinZoomLevel_F = JNIEnv.GetMethodID(class_ref, "setMinZoomLevel", "(F)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMinZoomLevel_F, __args);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getMyLocation;
        public unsafe global::Android.Locations.Location MyLocation
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMyLocation' and count(parameter)=0]"
            [Register("getMyLocation", "()Landroid/location/Location;", "GetGetMyLocationHandler")]
            get
            {
                if (id_getMyLocation == IntPtr.Zero)
                    id_getMyLocation = JNIEnv.GetMethodID(class_ref, "getMyLocation", "()Landroid/location/Location;");
                try
                {
                    return global::Java.Lang.Object.GetObject<global::Android.Locations.Location>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getMyLocation), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_isMyLocationEnabled;
        static IntPtr id_setMyLocationEnabled_Z;
        public unsafe bool MyLocationEnabled
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='isMyLocationEnabled' and count(parameter)=0]"
            [Register("isMyLocationEnabled", "()Z", "GetIsMyLocationEnabledHandler")]
            get
            {
                if (id_isMyLocationEnabled == IntPtr.Zero)
                    id_isMyLocationEnabled = JNIEnv.GetMethodID(class_ref, "isMyLocationEnabled", "()Z");
                try
                {
                    return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isMyLocationEnabled);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMyLocationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
            [Register("setMyLocationEnabled", "(Z)V", "GetSetMyLocationEnabled_ZHandler")]
            set
            {
                if (id_setMyLocationEnabled_Z == IntPtr.Zero)
                    id_setMyLocationEnabled_Z = JNIEnv.GetMethodID(class_ref, "setMyLocationEnabled", "(Z)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMyLocationEnabled_Z, __args);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getMyLocationStyle;
        static IntPtr id_setMyLocationStyle_Lcom_amap_api_maps_model_MyLocationStyle_;
        public unsafe global::Com.Amap.Api.Maps.Model.MyLocationStyle MyLocationStyle
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMyLocationStyle' and count(parameter)=0]"
            [Register("getMyLocationStyle", "()Lcom/amap/api/maps/model/MyLocationStyle;", "GetGetMyLocationStyleHandler")]
            get
            {
                if (id_getMyLocationStyle == IntPtr.Zero)
                    id_getMyLocationStyle = JNIEnv.GetMethodID(class_ref, "getMyLocationStyle", "()Lcom/amap/api/maps/model/MyLocationStyle;");
                try
                {
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.MyLocationStyle>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getMyLocationStyle), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMyLocationStyle' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.MyLocationStyle']]"
            [Register("setMyLocationStyle", "(Lcom/amap/api/maps/model/MyLocationStyle;)V", "GetSetMyLocationStyle_Lcom_amap_api_maps_model_MyLocationStyle_Handler")]
            set
            {
                if (id_setMyLocationStyle_Lcom_amap_api_maps_model_MyLocationStyle_ == IntPtr.Zero)
                    id_setMyLocationStyle_Lcom_amap_api_maps_model_MyLocationStyle_ = JNIEnv.GetMethodID(class_ref, "setMyLocationStyle", "(Lcom/amap/api/maps/model/MyLocationStyle;)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMyLocationStyle_Lcom_amap_api_maps_model_MyLocationStyle_, __args);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getMyTrafficStyle;
        static IntPtr id_setMyTrafficStyle_Lcom_amap_api_maps_model_MyTrafficStyle_;
        public unsafe global::Com.Amap.Api.Maps.Model.MyTrafficStyle MyTrafficStyle
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMyTrafficStyle' and count(parameter)=0]"
            [Register("getMyTrafficStyle", "()Lcom/amap/api/maps/model/MyTrafficStyle;", "GetGetMyTrafficStyleHandler")]
            get
            {
                if (id_getMyTrafficStyle == IntPtr.Zero)
                    id_getMyTrafficStyle = JNIEnv.GetMethodID(class_ref, "getMyTrafficStyle", "()Lcom/amap/api/maps/model/MyTrafficStyle;");
                try
                {
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.MyTrafficStyle>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getMyTrafficStyle), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMyTrafficStyle' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.MyTrafficStyle']]"
            [Register("setMyTrafficStyle", "(Lcom/amap/api/maps/model/MyTrafficStyle;)V", "GetSetMyTrafficStyle_Lcom_amap_api_maps_model_MyTrafficStyle_Handler")]
            set
            {
                if (id_setMyTrafficStyle_Lcom_amap_api_maps_model_MyTrafficStyle_ == IntPtr.Zero)
                    id_setMyTrafficStyle_Lcom_amap_api_maps_model_MyTrafficStyle_ = JNIEnv.GetMethodID(class_ref, "setMyTrafficStyle", "(Lcom/amap/api/maps/model/MyTrafficStyle;)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMyTrafficStyle_Lcom_amap_api_maps_model_MyTrafficStyle_, __args);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getProjection;
        public unsafe global::Com.Amap.Api.Maps.Projection Projection
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getProjection' and count(parameter)=0]"
            [Register("getProjection", "()Lcom/amap/api/maps/Projection;", "GetGetProjectionHandler")]
            get
            {
                if (id_getProjection == IntPtr.Zero)
                    id_getProjection = JNIEnv.GetMethodID(class_ref, "getProjection", "()Lcom/amap/api/maps/Projection;");
                try
                {
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Projection>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getProjection), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getSatelliteImageApprovalNumber;
        public unsafe string SatelliteImageApprovalNumber
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getSatelliteImageApprovalNumber' and count(parameter)=0]"
            [Register("getSatelliteImageApprovalNumber", "()Ljava/lang/String;", "GetGetSatelliteImageApprovalNumberHandler")]
            get
            {
                if (id_getSatelliteImageApprovalNumber == IntPtr.Zero)
                    id_getSatelliteImageApprovalNumber = JNIEnv.GetMethodID(class_ref, "getSatelliteImageApprovalNumber", "()Ljava/lang/String;");
                try
                {
                    return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getSatelliteImageApprovalNumber), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getScalePerPixel;
        public unsafe float ScalePerPixel
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getScalePerPixel' and count(parameter)=0]"
            [Register("getScalePerPixel", "()F", "GetGetScalePerPixelHandler")]
            get
            {
                if (id_getScalePerPixel == IntPtr.Zero)
                    id_getScalePerPixel = JNIEnv.GetMethodID(class_ref, "getScalePerPixel", "()F");
                try
                {
                    return JNIEnv.CallFloatMethod(((global::Java.Lang.Object)this).Handle, id_getScalePerPixel);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_isTrafficEnabled;
        static IntPtr id_setTrafficEnabled_Z;
        public unsafe bool TrafficEnabled
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='isTrafficEnabled' and count(parameter)=0]"
            [Register("isTrafficEnabled", "()Z", "GetIsTrafficEnabledHandler")]
            get
            {
                if (id_isTrafficEnabled == IntPtr.Zero)
                    id_isTrafficEnabled = JNIEnv.GetMethodID(class_ref, "isTrafficEnabled", "()Z");
                try
                {
                    return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isTrafficEnabled);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setTrafficEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
            [Register("setTrafficEnabled", "(Z)V", "GetSetTrafficEnabled_ZHandler")]
            set
            {
                if (id_setTrafficEnabled_Z == IntPtr.Zero)
                    id_setTrafficEnabled_Z = JNIEnv.GetMethodID(class_ref, "setTrafficEnabled", "(Z)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setTrafficEnabled_Z, __args);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getUiSettings;
        public unsafe global::Com.Amap.Api.Maps.UiSettings UiSettings
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getUiSettings' and count(parameter)=0]"
            [Register("getUiSettings", "()Lcom/amap/api/maps/UiSettings;", "GetGetUiSettingsHandler")]
            get
            {
                if (id_getUiSettings == IntPtr.Zero)
                    id_getUiSettings = JNIEnv.GetMethodID(class_ref, "getUiSettings", "()Lcom/amap/api/maps/UiSettings;");
                try
                {
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.UiSettings>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getUiSettings), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getVersion;
        [Obsolete(@"deprecated")]
        public static unsafe string Version
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getVersion' and count(parameter)=0]"
            [Register("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
            get
            {
                if (id_getVersion == IntPtr.Zero)
                    id_getVersion = JNIEnv.GetStaticMethodID(class_ref, "getVersion", "()Ljava/lang/String;");
                try
                {
                    return JNIEnv.GetString(JNIEnv.CallStaticObjectMethod(class_ref, id_getVersion), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_addArc_Lcom_amap_api_maps_model_ArcOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addArc' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.ArcOptions']]"
        [Register("addArc", "(Lcom/amap/api/maps/model/ArcOptions;)Lcom/amap/api/maps/model/Arc;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.Arc AddArc(global::Com.Amap.Api.Maps.Model.ArcOptions p0)
        {
            if (id_addArc_Lcom_amap_api_maps_model_ArcOptions_ == IntPtr.Zero)
                id_addArc_Lcom_amap_api_maps_model_ArcOptions_ = JNIEnv.GetMethodID(class_ref, "addArc", "(Lcom/amap/api/maps/model/ArcOptions;)Lcom/amap/api/maps/model/Arc;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.Arc __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Arc>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addArc_Lcom_amap_api_maps_model_ArcOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_addCircle_Lcom_amap_api_maps_model_CircleOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addCircle' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.CircleOptions']]"
        [Register("addCircle", "(Lcom/amap/api/maps/model/CircleOptions;)Lcom/amap/api/maps/model/Circle;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.Circle AddCircle(global::Com.Amap.Api.Maps.Model.CircleOptions p0)
        {
            if (id_addCircle_Lcom_amap_api_maps_model_CircleOptions_ == IntPtr.Zero)
                id_addCircle_Lcom_amap_api_maps_model_CircleOptions_ = JNIEnv.GetMethodID(class_ref, "addCircle", "(Lcom/amap/api/maps/model/CircleOptions;)Lcom/amap/api/maps/model/Circle;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.Circle __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Circle>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addCircle_Lcom_amap_api_maps_model_CircleOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_addCrossOverlay_Lcom_amap_api_maps_model_CrossOverlayOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addCrossOverlay' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.CrossOverlayOptions']]"
        [Register("addCrossOverlay", "(Lcom/amap/api/maps/model/CrossOverlayOptions;)Lcom/amap/api/maps/model/CrossOverlay;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.CrossOverlay AddCrossOverlay(global::Com.Amap.Api.Maps.Model.CrossOverlayOptions p0)
        {
            if (id_addCrossOverlay_Lcom_amap_api_maps_model_CrossOverlayOptions_ == IntPtr.Zero)
                id_addCrossOverlay_Lcom_amap_api_maps_model_CrossOverlayOptions_ = JNIEnv.GetMethodID(class_ref, "addCrossOverlay", "(Lcom/amap/api/maps/model/CrossOverlayOptions;)Lcom/amap/api/maps/model/CrossOverlay;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.CrossOverlay __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.CrossOverlay>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addCrossOverlay_Lcom_amap_api_maps_model_CrossOverlayOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_addGroundOverlay_Lcom_amap_api_maps_model_GroundOverlayOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addGroundOverlay' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.GroundOverlayOptions']]"
        [Register("addGroundOverlay", "(Lcom/amap/api/maps/model/GroundOverlayOptions;)Lcom/amap/api/maps/model/GroundOverlay;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.GroundOverlay AddGroundOverlay(global::Com.Amap.Api.Maps.Model.GroundOverlayOptions p0)
        {
            if (id_addGroundOverlay_Lcom_amap_api_maps_model_GroundOverlayOptions_ == IntPtr.Zero)
                id_addGroundOverlay_Lcom_amap_api_maps_model_GroundOverlayOptions_ = JNIEnv.GetMethodID(class_ref, "addGroundOverlay", "(Lcom/amap/api/maps/model/GroundOverlayOptions;)Lcom/amap/api/maps/model/GroundOverlay;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.GroundOverlay __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.GroundOverlay>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addGroundOverlay_Lcom_amap_api_maps_model_GroundOverlayOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_addMarker_Lcom_amap_api_maps_model_MarkerOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.MarkerOptions']]"
        [Register("addMarker", "(Lcom/amap/api/maps/model/MarkerOptions;)Lcom/amap/api/maps/model/Marker;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.Marker AddMarker(global::Com.Amap.Api.Maps.Model.MarkerOptions p0)
        {
            if (id_addMarker_Lcom_amap_api_maps_model_MarkerOptions_ == IntPtr.Zero)
                id_addMarker_Lcom_amap_api_maps_model_MarkerOptions_ = JNIEnv.GetMethodID(class_ref, "addMarker", "(Lcom/amap/api/maps/model/MarkerOptions;)Lcom/amap/api/maps/model/Marker;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.Marker __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Marker>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addMarker_Lcom_amap_api_maps_model_MarkerOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_addMarkers_Ljava_util_ArrayList_Z;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addMarkers' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;com.amap.api.maps.model.MarkerOptions&gt;'] and parameter[2][@type='boolean']]"
        [Register("addMarkers", "(Ljava/util/ArrayList;Z)Ljava/util/ArrayList;", "")]
        public unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps.Model.Marker> AddMarkers(global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps.Model.MarkerOptions> p0, bool p1)
        {
            if (id_addMarkers_Ljava_util_ArrayList_Z == IntPtr.Zero)
                id_addMarkers_Ljava_util_ArrayList_Z = JNIEnv.GetMethodID(class_ref, "addMarkers", "(Ljava/util/ArrayList;Z)Ljava/util/ArrayList;");
            IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps.Model.MarkerOptions>.ToLocalJniHandle(p0);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(native_p0);
                __args[1] = new JValue(p1);
                global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps.Model.Marker> __ret = global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps.Model.Marker>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addMarkers_Ljava_util_ArrayList_Z, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
            }
        }

        static IntPtr id_addMultiPointOverlay_Lcom_amap_api_maps_model_MultiPointOverlayOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addMultiPointOverlay' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.MultiPointOverlayOptions']]"
        [Register("addMultiPointOverlay", "(Lcom/amap/api/maps/model/MultiPointOverlayOptions;)Lcom/amap/api/maps/model/MultiPointOverlay;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.MultiPointOverlay AddMultiPointOverlay(global::Com.Amap.Api.Maps.Model.MultiPointOverlayOptions p0)
        {
            if (id_addMultiPointOverlay_Lcom_amap_api_maps_model_MultiPointOverlayOptions_ == IntPtr.Zero)
                id_addMultiPointOverlay_Lcom_amap_api_maps_model_MultiPointOverlayOptions_ = JNIEnv.GetMethodID(class_ref, "addMultiPointOverlay", "(Lcom/amap/api/maps/model/MultiPointOverlayOptions;)Lcom/amap/api/maps/model/MultiPointOverlay;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.MultiPointOverlay __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.MultiPointOverlay>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addMultiPointOverlay_Lcom_amap_api_maps_model_MultiPointOverlayOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_addNavigateArrow_Lcom_amap_api_maps_model_NavigateArrowOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addNavigateArrow' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.NavigateArrowOptions']]"
        [Register("addNavigateArrow", "(Lcom/amap/api/maps/model/NavigateArrowOptions;)Lcom/amap/api/maps/model/NavigateArrow;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.NavigateArrow AddNavigateArrow(global::Com.Amap.Api.Maps.Model.NavigateArrowOptions p0)
        {
            if (id_addNavigateArrow_Lcom_amap_api_maps_model_NavigateArrowOptions_ == IntPtr.Zero)
                id_addNavigateArrow_Lcom_amap_api_maps_model_NavigateArrowOptions_ = JNIEnv.GetMethodID(class_ref, "addNavigateArrow", "(Lcom/amap/api/maps/model/NavigateArrowOptions;)Lcom/amap/api/maps/model/NavigateArrow;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.NavigateArrow __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.NavigateArrow>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addNavigateArrow_Lcom_amap_api_maps_model_NavigateArrowOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_addPolygon_Lcom_amap_api_maps_model_PolygonOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addPolygon' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.PolygonOptions']]"
        [Register("addPolygon", "(Lcom/amap/api/maps/model/PolygonOptions;)Lcom/amap/api/maps/model/Polygon;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.Polygon AddPolygon(global::Com.Amap.Api.Maps.Model.PolygonOptions p0)
        {
            if (id_addPolygon_Lcom_amap_api_maps_model_PolygonOptions_ == IntPtr.Zero)
                id_addPolygon_Lcom_amap_api_maps_model_PolygonOptions_ = JNIEnv.GetMethodID(class_ref, "addPolygon", "(Lcom/amap/api/maps/model/PolygonOptions;)Lcom/amap/api/maps/model/Polygon;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.Polygon __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Polygon>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addPolygon_Lcom_amap_api_maps_model_PolygonOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_addPolyline_Lcom_amap_api_maps_model_PolylineOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addPolyline' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.PolylineOptions']]"
        [Register("addPolyline", "(Lcom/amap/api/maps/model/PolylineOptions;)Lcom/amap/api/maps/model/Polyline;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.Polyline AddPolyline(global::Com.Amap.Api.Maps.Model.PolylineOptions p0)
        {
            if (id_addPolyline_Lcom_amap_api_maps_model_PolylineOptions_ == IntPtr.Zero)
                id_addPolyline_Lcom_amap_api_maps_model_PolylineOptions_ = JNIEnv.GetMethodID(class_ref, "addPolyline", "(Lcom/amap/api/maps/model/PolylineOptions;)Lcom/amap/api/maps/model/Polyline;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.Polyline __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Polyline>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addPolyline_Lcom_amap_api_maps_model_PolylineOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_addRouteOverlay;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addRouteOverlay' and count(parameter)=0]"
        [Register("addRouteOverlay", "()Lcom/amap/api/maps/model/RouteOverlay;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.RouteOverlay AddRouteOverlay()
        {
            if (id_addRouteOverlay == IntPtr.Zero)
                id_addRouteOverlay = JNIEnv.GetMethodID(class_ref, "addRouteOverlay", "()Lcom/amap/api/maps/model/RouteOverlay;");
            try
            {
                return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.RouteOverlay>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addRouteOverlay), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static IntPtr id_addText_Lcom_amap_api_maps_model_TextOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addText' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.TextOptions']]"
        [Register("addText", "(Lcom/amap/api/maps/model/TextOptions;)Lcom/amap/api/maps/model/Text;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.Text AddText(global::Com.Amap.Api.Maps.Model.TextOptions p0)
        {
            if (id_addText_Lcom_amap_api_maps_model_TextOptions_ == IntPtr.Zero)
                id_addText_Lcom_amap_api_maps_model_TextOptions_ = JNIEnv.GetMethodID(class_ref, "addText", "(Lcom/amap/api/maps/model/TextOptions;)Lcom/amap/api/maps/model/Text;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.Text __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.Text>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addText_Lcom_amap_api_maps_model_TextOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_addTileOverlay_Lcom_amap_api_maps_model_TileOverlayOptions_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='addTileOverlay' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.TileOverlayOptions']]"
        [Register("addTileOverlay", "(Lcom/amap/api/maps/model/TileOverlayOptions;)Lcom/amap/api/maps/model/TileOverlay;", "")]
        public unsafe global::Com.Amap.Api.Maps.Model.TileOverlay AddTileOverlay(global::Com.Amap.Api.Maps.Model.TileOverlayOptions p0)
        {
            if (id_addTileOverlay_Lcom_amap_api_maps_model_TileOverlayOptions_ == IntPtr.Zero)
                id_addTileOverlay_Lcom_amap_api_maps_model_TileOverlayOptions_ = JNIEnv.GetMethodID(class_ref, "addTileOverlay", "(Lcom/amap/api/maps/model/TileOverlayOptions;)Lcom/amap/api/maps/model/TileOverlay;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                global::Com.Amap.Api.Maps.Model.TileOverlay __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps.Model.TileOverlay>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addTileOverlay_Lcom_amap_api_maps_model_TileOverlayOptions_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_animateCamera_Lcom_amap_api_maps_CameraUpdate_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='animateCamera' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.CameraUpdate']]"
        [Register("animateCamera", "(Lcom/amap/api/maps/CameraUpdate;)V", "")]
        public unsafe void AnimateCamera(global::Com.Amap.Api.Maps.CameraUpdate p0)
        {
            if (id_animateCamera_Lcom_amap_api_maps_CameraUpdate_ == IntPtr.Zero)
                id_animateCamera_Lcom_amap_api_maps_CameraUpdate_ = JNIEnv.GetMethodID(class_ref, "animateCamera", "(Lcom/amap/api/maps/CameraUpdate;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_animateCamera_Lcom_amap_api_maps_CameraUpdate_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_animateCamera_Lcom_amap_api_maps_CameraUpdate_Lcom_amap_api_maps_AMap_CancelableCallback_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='animateCamera' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps.CameraUpdate'] and parameter[2][@type='com.amap.api.maps.AMap.CancelableCallback']]"
        [Register("animateCamera", "(Lcom/amap/api/maps/CameraUpdate;Lcom/amap/api/maps/AMap$CancelableCallback;)V", "")]
        public unsafe void AnimateCamera(global::Com.Amap.Api.Maps.CameraUpdate p0, global::Com.Amap.Api.Maps.AMap.ICancelableCallback p1)
        {
            if (id_animateCamera_Lcom_amap_api_maps_CameraUpdate_Lcom_amap_api_maps_AMap_CancelableCallback_ == IntPtr.Zero)
                id_animateCamera_Lcom_amap_api_maps_CameraUpdate_Lcom_amap_api_maps_AMap_CancelableCallback_ = JNIEnv.GetMethodID(class_ref, "animateCamera", "(Lcom/amap/api/maps/CameraUpdate;Lcom/amap/api/maps/AMap$CancelableCallback;)V");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_animateCamera_Lcom_amap_api_maps_CameraUpdate_Lcom_amap_api_maps_AMap_CancelableCallback_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_animateCamera_Lcom_amap_api_maps_CameraUpdate_JLcom_amap_api_maps_AMap_CancelableCallback_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='animateCamera' and count(parameter)=3 and parameter[1][@type='com.amap.api.maps.CameraUpdate'] and parameter[2][@type='long'] and parameter[3][@type='com.amap.api.maps.AMap.CancelableCallback']]"
        [Register("animateCamera", "(Lcom/amap/api/maps/CameraUpdate;JLcom/amap/api/maps/AMap$CancelableCallback;)V", "")]
        public unsafe void AnimateCamera(global::Com.Amap.Api.Maps.CameraUpdate p0, long p1, global::Com.Amap.Api.Maps.AMap.ICancelableCallback p2)
        {
            if (id_animateCamera_Lcom_amap_api_maps_CameraUpdate_JLcom_amap_api_maps_AMap_CancelableCallback_ == IntPtr.Zero)
                id_animateCamera_Lcom_amap_api_maps_CameraUpdate_JLcom_amap_api_maps_AMap_CancelableCallback_ = JNIEnv.GetMethodID(class_ref, "animateCamera", "(Lcom/amap/api/maps/CameraUpdate;JLcom/amap/api/maps/AMap$CancelableCallback;)V");
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(p2);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_animateCamera_Lcom_amap_api_maps_CameraUpdate_JLcom_amap_api_maps_AMap_CancelableCallback_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_calculateZoomToSpanLevel_IIIILcom_amap_api_maps_model_LatLng_Lcom_amap_api_maps_model_LatLng_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='calculateZoomToSpanLevel' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.amap.api.maps.model.LatLng'] and parameter[6][@type='com.amap.api.maps.model.LatLng']]"
        [Register("calculateZoomToSpanLevel", "(IIIILcom/amap/api/maps/model/LatLng;Lcom/amap/api/maps/model/LatLng;)Landroid/util/Pair;", "")]
        public unsafe global::Android.Util.Pair CalculateZoomToSpanLevel(int p0, int p1, int p2, int p3, global::Com.Amap.Api.Maps.Model.LatLng p4, global::Com.Amap.Api.Maps.Model.LatLng p5)
        {
            if (id_calculateZoomToSpanLevel_IIIILcom_amap_api_maps_model_LatLng_Lcom_amap_api_maps_model_LatLng_ == IntPtr.Zero)
                id_calculateZoomToSpanLevel_IIIILcom_amap_api_maps_model_LatLng_Lcom_amap_api_maps_model_LatLng_ = JNIEnv.GetMethodID(class_ref, "calculateZoomToSpanLevel", "(IIIILcom/amap/api/maps/model/LatLng;Lcom/amap/api/maps/model/LatLng;)Landroid/util/Pair;");
            try
            {
                JValue* __args = stackalloc JValue[6];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(p2);
                __args[3] = new JValue(p3);
                __args[4] = new JValue(p4);
                __args[5] = new JValue(p5);
                global::Android.Util.Pair __ret = global::Java.Lang.Object.GetObject<global::Android.Util.Pair>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_calculateZoomToSpanLevel_IIIILcom_amap_api_maps_model_LatLng_Lcom_amap_api_maps_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_clear;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='clear' and count(parameter)=0]"
        [Register("clear", "()V", "")]
        public unsafe void Clear()
        {
            if (id_clear == IntPtr.Zero)
                id_clear = JNIEnv.GetMethodID(class_ref, "clear", "()V");
            try
            {
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_clear);
            }
            finally
            {
            }
        }

        static IntPtr id_clear_Z;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("clear", "(Z)V", "")]
        public unsafe void Clear(bool p0)
        {
            if (id_clear_Z == IntPtr.Zero)
                id_clear_Z = JNIEnv.GetMethodID(class_ref, "clear", "(Z)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_clear_Z, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getMapPrintScreen_Lcom_amap_api_maps_AMap_onMapPrintScreenListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMapPrintScreen' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.onMapPrintScreenListener']]"
        [Register("getMapPrintScreen", "(Lcom/amap/api/maps/AMap$onMapPrintScreenListener;)V", "")]
        public unsafe void GetMapPrintScreen(global::Com.Amap.Api.Maps.AMap.IOnMapPrintScreenListener p0)
        {
            if (id_getMapPrintScreen_Lcom_amap_api_maps_AMap_onMapPrintScreenListener_ == IntPtr.Zero)
                id_getMapPrintScreen_Lcom_amap_api_maps_AMap_onMapPrintScreenListener_ = JNIEnv.GetMethodID(class_ref, "getMapPrintScreen", "(Lcom/amap/api/maps/AMap$onMapPrintScreenListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_getMapPrintScreen_Lcom_amap_api_maps_AMap_onMapPrintScreenListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getMapScreenShot_Lcom_amap_api_maps_AMap_OnMapScreenShotListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getMapScreenShot' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnMapScreenShotListener']]"
        [Register("getMapScreenShot", "(Lcom/amap/api/maps/AMap$OnMapScreenShotListener;)V", "")]
        public unsafe void GetMapScreenShot(global::Com.Amap.Api.Maps.AMap.IOnMapScreenShotListener p0)
        {
            if (id_getMapScreenShot_Lcom_amap_api_maps_AMap_OnMapScreenShotListener_ == IntPtr.Zero)
                id_getMapScreenShot_Lcom_amap_api_maps_AMap_OnMapScreenShotListener_ = JNIEnv.GetMethodID(class_ref, "getMapScreenShot", "(Lcom/amap/api/maps/AMap$OnMapScreenShotListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_getMapScreenShot_Lcom_amap_api_maps_AMap_OnMapScreenShotListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getP20MapCenter_Lcom_autonavi_amap_mapcore_IPoint_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getP20MapCenter' and count(parameter)=1 and parameter[1][@type='com.autonavi.amap.mapcore.IPoint']]"
        [Register("getP20MapCenter", "(Lcom/autonavi/amap/mapcore/IPoint;)V", "")]
        public unsafe void GetP20MapCenter(global::Com.Autonavi.Amap.Mapcore.IPoint p0)
        {
            if (id_getP20MapCenter_Lcom_autonavi_amap_mapcore_IPoint_ == IntPtr.Zero)
                id_getP20MapCenter_Lcom_autonavi_amap_mapcore_IPoint_ = JNIEnv.GetMethodID(class_ref, "getP20MapCenter", "(Lcom/autonavi/amap/mapcore/IPoint;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_getP20MapCenter_Lcom_autonavi_amap_mapcore_IPoint_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getProjectionMatrix;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getProjectionMatrix' and count(parameter)=0]"
        [Register("getProjectionMatrix", "()[F", "")]
        public unsafe float[] GetProjectionMatrix()
        {
            if (id_getProjectionMatrix == IntPtr.Zero)
                id_getProjectionMatrix = JNIEnv.GetMethodID(class_ref, "getProjectionMatrix", "()[F");
            try
            {
                return (float[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getProjectionMatrix), JniHandleOwnership.TransferLocalRef, typeof(float));
            }
            finally
            {
            }
        }

        static IntPtr id_getViewMatrix;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getViewMatrix' and count(parameter)=0]"
        [Register("getViewMatrix", "()[F", "")]
        public unsafe float[] GetViewMatrix()
        {
            if (id_getViewMatrix == IntPtr.Zero)
                id_getViewMatrix = JNIEnv.GetMethodID(class_ref, "getViewMatrix", "()[F");
            try
            {
                return (float[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getViewMatrix), JniHandleOwnership.TransferLocalRef, typeof(float));
            }
            finally
            {
            }
        }

        static IntPtr id_getZoomToSpanLevel_Lcom_amap_api_maps_model_LatLng_Lcom_amap_api_maps_model_LatLng_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='getZoomToSpanLevel' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps.model.LatLng'] and parameter[2][@type='com.amap.api.maps.model.LatLng']]"
        [Register("getZoomToSpanLevel", "(Lcom/amap/api/maps/model/LatLng;Lcom/amap/api/maps/model/LatLng;)F", "")]
        public unsafe float GetZoomToSpanLevel(global::Com.Amap.Api.Maps.Model.LatLng p0, global::Com.Amap.Api.Maps.Model.LatLng p1)
        {
            if (id_getZoomToSpanLevel_Lcom_amap_api_maps_model_LatLng_Lcom_amap_api_maps_model_LatLng_ == IntPtr.Zero)
                id_getZoomToSpanLevel_Lcom_amap_api_maps_model_LatLng_Lcom_amap_api_maps_model_LatLng_ = JNIEnv.GetMethodID(class_ref, "getZoomToSpanLevel", "(Lcom/amap/api/maps/model/LatLng;Lcom/amap/api/maps/model/LatLng;)F");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                float __ret = JNIEnv.CallFloatMethod(((global::Java.Lang.Object)this).Handle, id_getZoomToSpanLevel_Lcom_amap_api_maps_model_LatLng_Lcom_amap_api_maps_model_LatLng_, __args);
                return __ret;
            }
            finally
            {
            }
        }

        static IntPtr id_moveCamera_Lcom_amap_api_maps_CameraUpdate_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='moveCamera' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.CameraUpdate']]"
        [Register("moveCamera", "(Lcom/amap/api/maps/CameraUpdate;)V", "")]
        public unsafe void MoveCamera(global::Com.Amap.Api.Maps.CameraUpdate p0)
        {
            if (id_moveCamera_Lcom_amap_api_maps_CameraUpdate_ == IntPtr.Zero)
                id_moveCamera_Lcom_amap_api_maps_CameraUpdate_ = JNIEnv.GetMethodID(class_ref, "moveCamera", "(Lcom/amap/api/maps/CameraUpdate;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_moveCamera_Lcom_amap_api_maps_CameraUpdate_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_reloadMap;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='reloadMap' and count(parameter)=0]"
        [Register("reloadMap", "()V", "")]
        public unsafe void ReloadMap()
        {
            if (id_reloadMap == IntPtr.Zero)
                id_reloadMap = JNIEnv.GetMethodID(class_ref, "reloadMap", "()V");
            try
            {
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_reloadMap);
            }
            finally
            {
            }
        }

        static IntPtr id_removecache;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='removecache' and count(parameter)=0]"
        [Register("removecache", "()V", "")]
        public unsafe void Removecache()
        {
            if (id_removecache == IntPtr.Zero)
                id_removecache = JNIEnv.GetMethodID(class_ref, "removecache", "()V");
            try
            {
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_removecache);
            }
            finally
            {
            }
        }

        static IntPtr id_removecache_Lcom_amap_api_maps_AMap_OnCacheRemoveListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='removecache' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnCacheRemoveListener']]"
        [Register("removecache", "(Lcom/amap/api/maps/AMap$OnCacheRemoveListener;)V", "")]
        public unsafe void Removecache(global::Com.Amap.Api.Maps.AMap.IOnCacheRemoveListener p0)
        {
            if (id_removecache_Lcom_amap_api_maps_AMap_OnCacheRemoveListener_ == IntPtr.Zero)
                id_removecache_Lcom_amap_api_maps_AMap_OnCacheRemoveListener_ = JNIEnv.GetMethodID(class_ref, "removecache", "(Lcom/amap/api/maps/AMap$OnCacheRemoveListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_removecache_Lcom_amap_api_maps_AMap_OnCacheRemoveListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_resetMinMaxZoomPreference;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='resetMinMaxZoomPreference' and count(parameter)=0]"
        [Register("resetMinMaxZoomPreference", "()V", "")]
        public unsafe void ResetMinMaxZoomPreference()
        {
            if (id_resetMinMaxZoomPreference == IntPtr.Zero)
                id_resetMinMaxZoomPreference = JNIEnv.GetMethodID(class_ref, "resetMinMaxZoomPreference", "()V");
            try
            {
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_resetMinMaxZoomPreference);
            }
            finally
            {
            }
        }

        static IntPtr id_runOnDrawFrame;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='runOnDrawFrame' and count(parameter)=0]"
        [Register("runOnDrawFrame", "()V", "")]
        public unsafe void RunOnDrawFrame()
        {
            if (id_runOnDrawFrame == IntPtr.Zero)
                id_runOnDrawFrame = JNIEnv.GetMethodID(class_ref, "runOnDrawFrame", "()V");
            try
            {
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_runOnDrawFrame);
            }
            finally
            {
            }
        }

        static IntPtr id_setAMapGestureListener_Lcom_amap_api_maps_model_AMapGestureListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setAMapGestureListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.AMapGestureListener']]"
        [Register("setAMapGestureListener", "(Lcom/amap/api/maps/model/AMapGestureListener;)V", "")]
        public unsafe void SetAMapGestureListener(global::Com.Amap.Api.Maps.Model.IAMapGestureListener p0)
        {
            if (id_setAMapGestureListener_Lcom_amap_api_maps_model_AMapGestureListener_ == IntPtr.Zero)
                id_setAMapGestureListener_Lcom_amap_api_maps_model_AMapGestureListener_ = JNIEnv.GetMethodID(class_ref, "setAMapGestureListener", "(Lcom/amap/api/maps/model/AMapGestureListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setAMapGestureListener_Lcom_amap_api_maps_model_AMapGestureListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setCustomMapStylePath_Ljava_lang_String_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setCustomMapStylePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
        [Register("setCustomMapStylePath", "(Ljava/lang/String;)V", "")]
        public unsafe void SetCustomMapStylePath(string p0)
        {
            if (id_setCustomMapStylePath_Ljava_lang_String_ == IntPtr.Zero)
                id_setCustomMapStylePath_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "setCustomMapStylePath", "(Ljava/lang/String;)V");
            IntPtr native_p0 = JNIEnv.NewString(p0);
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(native_p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setCustomMapStylePath_Ljava_lang_String_, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
            }
        }

        static IntPtr id_setCustomRenderer_Lcom_amap_api_maps_CustomRenderer_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setCustomRenderer' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.CustomRenderer']]"
        [Register("setCustomRenderer", "(Lcom/amap/api/maps/CustomRenderer;)V", "")]
        public unsafe void SetCustomRenderer(global::Com.Amap.Api.Maps.ICustomRenderer p0)
        {
            if (id_setCustomRenderer_Lcom_amap_api_maps_CustomRenderer_ == IntPtr.Zero)
                id_setCustomRenderer_Lcom_amap_api_maps_CustomRenderer_ = JNIEnv.GetMethodID(class_ref, "setCustomRenderer", "(Lcom/amap/api/maps/CustomRenderer;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setCustomRenderer_Lcom_amap_api_maps_CustomRenderer_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setCustomTextureResourcePath_Ljava_lang_String_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setCustomTextureResourcePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
        [Register("setCustomTextureResourcePath", "(Ljava/lang/String;)V", "")]
        public unsafe void SetCustomTextureResourcePath(string p0)
        {
            if (id_setCustomTextureResourcePath_Ljava_lang_String_ == IntPtr.Zero)
                id_setCustomTextureResourcePath_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "setCustomTextureResourcePath", "(Ljava/lang/String;)V");
            IntPtr native_p0 = JNIEnv.NewString(p0);
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(native_p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setCustomTextureResourcePath_Ljava_lang_String_, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
            }
        }

        static IntPtr id_setIndoorBuildingInfo_Lcom_amap_api_maps_model_IndoorBuildingInfo_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setIndoorBuildingInfo' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.IndoorBuildingInfo']]"
        [Register("setIndoorBuildingInfo", "(Lcom/amap/api/maps/model/IndoorBuildingInfo;)V", "")]
        public unsafe void SetIndoorBuildingInfo(global::Com.Amap.Api.Maps.Model.IndoorBuildingInfo p0)
        {
            if (id_setIndoorBuildingInfo_Lcom_amap_api_maps_model_IndoorBuildingInfo_ == IntPtr.Zero)
                id_setIndoorBuildingInfo_Lcom_amap_api_maps_model_IndoorBuildingInfo_ = JNIEnv.GetMethodID(class_ref, "setIndoorBuildingInfo", "(Lcom/amap/api/maps/model/IndoorBuildingInfo;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setIndoorBuildingInfo_Lcom_amap_api_maps_model_IndoorBuildingInfo_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setInfoWindowAdapter_Lcom_amap_api_maps_AMap_InfoWindowAdapter_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setInfoWindowAdapter' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.InfoWindowAdapter']]"
        [Register("setInfoWindowAdapter", "(Lcom/amap/api/maps/AMap$InfoWindowAdapter;)V", "")]
        public unsafe void SetInfoWindowAdapter(global::Com.Amap.Api.Maps.AMap.IInfoWindowAdapter p0)
        {
            if (id_setInfoWindowAdapter_Lcom_amap_api_maps_AMap_InfoWindowAdapter_ == IntPtr.Zero)
                id_setInfoWindowAdapter_Lcom_amap_api_maps_AMap_InfoWindowAdapter_ = JNIEnv.GetMethodID(class_ref, "setInfoWindowAdapter", "(Lcom/amap/api/maps/AMap$InfoWindowAdapter;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setInfoWindowAdapter_Lcom_amap_api_maps_AMap_InfoWindowAdapter_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setLoadOfflineData_Z;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setLoadOfflineData' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setLoadOfflineData", "(Z)V", "")]
        public unsafe void SetLoadOfflineData(bool p0)
        {
            if (id_setLoadOfflineData_Z == IntPtr.Zero)
                id_setLoadOfflineData_Z = JNIEnv.GetMethodID(class_ref, "setLoadOfflineData", "(Z)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setLoadOfflineData_Z, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setLocationSource_Lcom_amap_api_maps_LocationSource_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setLocationSource' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.LocationSource']]"
        [Register("setLocationSource", "(Lcom/amap/api/maps/LocationSource;)V", "")]
        public unsafe void SetLocationSource(global::Com.Amap.Api.Maps.ILocationSource p0)
        {
            if (id_setLocationSource_Lcom_amap_api_maps_LocationSource_ == IntPtr.Zero)
                id_setLocationSource_Lcom_amap_api_maps_LocationSource_ = JNIEnv.GetMethodID(class_ref, "setLocationSource", "(Lcom/amap/api/maps/LocationSource;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setLocationSource_Lcom_amap_api_maps_LocationSource_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setMapCustomEnable_Z;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMapCustomEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("setMapCustomEnable", "(Z)V", "")]
        public unsafe void SetMapCustomEnable(bool p0)
        {
            if (id_setMapCustomEnable_Z == IntPtr.Zero)
                id_setMapCustomEnable_Z = JNIEnv.GetMethodID(class_ref, "setMapCustomEnable", "(Z)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMapCustomEnable_Z, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setMapLanguage_Ljava_lang_String_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMapLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
        [Register("setMapLanguage", "(Ljava/lang/String;)V", "")]
        public unsafe void SetMapLanguage(string p0)
        {
            if (id_setMapLanguage_Ljava_lang_String_ == IntPtr.Zero)
                id_setMapLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "setMapLanguage", "(Ljava/lang/String;)V");
            IntPtr native_p0 = JNIEnv.NewString(p0);
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(native_p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMapLanguage_Ljava_lang_String_, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
            }
        }

        static IntPtr id_setMapStatusLimits_Lcom_amap_api_maps_model_LatLngBounds_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMapStatusLimits' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.model.LatLngBounds']]"
        [Register("setMapStatusLimits", "(Lcom/amap/api/maps/model/LatLngBounds;)V", "")]
        public unsafe void SetMapStatusLimits(global::Com.Amap.Api.Maps.Model.LatLngBounds p0)
        {
            if (id_setMapStatusLimits_Lcom_amap_api_maps_model_LatLngBounds_ == IntPtr.Zero)
                id_setMapStatusLimits_Lcom_amap_api_maps_model_LatLngBounds_ = JNIEnv.GetMethodID(class_ref, "setMapStatusLimits", "(Lcom/amap/api/maps/model/LatLngBounds;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMapStatusLimits_Lcom_amap_api_maps_model_LatLngBounds_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setMaskLayerParams_IIIIIJ;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMaskLayerParams' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='long']]"
        [Register("setMaskLayerParams", "(IIIIIJ)V", "")]
        public unsafe void SetMaskLayerParams(int p0, int p1, int p2, int p3, int p4, long p5)
        {
            if (id_setMaskLayerParams_IIIIIJ == IntPtr.Zero)
                id_setMaskLayerParams_IIIIIJ = JNIEnv.GetMethodID(class_ref, "setMaskLayerParams", "(IIIIIJ)V");
            try
            {
                JValue* __args = stackalloc JValue[6];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(p2);
                __args[3] = new JValue(p3);
                __args[4] = new JValue(p4);
                __args[5] = new JValue(p5);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMaskLayerParams_IIIIIJ, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setMyLocationRotateAngle_F;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMyLocationRotateAngle' and count(parameter)=1 and parameter[1][@type='float']]"
        [Register("setMyLocationRotateAngle", "(F)V", "")]
        public unsafe void SetMyLocationRotateAngle(float p0)
        {
            if (id_setMyLocationRotateAngle_F == IntPtr.Zero)
                id_setMyLocationRotateAngle_F = JNIEnv.GetMethodID(class_ref, "setMyLocationRotateAngle", "(F)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMyLocationRotateAngle_F, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setMyLocationType_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setMyLocationType' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("setMyLocationType", "(I)V", "")]
        public unsafe void SetMyLocationType(int p0)
        {
            if (id_setMyLocationType_I == IntPtr.Zero)
                id_setMyLocationType_I = JNIEnv.GetMethodID(class_ref, "setMyLocationType", "(I)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setMyLocationType_I, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnCameraChangeListener_Lcom_amap_api_maps_AMap_OnCameraChangeListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnCameraChangeListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnCameraChangeListener']]"
        [Register("setOnCameraChangeListener", "(Lcom/amap/api/maps/AMap$OnCameraChangeListener;)V", "")]
        public unsafe void SetOnCameraChangeListener(global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListener p0)
        {
            if (id_setOnCameraChangeListener_Lcom_amap_api_maps_AMap_OnCameraChangeListener_ == IntPtr.Zero)
                id_setOnCameraChangeListener_Lcom_amap_api_maps_AMap_OnCameraChangeListener_ = JNIEnv.GetMethodID(class_ref, "setOnCameraChangeListener", "(Lcom/amap/api/maps/AMap$OnCameraChangeListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnCameraChangeListener_Lcom_amap_api_maps_AMap_OnCameraChangeListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnIndoorBuildingActiveListener_Lcom_amap_api_maps_AMap_OnIndoorBuildingActiveListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnIndoorBuildingActiveListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnIndoorBuildingActiveListener']]"
        [Register("setOnIndoorBuildingActiveListener", "(Lcom/amap/api/maps/AMap$OnIndoorBuildingActiveListener;)V", "")]
        public unsafe void SetOnIndoorBuildingActiveListener(global::Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListener p0)
        {
            if (id_setOnIndoorBuildingActiveListener_Lcom_amap_api_maps_AMap_OnIndoorBuildingActiveListener_ == IntPtr.Zero)
                id_setOnIndoorBuildingActiveListener_Lcom_amap_api_maps_AMap_OnIndoorBuildingActiveListener_ = JNIEnv.GetMethodID(class_ref, "setOnIndoorBuildingActiveListener", "(Lcom/amap/api/maps/AMap$OnIndoorBuildingActiveListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnIndoorBuildingActiveListener_Lcom_amap_api_maps_AMap_OnIndoorBuildingActiveListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnInfoWindowClickListener_Lcom_amap_api_maps_AMap_OnInfoWindowClickListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnInfoWindowClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnInfoWindowClickListener']]"
        [Register("setOnInfoWindowClickListener", "(Lcom/amap/api/maps/AMap$OnInfoWindowClickListener;)V", "")]
        public unsafe void SetOnInfoWindowClickListener(global::Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListener p0)
        {
            if (id_setOnInfoWindowClickListener_Lcom_amap_api_maps_AMap_OnInfoWindowClickListener_ == IntPtr.Zero)
                id_setOnInfoWindowClickListener_Lcom_amap_api_maps_AMap_OnInfoWindowClickListener_ = JNIEnv.GetMethodID(class_ref, "setOnInfoWindowClickListener", "(Lcom/amap/api/maps/AMap$OnInfoWindowClickListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnInfoWindowClickListener_Lcom_amap_api_maps_AMap_OnInfoWindowClickListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnMapClickListener_Lcom_amap_api_maps_AMap_OnMapClickListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnMapClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnMapClickListener']]"
        [Register("setOnMapClickListener", "(Lcom/amap/api/maps/AMap$OnMapClickListener;)V", "")]
        public unsafe void SetOnMapClickListener(global::Com.Amap.Api.Maps.AMap.IOnMapClickListener p0)
        {
            if (id_setOnMapClickListener_Lcom_amap_api_maps_AMap_OnMapClickListener_ == IntPtr.Zero)
                id_setOnMapClickListener_Lcom_amap_api_maps_AMap_OnMapClickListener_ = JNIEnv.GetMethodID(class_ref, "setOnMapClickListener", "(Lcom/amap/api/maps/AMap$OnMapClickListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnMapClickListener_Lcom_amap_api_maps_AMap_OnMapClickListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnMapLoadedListener_Lcom_amap_api_maps_AMap_OnMapLoadedListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnMapLoadedListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnMapLoadedListener']]"
        [Register("setOnMapLoadedListener", "(Lcom/amap/api/maps/AMap$OnMapLoadedListener;)V", "")]
        public unsafe void SetOnMapLoadedListener(global::Com.Amap.Api.Maps.AMap.IOnMapLoadedListener p0)
        {
            if (id_setOnMapLoadedListener_Lcom_amap_api_maps_AMap_OnMapLoadedListener_ == IntPtr.Zero)
                id_setOnMapLoadedListener_Lcom_amap_api_maps_AMap_OnMapLoadedListener_ = JNIEnv.GetMethodID(class_ref, "setOnMapLoadedListener", "(Lcom/amap/api/maps/AMap$OnMapLoadedListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnMapLoadedListener_Lcom_amap_api_maps_AMap_OnMapLoadedListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnMapLongClickListener_Lcom_amap_api_maps_AMap_OnMapLongClickListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnMapLongClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnMapLongClickListener']]"
        [Register("setOnMapLongClickListener", "(Lcom/amap/api/maps/AMap$OnMapLongClickListener;)V", "")]
        public unsafe void SetOnMapLongClickListener(global::Com.Amap.Api.Maps.AMap.IOnMapLongClickListener p0)
        {
            if (id_setOnMapLongClickListener_Lcom_amap_api_maps_AMap_OnMapLongClickListener_ == IntPtr.Zero)
                id_setOnMapLongClickListener_Lcom_amap_api_maps_AMap_OnMapLongClickListener_ = JNIEnv.GetMethodID(class_ref, "setOnMapLongClickListener", "(Lcom/amap/api/maps/AMap$OnMapLongClickListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnMapLongClickListener_Lcom_amap_api_maps_AMap_OnMapLongClickListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnMapTouchListener_Lcom_amap_api_maps_AMap_OnMapTouchListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnMapTouchListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnMapTouchListener']]"
        [Register("setOnMapTouchListener", "(Lcom/amap/api/maps/AMap$OnMapTouchListener;)V", "")]
        public unsafe void SetOnMapTouchListener(global::Com.Amap.Api.Maps.AMap.IOnMapTouchListener p0)
        {
            if (id_setOnMapTouchListener_Lcom_amap_api_maps_AMap_OnMapTouchListener_ == IntPtr.Zero)
                id_setOnMapTouchListener_Lcom_amap_api_maps_AMap_OnMapTouchListener_ = JNIEnv.GetMethodID(class_ref, "setOnMapTouchListener", "(Lcom/amap/api/maps/AMap$OnMapTouchListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnMapTouchListener_Lcom_amap_api_maps_AMap_OnMapTouchListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnMarkerClickListener_Lcom_amap_api_maps_AMap_OnMarkerClickListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnMarkerClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnMarkerClickListener']]"
        [Register("setOnMarkerClickListener", "(Lcom/amap/api/maps/AMap$OnMarkerClickListener;)V", "")]
        public unsafe void SetOnMarkerClickListener(global::Com.Amap.Api.Maps.AMap.IOnMarkerClickListener p0)
        {
            if (id_setOnMarkerClickListener_Lcom_amap_api_maps_AMap_OnMarkerClickListener_ == IntPtr.Zero)
                id_setOnMarkerClickListener_Lcom_amap_api_maps_AMap_OnMarkerClickListener_ = JNIEnv.GetMethodID(class_ref, "setOnMarkerClickListener", "(Lcom/amap/api/maps/AMap$OnMarkerClickListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnMarkerClickListener_Lcom_amap_api_maps_AMap_OnMarkerClickListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnMarkerDragListener_Lcom_amap_api_maps_AMap_OnMarkerDragListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnMarkerDragListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnMarkerDragListener']]"
        [Register("setOnMarkerDragListener", "(Lcom/amap/api/maps/AMap$OnMarkerDragListener;)V", "")]
        public unsafe void SetOnMarkerDragListener(global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener p0)
        {
            if (id_setOnMarkerDragListener_Lcom_amap_api_maps_AMap_OnMarkerDragListener_ == IntPtr.Zero)
                id_setOnMarkerDragListener_Lcom_amap_api_maps_AMap_OnMarkerDragListener_ = JNIEnv.GetMethodID(class_ref, "setOnMarkerDragListener", "(Lcom/amap/api/maps/AMap$OnMarkerDragListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnMarkerDragListener_Lcom_amap_api_maps_AMap_OnMarkerDragListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnMultiPointClickListener_Lcom_amap_api_maps_AMap_OnMultiPointClickListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnMultiPointClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnMultiPointClickListener']]"
        [Register("setOnMultiPointClickListener", "(Lcom/amap/api/maps/AMap$OnMultiPointClickListener;)V", "")]
        public unsafe void SetOnMultiPointClickListener(global::Com.Amap.Api.Maps.AMap.IOnMultiPointClickListener p0)
        {
            if (id_setOnMultiPointClickListener_Lcom_amap_api_maps_AMap_OnMultiPointClickListener_ == IntPtr.Zero)
                id_setOnMultiPointClickListener_Lcom_amap_api_maps_AMap_OnMultiPointClickListener_ = JNIEnv.GetMethodID(class_ref, "setOnMultiPointClickListener", "(Lcom/amap/api/maps/AMap$OnMultiPointClickListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnMultiPointClickListener_Lcom_amap_api_maps_AMap_OnMultiPointClickListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnMyLocationChangeListener_Lcom_amap_api_maps_AMap_OnMyLocationChangeListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnMyLocationChangeListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnMyLocationChangeListener']]"
        [Register("setOnMyLocationChangeListener", "(Lcom/amap/api/maps/AMap$OnMyLocationChangeListener;)V", "")]
        public unsafe void SetOnMyLocationChangeListener(global::Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListener p0)
        {
            if (id_setOnMyLocationChangeListener_Lcom_amap_api_maps_AMap_OnMyLocationChangeListener_ == IntPtr.Zero)
                id_setOnMyLocationChangeListener_Lcom_amap_api_maps_AMap_OnMyLocationChangeListener_ = JNIEnv.GetMethodID(class_ref, "setOnMyLocationChangeListener", "(Lcom/amap/api/maps/AMap$OnMyLocationChangeListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnMyLocationChangeListener_Lcom_amap_api_maps_AMap_OnMyLocationChangeListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnPOIClickListener_Lcom_amap_api_maps_AMap_OnPOIClickListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnPOIClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnPOIClickListener']]"
        [Register("setOnPOIClickListener", "(Lcom/amap/api/maps/AMap$OnPOIClickListener;)V", "")]
        public unsafe void SetOnPOIClickListener(global::Com.Amap.Api.Maps.AMap.IOnPOIClickListener p0)
        {
            if (id_setOnPOIClickListener_Lcom_amap_api_maps_AMap_OnPOIClickListener_ == IntPtr.Zero)
                id_setOnPOIClickListener_Lcom_amap_api_maps_AMap_OnPOIClickListener_ = JNIEnv.GetMethodID(class_ref, "setOnPOIClickListener", "(Lcom/amap/api/maps/AMap$OnPOIClickListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnPOIClickListener_Lcom_amap_api_maps_AMap_OnPOIClickListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setOnPolylineClickListener_Lcom_amap_api_maps_AMap_OnPolylineClickListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setOnPolylineClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps.AMap.OnPolylineClickListener']]"
        [Register("setOnPolylineClickListener", "(Lcom/amap/api/maps/AMap$OnPolylineClickListener;)V", "")]
        public unsafe void SetOnPolylineClickListener(global::Com.Amap.Api.Maps.AMap.IOnPolylineClickListener p0)
        {
            if (id_setOnPolylineClickListener_Lcom_amap_api_maps_AMap_OnPolylineClickListener_ == IntPtr.Zero)
                id_setOnPolylineClickListener_Lcom_amap_api_maps_AMap_OnPolylineClickListener_ = JNIEnv.GetMethodID(class_ref, "setOnPolylineClickListener", "(Lcom/amap/api/maps/AMap$OnPolylineClickListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnPolylineClickListener_Lcom_amap_api_maps_AMap_OnPolylineClickListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setPointToCenter_II;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setPointToCenter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
        [Register("setPointToCenter", "(II)V", "")]
        public unsafe void SetPointToCenter(int p0, int p1)
        {
            if (id_setPointToCenter_II == IntPtr.Zero)
                id_setPointToCenter_II = JNIEnv.GetMethodID(class_ref, "setPointToCenter", "(II)V");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setPointToCenter_II, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setRenderFps_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setRenderFps' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("setRenderFps", "(I)V", "")]
        public unsafe void SetRenderFps(int p0)
        {
            if (id_setRenderFps_I == IntPtr.Zero)
                id_setRenderFps_I = JNIEnv.GetMethodID(class_ref, "setRenderFps", "(I)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setRenderFps_I, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_setRenderMode_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='setRenderMode' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("setRenderMode", "(I)V", "")]
        public unsafe void SetRenderMode(int p0)
        {
            if (id_setRenderMode_I == IntPtr.Zero)
                id_setRenderMode_I = JNIEnv.GetMethodID(class_ref, "setRenderMode", "(I)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setRenderMode_I, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_showBuildings_Z;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='showBuildings' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("showBuildings", "(Z)V", "")]
        public unsafe void ShowBuildings(bool p0)
        {
            if (id_showBuildings_Z == IntPtr.Zero)
                id_showBuildings_Z = JNIEnv.GetMethodID(class_ref, "showBuildings", "(Z)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_showBuildings_Z, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_showIndoorMap_Z;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='showIndoorMap' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("showIndoorMap", "(Z)V", "")]
        public unsafe void ShowIndoorMap(bool p0)
        {
            if (id_showIndoorMap_Z == IntPtr.Zero)
                id_showIndoorMap_Z = JNIEnv.GetMethodID(class_ref, "showIndoorMap", "(Z)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_showIndoorMap_Z, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_showMapText_Z;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='showMapText' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register("showMapText", "(Z)V", "")]
        public unsafe void ShowMapText(bool p0)
        {
            if (id_showMapText_Z == IntPtr.Zero)
                id_showMapText_Z = JNIEnv.GetMethodID(class_ref, "showMapText", "(Z)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_showMapText_Z, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_stopAnimation;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps']/class[@name='AMap']/method[@name='stopAnimation' and count(parameter)=0]"
        [Register("stopAnimation", "()V", "")]
        public unsafe void StopAnimation()
        {
            if (id_stopAnimation == IntPtr.Zero)
                id_stopAnimation = JNIEnv.GetMethodID(class_ref, "stopAnimation", "()V");
            try
            {
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_stopAnimation);
            }
            finally
            {
            }
        }

        #region "Event implementation for Com.Amap.Api.Maps.Model.IAMapGestureListener"
        public event EventHandler<global::Com.Amap.Api.Maps.Model.DoubleTapEventArgs> DoubleTap
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        __CreateIAMapGestureListenerImplementor,
                        SetAMapGestureListener,
                        __h => __h.OnDoubleTapHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor.__IsEmpty,
                        __v => SetAMapGestureListener(null),
                        __h => __h.OnDoubleTapHandler -= value);
            }
        }

        public event EventHandler<global::Com.Amap.Api.Maps.Model.DownEventArgs> Down
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        __CreateIAMapGestureListenerImplementor,
                        SetAMapGestureListener,
                        __h => __h.OnDownHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor.__IsEmpty,
                        __v => SetAMapGestureListener(null),
                        __h => __h.OnDownHandler -= value);
            }
        }

        public event EventHandler<global::Com.Amap.Api.Maps.Model.FlingEventArgs> Fling
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        __CreateIAMapGestureListenerImplementor,
                        SetAMapGestureListener,
                        __h => __h.OnFlingHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor.__IsEmpty,
                        __v => SetAMapGestureListener(null),
                        __h => __h.OnFlingHandler -= value);
            }
        }

        public event EventHandler<global::Com.Amap.Api.Maps.Model.LongPressEventArgs> LongPress
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        __CreateIAMapGestureListenerImplementor,
                        SetAMapGestureListener,
                        __h => __h.OnLongPressHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor.__IsEmpty,
                        __v => SetAMapGestureListener(null),
                        __h => __h.OnLongPressHandler -= value);
            }
        }

        public event EventHandler MapStable
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        __CreateIAMapGestureListenerImplementor,
                        SetAMapGestureListener,
                        __h => __h.OnMapStableHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor.__IsEmpty,
                        __v => SetAMapGestureListener(null),
                        __h => __h.OnMapStableHandler -= value);
            }
        }

        public event EventHandler<global::Com.Amap.Api.Maps.Model.ScrollEventArgs> Scroll
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        __CreateIAMapGestureListenerImplementor,
                        SetAMapGestureListener,
                        __h => __h.OnScrollHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor.__IsEmpty,
                        __v => SetAMapGestureListener(null),
                        __h => __h.OnScrollHandler -= value);
            }
        }

        public event EventHandler<global::Com.Amap.Api.Maps.Model.SingleTapEventArgs> SingleTap
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        __CreateIAMapGestureListenerImplementor,
                        SetAMapGestureListener,
                        __h => __h.OnSingleTapHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor.__IsEmpty,
                        __v => SetAMapGestureListener(null),
                        __h => __h.OnSingleTapHandler -= value);
            }
        }

        public event EventHandler<global::Com.Amap.Api.Maps.Model.UpEventArgs> Up
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        __CreateIAMapGestureListenerImplementor,
                        SetAMapGestureListener,
                        __h => __h.OnUpHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.Model.IAMapGestureListener, global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor>(
                        ref weak_implementor_SetAMapGestureListener,
                        global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor.__IsEmpty,
                        __v => SetAMapGestureListener(null),
                        __h => __h.OnUpHandler -= value);
            }
        }

        WeakReference weak_implementor_SetAMapGestureListener;

        global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor __CreateIAMapGestureListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.Model.IAMapGestureListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnCameraChangeListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.CameraChangeEventArgs> CameraChange
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListener, global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListenerImplementor>(
                        ref weak_implementor_SetOnCameraChangeListener,
                        __CreateIOnCameraChangeListenerImplementor,
                        SetOnCameraChangeListener,
                        __h => __h.OnCameraChangeHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListener, global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListenerImplementor>(
                        ref weak_implementor_SetOnCameraChangeListener,
                        global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListenerImplementor.__IsEmpty,
                        __v => SetOnCameraChangeListener(null),
                        __h => __h.OnCameraChangeHandler -= value);
            }
        }

        public event EventHandler<global::Com.Amap.Api.Maps.AMap.CameraChangeFinishEventArgs> CameraChangeFinish
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListener, global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListenerImplementor>(
                        ref weak_implementor_SetOnCameraChangeListener,
                        __CreateIOnCameraChangeListenerImplementor,
                        SetOnCameraChangeListener,
                        __h => __h.OnCameraChangeFinishHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListener, global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListenerImplementor>(
                        ref weak_implementor_SetOnCameraChangeListener,
                        global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListenerImplementor.__IsEmpty,
                        __v => SetOnCameraChangeListener(null),
                        __h => __h.OnCameraChangeFinishHandler -= value);
            }
        }

        WeakReference weak_implementor_SetOnCameraChangeListener;

        global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListenerImplementor __CreateIOnCameraChangeListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnCameraChangeListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.IndoorBuildingActiveEventArgs> IndoorBuildingActive
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListener, global::Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListenerImplementor>(
                        ref weak_implementor_SetOnIndoorBuildingActiveListener,
                        __CreateIOnIndoorBuildingActiveListenerImplementor,
                        SetOnIndoorBuildingActiveListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListener, global::Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListenerImplementor>(
                        ref weak_implementor_SetOnIndoorBuildingActiveListener,
                        global::Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListenerImplementor.__IsEmpty,
                        __v => SetOnIndoorBuildingActiveListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnIndoorBuildingActiveListener;

        global::Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListenerImplementor __CreateIOnIndoorBuildingActiveListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnIndoorBuildingActiveListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.InfoWindowClickEventArgs> InfoWindowClick
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListener, global::Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListenerImplementor>(
                        ref weak_implementor_SetOnInfoWindowClickListener,
                        __CreateIOnInfoWindowClickListenerImplementor,
                        SetOnInfoWindowClickListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListener, global::Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListenerImplementor>(
                        ref weak_implementor_SetOnInfoWindowClickListener,
                        global::Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListenerImplementor.__IsEmpty,
                        __v => SetOnInfoWindowClickListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnInfoWindowClickListener;

        global::Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListenerImplementor __CreateIOnInfoWindowClickListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnInfoWindowClickListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnMapClickListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.MapClickEventArgs> MapClick
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMapClickListener, global::Com.Amap.Api.Maps.AMap.IOnMapClickListenerImplementor>(
                        ref weak_implementor_SetOnMapClickListener,
                        __CreateIOnMapClickListenerImplementor,
                        SetOnMapClickListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMapClickListener, global::Com.Amap.Api.Maps.AMap.IOnMapClickListenerImplementor>(
                        ref weak_implementor_SetOnMapClickListener,
                        global::Com.Amap.Api.Maps.AMap.IOnMapClickListenerImplementor.__IsEmpty,
                        __v => SetOnMapClickListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnMapClickListener;

        global::Com.Amap.Api.Maps.AMap.IOnMapClickListenerImplementor __CreateIOnMapClickListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnMapClickListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnMapLoadedListener"
        public event EventHandler MapLoaded
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMapLoadedListener, global::Com.Amap.Api.Maps.AMap.IOnMapLoadedListenerImplementor>(
                        ref weak_implementor_SetOnMapLoadedListener,
                        __CreateIOnMapLoadedListenerImplementor,
                        SetOnMapLoadedListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMapLoadedListener, global::Com.Amap.Api.Maps.AMap.IOnMapLoadedListenerImplementor>(
                        ref weak_implementor_SetOnMapLoadedListener,
                        global::Com.Amap.Api.Maps.AMap.IOnMapLoadedListenerImplementor.__IsEmpty,
                        __v => SetOnMapLoadedListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnMapLoadedListener;

        global::Com.Amap.Api.Maps.AMap.IOnMapLoadedListenerImplementor __CreateIOnMapLoadedListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnMapLoadedListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnMapLongClickListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.MapLongClickEventArgs> MapLongClick
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMapLongClickListener, global::Com.Amap.Api.Maps.AMap.IOnMapLongClickListenerImplementor>(
                        ref weak_implementor_SetOnMapLongClickListener,
                        __CreateIOnMapLongClickListenerImplementor,
                        SetOnMapLongClickListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMapLongClickListener, global::Com.Amap.Api.Maps.AMap.IOnMapLongClickListenerImplementor>(
                        ref weak_implementor_SetOnMapLongClickListener,
                        global::Com.Amap.Api.Maps.AMap.IOnMapLongClickListenerImplementor.__IsEmpty,
                        __v => SetOnMapLongClickListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnMapLongClickListener;

        global::Com.Amap.Api.Maps.AMap.IOnMapLongClickListenerImplementor __CreateIOnMapLongClickListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnMapLongClickListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnMapTouchListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.MapTouchEventArgs> MapTouch
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMapTouchListener, global::Com.Amap.Api.Maps.AMap.IOnMapTouchListenerImplementor>(
                        ref weak_implementor_SetOnMapTouchListener,
                        __CreateIOnMapTouchListenerImplementor,
                        SetOnMapTouchListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMapTouchListener, global::Com.Amap.Api.Maps.AMap.IOnMapTouchListenerImplementor>(
                        ref weak_implementor_SetOnMapTouchListener,
                        global::Com.Amap.Api.Maps.AMap.IOnMapTouchListenerImplementor.__IsEmpty,
                        __v => SetOnMapTouchListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnMapTouchListener;

        global::Com.Amap.Api.Maps.AMap.IOnMapTouchListenerImplementor __CreateIOnMapTouchListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnMapTouchListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnMarkerClickListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.MarkerClickEventArgs> MarkerClick
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMarkerClickListener, global::Com.Amap.Api.Maps.AMap.IOnMarkerClickListenerImplementor>(
                        ref weak_implementor_SetOnMarkerClickListener,
                        __CreateIOnMarkerClickListenerImplementor,
                        SetOnMarkerClickListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMarkerClickListener, global::Com.Amap.Api.Maps.AMap.IOnMarkerClickListenerImplementor>(
                        ref weak_implementor_SetOnMarkerClickListener,
                        global::Com.Amap.Api.Maps.AMap.IOnMarkerClickListenerImplementor.__IsEmpty,
                        __v => SetOnMarkerClickListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnMarkerClickListener;

        global::Com.Amap.Api.Maps.AMap.IOnMarkerClickListenerImplementor __CreateIOnMarkerClickListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnMarkerClickListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnMarkerDragListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.MarkerDragEventArgs> MarkerDrag
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor>(
                        ref weak_implementor_SetOnMarkerDragListener,
                        __CreateIOnMarkerDragListenerImplementor,
                        SetOnMarkerDragListener,
                        __h => __h.OnMarkerDragHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor>(
                        ref weak_implementor_SetOnMarkerDragListener,
                        global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor.__IsEmpty,
                        __v => SetOnMarkerDragListener(null),
                        __h => __h.OnMarkerDragHandler -= value);
            }
        }

        public event EventHandler<global::Com.Amap.Api.Maps.AMap.MarkerDragEndEventArgs> MarkerDragEnd
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor>(
                        ref weak_implementor_SetOnMarkerDragListener,
                        __CreateIOnMarkerDragListenerImplementor,
                        SetOnMarkerDragListener,
                        __h => __h.OnMarkerDragEndHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor>(
                        ref weak_implementor_SetOnMarkerDragListener,
                        global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor.__IsEmpty,
                        __v => SetOnMarkerDragListener(null),
                        __h => __h.OnMarkerDragEndHandler -= value);
            }
        }

        public event EventHandler<global::Com.Amap.Api.Maps.AMap.MarkerDragStartEventArgs> MarkerDragStart
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor>(
                        ref weak_implementor_SetOnMarkerDragListener,
                        __CreateIOnMarkerDragListenerImplementor,
                        SetOnMarkerDragListener,
                        __h => __h.OnMarkerDragStartHandler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor>(
                        ref weak_implementor_SetOnMarkerDragListener,
                        global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor.__IsEmpty,
                        __v => SetOnMarkerDragListener(null),
                        __h => __h.OnMarkerDragStartHandler -= value);
            }
        }

        WeakReference weak_implementor_SetOnMarkerDragListener;

        global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor __CreateIOnMarkerDragListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnMarkerDragListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnMultiPointClickListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.MultiPointClickEventArgs> MultiPointClick
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMultiPointClickListener, global::Com.Amap.Api.Maps.AMap.IOnMultiPointClickListenerImplementor>(
                        ref weak_implementor_SetOnMultiPointClickListener,
                        __CreateIOnMultiPointClickListenerImplementor,
                        SetOnMultiPointClickListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMultiPointClickListener, global::Com.Amap.Api.Maps.AMap.IOnMultiPointClickListenerImplementor>(
                        ref weak_implementor_SetOnMultiPointClickListener,
                        global::Com.Amap.Api.Maps.AMap.IOnMultiPointClickListenerImplementor.__IsEmpty,
                        __v => SetOnMultiPointClickListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnMultiPointClickListener;

        global::Com.Amap.Api.Maps.AMap.IOnMultiPointClickListenerImplementor __CreateIOnMultiPointClickListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnMultiPointClickListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.MyLocationChangeEventArgs> MyLocationChange
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListener, global::Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListenerImplementor>(
                        ref weak_implementor_SetOnMyLocationChangeListener,
                        __CreateIOnMyLocationChangeListenerImplementor,
                        SetOnMyLocationChangeListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListener, global::Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListenerImplementor>(
                        ref weak_implementor_SetOnMyLocationChangeListener,
                        global::Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListenerImplementor.__IsEmpty,
                        __v => SetOnMyLocationChangeListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnMyLocationChangeListener;

        global::Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListenerImplementor __CreateIOnMyLocationChangeListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnMyLocationChangeListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnPOIClickListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.POIClickEventArgs> POIClick
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnPOIClickListener, global::Com.Amap.Api.Maps.AMap.IOnPOIClickListenerImplementor>(
                        ref weak_implementor_SetOnPOIClickListener,
                        __CreateIOnPOIClickListenerImplementor,
                        SetOnPOIClickListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnPOIClickListener, global::Com.Amap.Api.Maps.AMap.IOnPOIClickListenerImplementor>(
                        ref weak_implementor_SetOnPOIClickListener,
                        global::Com.Amap.Api.Maps.AMap.IOnPOIClickListenerImplementor.__IsEmpty,
                        __v => SetOnPOIClickListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnPOIClickListener;

        global::Com.Amap.Api.Maps.AMap.IOnPOIClickListenerImplementor __CreateIOnPOIClickListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnPOIClickListenerImplementor(this);
        }
        #endregion
        #region "Event implementation for Com.Amap.Api.Maps.AMap.IOnPolylineClickListener"
        public event EventHandler<global::Com.Amap.Api.Maps.AMap.PolylineClickEventArgs> PolylineClick
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps.AMap.IOnPolylineClickListener, global::Com.Amap.Api.Maps.AMap.IOnPolylineClickListenerImplementor>(
                        ref weak_implementor_SetOnPolylineClickListener,
                        __CreateIOnPolylineClickListenerImplementor,
                        SetOnPolylineClickListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps.AMap.IOnPolylineClickListener, global::Com.Amap.Api.Maps.AMap.IOnPolylineClickListenerImplementor>(
                        ref weak_implementor_SetOnPolylineClickListener,
                        global::Com.Amap.Api.Maps.AMap.IOnPolylineClickListenerImplementor.__IsEmpty,
                        __v => SetOnPolylineClickListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnPolylineClickListener;

        global::Com.Amap.Api.Maps.AMap.IOnPolylineClickListenerImplementor __CreateIOnPolylineClickListenerImplementor()
        {
            return new global::Com.Amap.Api.Maps.AMap.IOnPolylineClickListenerImplementor(this);
        }
        #endregion
    }
}
