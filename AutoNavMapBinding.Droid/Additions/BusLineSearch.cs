using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amap.Api.Services.Busline
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusLineSearch']"
    [global::Android.Runtime.Register("com/amap/api/services/busline/BusLineSearch", DoNotGenerateAcw = true)]
    public partial class BusLineSearch : global::Java.Lang.Object
    {

        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.services.busline']/interface[@name='BusLineSearch.OnBusLineSearchListener']"
        [Register("com/amap/api/services/busline/BusLineSearch$OnBusLineSearchListener", "", "Com.Amap.Api.Services.Busline.BusLineSearch/IOnBusLineSearchListenerInvoker")]
        public partial interface IOnBusLineSearchListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/interface[@name='BusLineSearch.OnBusLineSearchListener']/method[@name='onBusLineSearched' and count(parameter)=2 and parameter[1][@type='com.amap.api.services.busline.BusLineResult'] and parameter[2][@type='int']]"
            [Register("onBusLineSearched", "(Lcom/amap/api/services/busline/BusLineResult;I)V", "GetOnBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_IHandler:Com.Amap.Api.Services.Busline.BusLineSearch/IOnBusLineSearchListenerInvoker, AutoNavMapBinding.Droid")]
            void OnBusLineSearched(global::Com.Amap.Api.Services.Busline.BusLineResult p0, int p1);

        }

        [global::Android.Runtime.Register("com/amap/api/services/busline/BusLineSearch$OnBusLineSearchListener", DoNotGenerateAcw = true)]
        internal class IOnBusLineSearchListenerInvoker : global::Java.Lang.Object, IOnBusLineSearchListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/services/busline/BusLineSearch$OnBusLineSearchListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnBusLineSearchListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnBusLineSearchListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnBusLineSearchListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.services.busline.BusLineSearch.OnBusLineSearchListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnBusLineSearchListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_I;
#pragma warning disable 0169
            static Delegate GetOnBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_IHandler()
            {
                if (cb_onBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_I == null)
                    cb_onBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int>)n_OnBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_I);
                return cb_onBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_I;
            }

            static void n_OnBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
            {
                global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Services.Busline.BusLineResult p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineResult>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnBusLineSearched(p0, p1);
            }
#pragma warning restore 0169

            IntPtr id_onBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_I;
            public unsafe void OnBusLineSearched(global::Com.Amap.Api.Services.Busline.BusLineResult p0, int p1)
            {
                if (id_onBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_I == IntPtr.Zero)
                    id_onBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_I = JNIEnv.GetMethodID(class_ref, "onBusLineSearched", "(Lcom/amap/api/services/busline/BusLineResult;I)V");
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onBusLineSearched_Lcom_amap_api_services_busline_BusLineResult_I, __args);
            }

        }

        public partial class BusLineSearchEventArgs : global::System.EventArgs
        {

            public BusLineSearchEventArgs(global::Com.Amap.Api.Services.Busline.BusLineResult p0, int p1)
            {
                this.p0 = p0;
                this.p1 = p1;
            }

            global::Com.Amap.Api.Services.Busline.BusLineResult p0;
            public global::Com.Amap.Api.Services.Busline.BusLineResult P0
            {
                get { return p0; }
            }

            int p1;
            public int P1
            {
                get { return p1; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/services/busline/BusLineSearch_OnBusLineSearchListenerImplementor")]
        internal sealed partial class IOnBusLineSearchListenerImplementor : global::Java.Lang.Object, IOnBusLineSearchListener
        {

            object sender;

            public IOnBusLineSearchListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/services/busline/BusLineSearch_OnBusLineSearchListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<BusLineSearchEventArgs> Handler;
#pragma warning restore 0649

            public void OnBusLineSearched(global::Com.Amap.Api.Services.Busline.BusLineResult p0, int p1)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new BusLineSearchEventArgs(p0, p1));
            }

            internal static bool __IsEmpty(IOnBusLineSearchListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        internal static new IntPtr java_class_handle;
        internal static new IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/amap/api/services/busline/BusLineSearch", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(BusLineSearch); }
        }

        protected BusLineSearch(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_ctor_Landroid_content_Context_Lcom_amap_api_services_busline_BusLineQuery_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusLineSearch']/constructor[@name='BusLineSearch' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amap.api.services.busline.BusLineQuery']]"
        [Register(".ctor", "(Landroid/content/Context;Lcom/amap/api/services/busline/BusLineQuery;)V", "")]
        public unsafe BusLineSearch(global::Android.Content.Context p0, global::Com.Amap.Api.Services.Busline.BusLineQuery p1)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                if (((object)this).GetType() != typeof(BusLineSearch))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(Landroid/content/Context;Lcom/amap/api/services/busline/BusLineQuery;)V", __args),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "(Landroid/content/Context;Lcom/amap/api/services/busline/BusLineQuery;)V", __args);
                    return;
                }

                if (id_ctor_Landroid_content_Context_Lcom_amap_api_services_busline_BusLineQuery_ == IntPtr.Zero)
                    id_ctor_Landroid_content_Context_Lcom_amap_api_services_busline_BusLineQuery_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Landroid/content/Context;Lcom/amap/api/services/busline/BusLineQuery;)V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Landroid_content_Context_Lcom_amap_api_services_busline_BusLineQuery_, __args),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_amap_api_services_busline_BusLineQuery_, __args);
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
            global::Com.Amap.Api.Services.Busline.BusLineSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Query);
        }
