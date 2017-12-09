using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amap.Api.Services.Busline
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusStationSearch']"
    [global::Android.Runtime.Register("com/amap/api/services/busline/BusStationSearch", DoNotGenerateAcw = true)]
    public partial class BusStationSearch : global::Java.Lang.Object
    {

        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.services.busline']/interface[@name='BusStationSearch.OnBusStationSearchListener']"
        [Register("com/amap/api/services/busline/BusStationSearch$OnBusStationSearchListener", "", "Com.Amap.Api.Services.Busline.BusStationSearch/IOnBusStationSearchListenerInvoker")]
        public partial interface IOnBusStationSearchListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/interface[@name='BusStationSearch.OnBusStationSearchListener']/method[@name='onBusStationSearched' and count(parameter)=2 and parameter[1][@type='com.amap.api.services.busline.BusStationResult'] and parameter[2][@type='int']]"
            [Register("onBusStationSearched", "(Lcom/amap/api/services/busline/BusStationResult;I)V", "GetOnBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_IHandler:Com.Amap.Api.Services.Busline.BusStationSearch/IOnBusStationSearchListenerInvoker, AutoNavMapBinding.Droid")]
            void OnBusStationSearched(global::Com.Amap.Api.Services.Busline.BusStationResult p0, int p1);

        }

        [global::Android.Runtime.Register("com/amap/api/services/busline/BusStationSearch$OnBusStationSearchListener", DoNotGenerateAcw = true)]
        internal class IOnBusStationSearchListenerInvoker : global::Java.Lang.Object, IOnBusStationSearchListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/services/busline/BusStationSearch$OnBusStationSearchListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnBusStationSearchListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnBusStationSearchListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnBusStationSearchListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.services.busline.BusStationSearch.OnBusStationSearchListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnBusStationSearchListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_I;
#pragma warning disable 0169
            static Delegate GetOnBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_IHandler()
            {
                if (cb_onBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_I == null)
                    cb_onBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int>)n_OnBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_I);
                return cb_onBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_I;
            }

            static void n_OnBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
            {
                global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Services.Busline.BusStationResult p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationResult>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnBusStationSearched(p0, p1);
            }
#pragma warning restore 0169

            IntPtr id_onBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_I;
            public unsafe void OnBusStationSearched(global::Com.Amap.Api.Services.Busline.BusStationResult p0, int p1)
            {
                if (id_onBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_I == IntPtr.Zero)
                    id_onBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_I = JNIEnv.GetMethodID(class_ref, "onBusStationSearched", "(Lcom/amap/api/services/busline/BusStationResult;I)V");
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onBusStationSearched_Lcom_amap_api_services_busline_BusStationResult_I, __args);
            }

        }

        public partial class BusStationSearchEventArgs : global::System.EventArgs
        {

            public BusStationSearchEventArgs(global::Com.Amap.Api.Services.Busline.BusStationResult p0, int p1)
            {
                this.p0 = p0;
                this.p1 = p1;
            }

            global::Com.Amap.Api.Services.Busline.BusStationResult p0;
            public global::Com.Amap.Api.Services.Busline.BusStationResult P0
            {
                get { return p0; }
            }

            int p1;
            public int P1
            {
                get { return p1; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/services/busline/BusStationSearch_OnBusStationSearchListenerImplementor")]
        internal sealed partial class IOnBusStationSearchListenerImplementor : global::Java.Lang.Object, IOnBusStationSearchListener
        {

            object sender;

            public IOnBusStationSearchListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/services/busline/BusStationSearch_OnBusStationSearchListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<BusStationSearchEventArgs> Handler;
#pragma warning restore 0649

            public void OnBusStationSearched(global::Com.Amap.Api.Services.Busline.BusStationResult p0, int p1)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new BusStationSearchEventArgs(p0, p1));
            }

            internal static bool __IsEmpty(IOnBusStationSearchListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        internal static new IntPtr java_class_handle;
        internal static new IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/amap/api/services/busline/BusStationSearch", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(BusStationSearch); }
        }

        protected BusStationSearch(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_ctor_Landroid_content_Context_Lcom_amap_api_services_busline_BusStationQuery_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusStationSearch']/constructor[@name='BusStationSearch' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amap.api.services.busline.BusStationQuery']]"
        [Register(".ctor", "(Landroid/content/Context;Lcom/amap/api/services/busline/BusStationQuery;)V", "")]
        public unsafe BusStationSearch(global::Android.Content.Context p0, global::Com.Amap.Api.Services.Busline.BusStationQuery p1)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                if (((object)this).GetType() != typeof(BusStationSearch))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(Landroid/content/Context;Lcom/amap/api/services/busline/BusStationQuery;)V", __args),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "(Landroid/content/Context;Lcom/amap/api/services/busline/BusStationQuery;)V", __args);
                    return;
                }

                if (id_ctor_Landroid_content_Context_Lcom_amap_api_services_busline_BusStationQuery_ == IntPtr.Zero)
                    id_ctor_Landroid_content_Context_Lcom_amap_api_services_busline_BusStationQuery_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Landroid/content/Context;Lcom/amap/api/services/busline/BusStationQuery;)V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Landroid_content_Context_Lcom_amap_api_services_busline_BusStationQuery_, __args),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_amap_api_services_busline_BusStationQuery_, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_getQuery;
