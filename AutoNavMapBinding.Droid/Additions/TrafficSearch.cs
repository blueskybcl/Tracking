using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amap.Api.Services.Traffic
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.services.traffic']/class[@name='TrafficSearch']"
    [global::Android.Runtime.Register("com/amap/api/services/traffic/TrafficSearch", DoNotGenerateAcw = true)]
    public partial class TrafficSearch : global::Java.Lang.Object
    {


        static IntPtr ROAD_LEVEL_CITY_QUICK_WAY_jfieldId;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.services.traffic']/class[@name='TrafficSearch']/field[@name='ROAD_LEVEL_CITY_QUICK_WAY']"
        [Register("ROAD_LEVEL_CITY_QUICK_WAY")]
        public static int RoadLevelCityQuickWay
        {
            get
            {
                if (ROAD_LEVEL_CITY_QUICK_WAY_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_CITY_QUICK_WAY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_CITY_QUICK_WAY", "I");
                return JNIEnv.GetStaticIntField(class_ref, ROAD_LEVEL_CITY_QUICK_WAY_jfieldId);
            }
            set
            {
                if (ROAD_LEVEL_CITY_QUICK_WAY_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_CITY_QUICK_WAY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_CITY_QUICK_WAY", "I");
                try
                {
                    JNIEnv.SetStaticField(class_ref, ROAD_LEVEL_CITY_QUICK_WAY_jfieldId, value);
                }
                finally
                {
                }
            }
        }

        static IntPtr ROAD_LEVEL_HIGH_WAY_jfieldId;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.services.traffic']/class[@name='TrafficSearch']/field[@name='ROAD_LEVEL_HIGH_WAY']"
        [Register("ROAD_LEVEL_HIGH_WAY")]
        public static int RoadLevelHighWay
        {
            get
            {
                if (ROAD_LEVEL_HIGH_WAY_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_HIGH_WAY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_HIGH_WAY", "I");
                return JNIEnv.GetStaticIntField(class_ref, ROAD_LEVEL_HIGH_WAY_jfieldId);
            }
            set
            {
                if (ROAD_LEVEL_HIGH_WAY_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_HIGH_WAY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_HIGH_WAY", "I");
                try
                {
                    JNIEnv.SetStaticField(class_ref, ROAD_LEVEL_HIGH_WAY_jfieldId, value);
                }
                finally
                {
                }
            }
        }

        static IntPtr ROAD_LEVEL_HIGH_WAY_BYROAD_jfieldId;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.services.traffic']/class[@name='TrafficSearch']/field[@name='ROAD_LEVEL_HIGH_WAY_BYROAD']"
        [Register("ROAD_LEVEL_HIGH_WAY_BYROAD")]
        public static int RoadLevelHighWayByroad
        {
            get
            {
                if (ROAD_LEVEL_HIGH_WAY_BYROAD_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_HIGH_WAY_BYROAD_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_HIGH_WAY_BYROAD", "I");
                return JNIEnv.GetStaticIntField(class_ref, ROAD_LEVEL_HIGH_WAY_BYROAD_jfieldId);
            }
            set
            {
                if (ROAD_LEVEL_HIGH_WAY_BYROAD_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_HIGH_WAY_BYROAD_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_HIGH_WAY_BYROAD", "I");
                try
                {
                    JNIEnv.SetStaticField(class_ref, ROAD_LEVEL_HIGH_WAY_BYROAD_jfieldId, value);
                }
                finally
                {
                }
            }
        }

        static IntPtr ROAD_LEVEL_MAIN_WAY_jfieldId;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.services.traffic']/class[@name='TrafficSearch']/field[@name='ROAD_LEVEL_MAIN_WAY']"
        [Register("ROAD_LEVEL_MAIN_WAY")]
        public static int RoadLevelMainWay
        {
            get
            {
                if (ROAD_LEVEL_MAIN_WAY_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_MAIN_WAY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_MAIN_WAY", "I");
                return JNIEnv.GetStaticIntField(class_ref, ROAD_LEVEL_MAIN_WAY_jfieldId);
            }
            set
            {
                if (ROAD_LEVEL_MAIN_WAY_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_MAIN_WAY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_MAIN_WAY", "I");
                try
                {
                    JNIEnv.SetStaticField(class_ref, ROAD_LEVEL_MAIN_WAY_jfieldId, value);
                }
                finally
                {
                }
            }
        }

        static IntPtr ROAD_LEVEL_NONAME_WAY_jfieldId;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.services.traffic']/class[@name='TrafficSearch']/field[@name='ROAD_LEVEL_NONAME_WAY']"
        [Register("ROAD_LEVEL_NONAME_WAY")]
        public static int RoadLevelNonameWay
        {
            get
            {
                if (ROAD_LEVEL_NONAME_WAY_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_NONAME_WAY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_NONAME_WAY", "I");
                return JNIEnv.GetStaticIntField(class_ref, ROAD_LEVEL_NONAME_WAY_jfieldId);
            }
            set
            {
                if (ROAD_LEVEL_NONAME_WAY_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_NONAME_WAY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_NONAME_WAY", "I");
                try
                {
                    JNIEnv.SetStaticField(class_ref, ROAD_LEVEL_NONAME_WAY_jfieldId, value);
                }
                finally
                {
                }
            }
        }

        static IntPtr ROAD_LEVEL_NORMAL_WAY_jfieldId;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.services.traffic']/class[@name='TrafficSearch']/field[@name='ROAD_LEVEL_NORMAL_WAY']"
        [Register("ROAD_LEVEL_NORMAL_WAY")]
        public static int RoadLevelNormalWay
        {
            get
            {
                if (ROAD_LEVEL_NORMAL_WAY_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_NORMAL_WAY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_NORMAL_WAY", "I");
                return JNIEnv.GetStaticIntField(class_ref, ROAD_LEVEL_NORMAL_WAY_jfieldId);
            }
            set
            {
                if (ROAD_LEVEL_NORMAL_WAY_jfieldId == IntPtr.Zero)
                    ROAD_LEVEL_NORMAL_WAY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROAD_LEVEL_NORMAL_WAY", "I");
                try
                {
                    JNIEnv.SetStaticField(class_ref, ROAD_LEVEL_NORMAL_WAY_jfieldId, value);
                }
                finally
                {
                }
            }
        }
        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.services.traffic']/interface[@name='TrafficSearch.OnTrafficSearchListener']"
        [Register("com/amap/api/services/traffic/TrafficSearch$OnTrafficSearchListener", "", "Com.Amap.Api.Services.Traffic.TrafficSearch/IOnTrafficSearchListenerInvoker")]
        public partial interface IOnTrafficSearchListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.traffic']/interface[@name='TrafficSearch.OnTrafficSearchListener']/method[@name='onRoadTrafficSearched' and count(parameter)=2 and parameter[1][@type='com.amap.api.services.traffic.TrafficStatusResult'] and parameter[2][@type='int']]"
            [Register("onRoadTrafficSearched", "(Lcom/amap/api/services/traffic/TrafficStatusResult;I)V", "GetOnRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_IHandler:Com.Amap.Api.Services.Traffic.TrafficSearch/IOnTrafficSearchListenerInvoker, AutoNavMapBinding.Droid")]
            void OnRoadTrafficSearched(global::Com.Amap.Api.Services.Traffic.TrafficStatusResult p0, int p1);

        }

        [global::Android.Runtime.Register("com/amap/api/services/traffic/TrafficSearch$OnTrafficSearchListener", DoNotGenerateAcw = true)]
        internal class IOnTrafficSearchListenerInvoker : global::Java.Lang.Object, IOnTrafficSearchListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/services/traffic/TrafficSearch$OnTrafficSearchListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnTrafficSearchListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnTrafficSearchListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnTrafficSearchListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.services.traffic.TrafficSearch.OnTrafficSearchListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnTrafficSearchListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_I;
#pragma warning disable 0169
            static Delegate GetOnRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_IHandler()
            {
                if (cb_onRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_I == null)
                    cb_onRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int>)n_OnRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_I);
                return cb_onRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_I;
            }

            static void n_OnRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
            {
                global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Services.Traffic.TrafficStatusResult p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Traffic.TrafficStatusResult>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnRoadTrafficSearched(p0, p1);
            }
#pragma warning restore 0169

            IntPtr id_onRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_I;
            public unsafe void OnRoadTrafficSearched(global::Com.Amap.Api.Services.Traffic.TrafficStatusResult p0, int p1)
            {
                if (id_onRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_I == IntPtr.Zero)
                    id_onRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_I = JNIEnv.GetMethodID(class_ref, "onRoadTrafficSearched", "(Lcom/amap/api/services/traffic/TrafficStatusResult;I)V");
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onRoadTrafficSearched_Lcom_amap_api_services_traffic_TrafficStatusResult_I, __args);
            }

        }

        public partial class TrafficSearchEventArgs : global::System.EventArgs
        {

            public TrafficSearchEventArgs(global::Com.Amap.Api.Services.Traffic.TrafficStatusResult p0, int p1)
            {
                this.p0 = p0;
                this.p1 = p1;
            }

            global::Com.Amap.Api.Services.Traffic.TrafficStatusResult p0;
            public global::Com.Amap.Api.Services.Traffic.TrafficStatusResult P0
            {
                get { return p0; }
            }

            int p1;
            public int P1
            {
                get { return p1; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/services/traffic/TrafficSearch_OnTrafficSearchListenerImplementor")]
        internal sealed partial class IOnTrafficSearchListenerImplementor : global::Java.Lang.Object, IOnTrafficSearchListener
        {

            object sender;

            public IOnTrafficSearchListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/services/traffic/TrafficSearch_OnTrafficSearchListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<TrafficSearchEventArgs> Handler;
#pragma warning restore 0649

            public void OnRoadTrafficSearched(global::Com.Amap.Api.Services.Traffic.TrafficStatusResult p0, int p1)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new TrafficSearchEventArgs(p0, p1));
            }

            internal static bool __IsEmpty(IOnTrafficSearchListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        internal static new IntPtr java_class_handle;
        internal static new IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/amap/api/services/traffic/TrafficSearch", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(TrafficSearch); }
        }

        protected TrafficSearch(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_ctor_Landroid_content_Context_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.services.traffic']/class[@name='TrafficSearch']/constructor[@name='TrafficSearch' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
        [Register(".ctor", "(Landroid/content/Context;)V", "")]
        public unsafe TrafficSearch(global::Android.Content.Context p0)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                if (((object)this).GetType() != typeof(TrafficSearch))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(Landroid/content/Context;)V", __args),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "(Landroid/content/Context;)V", __args);
                    return;
                }

                if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
                    id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Landroid/content/Context;)V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Landroid_content_Context_, __args),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_setTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_;
#pragma warning disable 0169
        static Delegate GetSetTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_Handler()
        {
            if (cb_setTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_ == null)
                cb_setTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_);
            return cb_setTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_;
        }

        static void n_SetTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Amap.Api.Services.Traffic.TrafficSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Traffic.TrafficSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListener p0 = (global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListener>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.SetTrafficSearchListener(p0);
        }
#pragma warning restore 0169

        static IntPtr id_setTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.traffic']/class[@name='TrafficSearch']/method[@name='setTrafficSearchListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.services.traffic.TrafficSearch.OnTrafficSearchListener']]"
        [Register("setTrafficSearchListener", "(Lcom/amap/api/services/traffic/TrafficSearch$OnTrafficSearchListener;)V", "GetSetTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_Handler")]
        public virtual unsafe void SetTrafficSearchListener(global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListener p0)
        {
            if (id_setTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_ == IntPtr.Zero)
                id_setTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_ = JNIEnv.GetMethodID(class_ref, "setTrafficSearchListener", "(Lcom/amap/api/services/traffic/TrafficSearch$OnTrafficSearchListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setTrafficSearchListener_Lcom_amap_api_services_traffic_TrafficSearch_OnTrafficSearchListener_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setTrafficSearchListener", "(Lcom/amap/api/services/traffic/TrafficSearch$OnTrafficSearchListener;)V"), __args);
            }
            finally
            {
            }
        }

        #region "Event implementation for Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListener"
        public event EventHandler<global::Com.Amap.Api.Services.Traffic.TrafficSearch.TrafficSearchEventArgs> TrafficSearchEvent
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListener, global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListenerImplementor>(
                        ref weak_implementor_SetTrafficSearchListener,
                        __CreateIOnTrafficSearchListenerImplementor,
                        SetTrafficSearchListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListener, global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListenerImplementor>(
                        ref weak_implementor_SetTrafficSearchListener,
                        global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListenerImplementor.__IsEmpty,
                        __v => SetTrafficSearchListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetTrafficSearchListener;

        global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListenerImplementor __CreateIOnTrafficSearchListenerImplementor()
        {
            return new global::Com.Amap.Api.Services.Traffic.TrafficSearch.IOnTrafficSearchListenerImplementor(this);
        }
        #endregion
    }
}