#pragma warning restore 0169

        static Delegate cb_setQuery_Lcom_amap_api_services_busline_BusLineQuery_;
#pragma warning disable 0169
        static Delegate GetSetQuery_Lcom_amap_api_services_busline_BusLineQuery_Handler()
        {
            if (cb_setQuery_Lcom_amap_api_services_busline_BusLineQuery_ == null)
                cb_setQuery_Lcom_amap_api_services_busline_BusLineQuery_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetQuery_Lcom_amap_api_services_busline_BusLineQuery_);
            return cb_setQuery_Lcom_amap_api_services_busline_BusLineQuery_;
        }

        static void n_SetQuery_Lcom_amap_api_services_busline_BusLineQuery_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Amap.Api.Services.Busline.BusLineSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Amap.Api.Services.Busline.BusLineQuery p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineQuery>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.Query = p0;
        }
#pragma warning restore 0169

        static IntPtr id_getQuery;
        static IntPtr id_setQuery_Lcom_amap_api_services_busline_BusLineQuery_;
        public virtual unsafe global::Com.Amap.Api.Services.Busline.BusLineQuery Query
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusLineSearch']/method[@name='getQuery' and count(parameter)=0]"
            [Register("getQuery", "()Lcom/amap/api/services/busline/BusLineQuery;", "GetGetQueryHandler")]
            get
            {
                if (id_getQuery == IntPtr.Zero)
                    id_getQuery = JNIEnv.GetMethodID(class_ref, "getQuery", "()Lcom/amap/api/services/busline/BusLineQuery;");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineQuery>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
                    else
                        return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineQuery>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getQuery", "()Lcom/amap/api/services/busline/BusLineQuery;")), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusLineSearch']/method[@name='setQuery' and count(parameter)=1 and parameter[1][@type='com.amap.api.services.busline.BusLineQuery']]"
            [Register("setQuery", "(Lcom/amap/api/services/busline/BusLineQuery;)V", "GetSetQuery_Lcom_amap_api_services_busline_BusLineQuery_Handler")]
            set
            {
                if (id_setQuery_Lcom_amap_api_services_busline_BusLineQuery_ == IntPtr.Zero)
                    id_setQuery_Lcom_amap_api_services_busline_BusLineQuery_ = JNIEnv.GetMethodID(class_ref, "setQuery", "(Lcom/amap/api/services/busline/BusLineQuery;)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setQuery_Lcom_amap_api_services_busline_BusLineQuery_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setQuery", "(Lcom/amap/api/services/busline/BusLineQuery;)V"), __args);
                }
                finally
                {
                }
            }
        }

        static Delegate cb_searchBusLine;
#pragma warning disable 0169
        static Delegate GetSearchBusLineHandler()
        {
            if (cb_searchBusLine == null)
                cb_searchBusLine = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_SearchBusLine);
            return cb_searchBusLine;
        }

        static IntPtr n_SearchBusLine(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Amap.Api.Services.Busline.BusLineSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SearchBusLine());
        }