#pragma warning disable 0169
        static Delegate GetGetQueryHandler()
        {
            if (cb_getQuery == null)
                cb_getQuery = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetQuery);
            return cb_getQuery;
        }

        static IntPtr n_GetQuery(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Amap.Api.Services.Busline.BusStationSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Query);
        }
#pragma warning restore 0169

        static Delegate cb_setQuery_Lcom_amap_api_services_busline_BusStationQuery_;
#pragma warning disable 0169
        static Delegate GetSetQuery_Lcom_amap_api_services_busline_BusStationQuery_Handler()
        {
            if (cb_setQuery_Lcom_amap_api_services_busline_BusStationQuery_ == null)
                cb_setQuery_Lcom_amap_api_services_busline_BusStationQuery_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetQuery_Lcom_amap_api_services_busline_BusStationQuery_);
            return cb_setQuery_Lcom_amap_api_services_busline_BusStationQuery_;
        }

        static void n_SetQuery_Lcom_amap_api_services_busline_BusStationQuery_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Amap.Api.Services.Busline.BusStationSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Amap.Api.Services.Busline.BusStationQuery p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationQuery>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.Query = p0;
        }
#pragma warning restore 0169

        static IntPtr id_getQuery;
        static IntPtr id_setQuery_Lcom_amap_api_services_busline_BusStationQuery_;
        public virtual unsafe global::Com.Amap.Api.Services.Busline.BusStationQuery Query
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusStationSearch']/method[@name='getQuery' and count(parameter)=0]"
            [Register("getQuery", "()Lcom/amap/api/services/busline/BusStationQuery;", "GetGetQueryHandler")]
            get
            {
                if (id_getQuery == IntPtr.Zero)
                    id_getQuery = JNIEnv.GetMethodID(class_ref, "getQuery", "()Lcom/amap/api/services/busline/BusStationQuery;");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationQuery>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
                    else
                        return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationQuery>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getQuery", "()Lcom/amap/api/services/busline/BusStationQuery;")), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusStationSearch']/method[@name='setQuery' and count(parameter)=1 and parameter[1][@type='com.amap.api.services.busline.BusStationQuery']]"
            [Register("setQuery", "(Lcom/amap/api/services/busline/BusStationQuery;)V", "GetSetQuery_Lcom_amap_api_services_busline_BusStationQuery_Handler")]
            set
            {
                if (id_setQuery_Lcom_amap_api_services_busline_BusStationQuery_ == IntPtr.Zero)
                    id_setQuery_Lcom_amap_api_services_busline_BusStationQuery_ = JNIEnv.GetMethodID(class_ref, "setQuery", "(Lcom/amap/api/services/busline/BusStationQuery;)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setQuery_Lcom_amap_api_services_busline_BusStationQuery_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setQuery", "(Lcom/amap/api/services/busline/BusStationQuery;)V"), __args);
                }
                finally
                {
                }
            }
        }

        static Delegate cb_searchBusStation;
#pragma warning disable 0169
        static Delegate GetSearchBusStationHandler()
        {
            if (cb_searchBusStation == null)
                cb_searchBusStation = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_SearchBusStation);
            return cb_searchBusStation;
        }

        static IntPtr n_SearchBusStation(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Amap.Api.Services.Busline.BusStationSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SearchBusStation());
        }
#pragma warning restore 0169

        static IntPtr id_searchBusStation;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusStationSearch']/method[@name='searchBusStation' and count(parameter)=0]"
        [Register("searchBusStation", "()Lcom/amap/api/services/busline/BusStationResult;", "GetSearchBusStationHandler")]
        public virtual unsafe global::Com.Amap.Api.Services.Busline.BusStationResult SearchBusStation()
        {
            if (id_searchBusStation == IntPtr.Zero)
                id_searchBusStation = JNIEnv.GetMethodID(class_ref, "searchBusStation", "()Lcom/amap/api/services/busline/BusStationResult;");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationResult>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_searchBusStation), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationResult>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "searchBusStation", "()Lcom/amap/api/services/busline/BusStationResult;")), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_searchBusStationAsyn;
#pragma warning disable 0169
        static Delegate GetSearchBusStationAsynHandler()
        {
            if (cb_searchBusStationAsyn == null)
                cb_searchBusStationAsyn = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_SearchBusStationAsyn);
            return cb_searchBusStationAsyn;
        }

        static void n_SearchBusStationAsyn(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Amap.Api.Services.Busline.BusStationSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SearchBusStationAsyn();
        }
#pragma warning restore 0169

        static IntPtr id_searchBusStationAsyn;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusStationSearch']/method[@name='searchBusStationAsyn' and count(parameter)=0]"
        [Register("searchBusStationAsyn", "()V", "GetSearchBusStationAsynHandler")]
        public virtual unsafe void SearchBusStationAsyn()
        {
            if (id_searchBusStationAsyn == IntPtr.Zero)
                id_searchBusStationAsyn = JNIEnv.GetMethodID(class_ref, "searchBusStationAsyn", "()V");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_searchBusStationAsyn);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "searchBusStationAsyn", "()V"));
            }
            finally
            {
            }
        }

        static Delegate cb_setOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_;
#pragma warning disable 0169
        static Delegate GetSetOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_Handler()
        {
            if (cb_setOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_ == null)
                cb_setOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_);
            return cb_setOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_;
        }

        static void n_SetOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Amap.Api.Services.Busline.BusStationSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListener p0 = (global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListener>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.SetOnBusStationSearchListener(p0);
        }
#pragma warning restore 0169

        static IntPtr id_setOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusStationSearch']/method[@name='setOnBusStationSearchListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.services.busline.BusStationSearch.OnBusStationSearchListener']]"
        [Register("setOnBusStationSearchListener", "(Lcom/amap/api/services/busline/BusStationSearch$OnBusStationSearchListener;)V", "GetSetOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_Handler")]
        public virtual unsafe void SetOnBusStationSearchListener(global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListener p0)
        {
            if (id_setOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_ == IntPtr.Zero)
                id_setOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_ = JNIEnv.GetMethodID(class_ref, "setOnBusStationSearchListener", "(Lcom/amap/api/services/busline/BusStationSearch$OnBusStationSearchListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnBusStationSearchListener_Lcom_amap_api_services_busline_BusStationSearch_OnBusStationSearchListener_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setOnBusStationSearchListener", "(Lcom/amap/api/services/busline/BusStationSearch$OnBusStationSearchListener;)V"), __args);
            }
            finally
            {
            }
        }

        #region "Event implementation for Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListener"
        public event EventHandler<global::Com.Amap.Api.Services.Busline.BusStationSearch.BusStationSearchEventArgs> BusStationSearchEvent
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListener, global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListenerImplementor>(
                        ref weak_implementor_SetOnBusStationSearchListener,
                        __CreateIOnBusStationSearchListenerImplementor,
                        SetOnBusStationSearchListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListener, global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListenerImplementor>(
                        ref weak_implementor_SetOnBusStationSearchListener,
                        global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListenerImplementor.__IsEmpty,
                        __v => SetOnBusStationSearchListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnBusStationSearchListener;

        global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListenerImplementor __CreateIOnBusStationSearchListenerImplementor()
        {
            return new global::Com.Amap.Api.Services.Busline.BusStationSearch.IOnBusStationSearchListenerImplementor(this);
        }
        #endregion
    }
}