#pragma warning restore 0169

        static IntPtr id_searchBusLine;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusLineSearch']/method[@name='searchBusLine' and count(parameter)=0]"
        [Register("searchBusLine", "()Lcom/amap/api/services/busline/BusLineResult;", "GetSearchBusLineHandler")]
        public virtual unsafe global::Com.Amap.Api.Services.Busline.BusLineResult SearchBusLine()
        {
            if (id_searchBusLine == IntPtr.Zero)
                id_searchBusLine = JNIEnv.GetMethodID(class_ref, "searchBusLine", "()Lcom/amap/api/services/busline/BusLineResult;");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineResult>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_searchBusLine), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineResult>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "searchBusLine", "()Lcom/amap/api/services/busline/BusLineResult;")), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_searchBusLineAsyn;
#pragma warning disable 0169
        static Delegate GetSearchBusLineAsynHandler()
        {
            if (cb_searchBusLineAsyn == null)
                cb_searchBusLineAsyn = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_SearchBusLineAsyn);
            return cb_searchBusLineAsyn;
        }

        static void n_SearchBusLineAsyn(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Amap.Api.Services.Busline.BusLineSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SearchBusLineAsyn();
        }
#pragma warning restore 0169

        static IntPtr id_searchBusLineAsyn;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusLineSearch']/method[@name='searchBusLineAsyn' and count(parameter)=0]"
        [Register("searchBusLineAsyn", "()V", "GetSearchBusLineAsynHandler")]
        public virtual unsafe void SearchBusLineAsyn()
        {
            if (id_searchBusLineAsyn == IntPtr.Zero)
                id_searchBusLineAsyn = JNIEnv.GetMethodID(class_ref, "searchBusLineAsyn", "()V");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_searchBusLineAsyn);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "searchBusLineAsyn", "()V"));
            }
            finally
            {
            }
        }

        static Delegate cb_setOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_;
#pragma warning disable 0169
        static Delegate GetSetOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_Handler()
        {
            if (cb_setOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_ == null)
                cb_setOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_);
            return cb_setOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_;
        }

        static void n_SetOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Amap.Api.Services.Busline.BusLineSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListener p0 = (global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListener>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.SetOnBusLineSearchListener(p0);
        }
#pragma warning restore 0169

        static IntPtr id_setOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.busline']/class[@name='BusLineSearch']/method[@name='setOnBusLineSearchListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.services.busline.BusLineSearch.OnBusLineSearchListener']]"
        [Register("setOnBusLineSearchListener", "(Lcom/amap/api/services/busline/BusLineSearch$OnBusLineSearchListener;)V", "GetSetOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_Handler")]
        public virtual unsafe void SetOnBusLineSearchListener(global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListener p0)
        {
            if (id_setOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_ == IntPtr.Zero)
                id_setOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_ = JNIEnv.GetMethodID(class_ref, "setOnBusLineSearchListener", "(Lcom/amap/api/services/busline/BusLineSearch$OnBusLineSearchListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnBusLineSearchListener_Lcom_amap_api_services_busline_BusLineSearch_OnBusLineSearchListener_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setOnBusLineSearchListener", "(Lcom/amap/api/services/busline/BusLineSearch$OnBusLineSearchListener;)V"), __args);
            }
            finally
            {
            }
        }

        #region "Event implementation for Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListener"
        public event EventHandler<global::Com.Amap.Api.Services.Busline.BusLineSearch.BusLineSearchEventArgs> BusLineSearchEvent
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListener, global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListenerImplementor>(
                        ref weak_implementor_SetOnBusLineSearchListener,
                        __CreateIOnBusLineSearchListenerImplementor,
                        SetOnBusLineSearchListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListener, global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListenerImplementor>(
                        ref weak_implementor_SetOnBusLineSearchListener,
                        global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListenerImplementor.__IsEmpty,
                        __v => SetOnBusLineSearchListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnBusLineSearchListener;

        global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListenerImplementor __CreateIOnBusLineSearchListenerImplementor()
        {
            return new global::Com.Amap.Api.Services.Busline.BusLineSearch.IOnBusLineSearchListenerImplementor(this);
        }
        #endregion
    }
}
