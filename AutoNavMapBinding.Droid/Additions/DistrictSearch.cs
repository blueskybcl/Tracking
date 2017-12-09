using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amap.Api.Services.District
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.services.district']/class[@name='DistrictSearch']"
    [global::Android.Runtime.Register("com/amap/api/services/district/DistrictSearch", DoNotGenerateAcw = true)]
    public partial class DistrictSearch : global::Java.Lang.Object
    {

        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.services.district']/interface[@name='DistrictSearch.OnDistrictSearchListener']"
        [Register("com/amap/api/services/district/DistrictSearch$OnDistrictSearchListener", "", "Com.Amap.Api.Services.District.DistrictSearch/IOnDistrictSearchListenerInvoker")]
        public partial interface IOnDistrictSearchListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.district']/interface[@name='DistrictSearch.OnDistrictSearchListener']/method[@name='onDistrictSearched' and count(parameter)=1 and parameter[1][@type='com.amap.api.services.district.DistrictResult']]"
            [Register("onDistrictSearched", "(Lcom/amap/api/services/district/DistrictResult;)V", "GetOnDistrictSearched_Lcom_amap_api_services_district_DistrictResult_Handler:Com.Amap.Api.Services.District.DistrictSearch/IOnDistrictSearchListenerInvoker, AutoNavMapBinding.Droid")]
            void OnDistrictSearched(global::Com.Amap.Api.Services.District.DistrictResult p0);

        }

        [global::Android.Runtime.Register("com/amap/api/services/district/DistrictSearch$OnDistrictSearchListener", DoNotGenerateAcw = true)]
        internal class IOnDistrictSearchListenerInvoker : global::Java.Lang.Object, IOnDistrictSearchListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/services/district/DistrictSearch$OnDistrictSearchListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IOnDistrictSearchListenerInvoker); }
            }

            IntPtr class_ref;

            public static IOnDistrictSearchListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnDistrictSearchListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.services.district.DistrictSearch.OnDistrictSearchListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnDistrictSearchListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onDistrictSearched_Lcom_amap_api_services_district_DistrictResult_;
#pragma warning disable 0169
            static Delegate GetOnDistrictSearched_Lcom_amap_api_services_district_DistrictResult_Handler()
            {
                if (cb_onDistrictSearched_Lcom_amap_api_services_district_DistrictResult_ == null)
                    cb_onDistrictSearched_Lcom_amap_api_services_district_DistrictResult_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnDistrictSearched_Lcom_amap_api_services_district_DistrictResult_);
                return cb_onDistrictSearched_Lcom_amap_api_services_district_DistrictResult_;
            }

            static void n_OnDistrictSearched_Lcom_amap_api_services_district_DistrictResult_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Com.Amap.Api.Services.District.DistrictResult p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictResult>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnDistrictSearched(p0);
            }
#pragma warning restore 0169

            IntPtr id_onDistrictSearched_Lcom_amap_api_services_district_DistrictResult_;
            public unsafe void OnDistrictSearched(global::Com.Amap.Api.Services.District.DistrictResult p0)
            {
                if (id_onDistrictSearched_Lcom_amap_api_services_district_DistrictResult_ == IntPtr.Zero)
                    id_onDistrictSearched_Lcom_amap_api_services_district_DistrictResult_ = JNIEnv.GetMethodID(class_ref, "onDistrictSearched", "(Lcom/amap/api/services/district/DistrictResult;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onDistrictSearched_Lcom_amap_api_services_district_DistrictResult_, __args);
            }

        }

        public partial class DistrictSearchEventArgs : global::System.EventArgs
        {

            public DistrictSearchEventArgs(global::Com.Amap.Api.Services.District.DistrictResult p0)
            {
                this.p0 = p0;
            }

            global::Com.Amap.Api.Services.District.DistrictResult p0;
            public global::Com.Amap.Api.Services.District.DistrictResult P0
            {
                get { return p0; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/services/district/DistrictSearch_OnDistrictSearchListenerImplementor")]
        internal sealed partial class IOnDistrictSearchListenerImplementor : global::Java.Lang.Object, IOnDistrictSearchListener
        {

            object sender;

            public IOnDistrictSearchListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/services/district/DistrictSearch_OnDistrictSearchListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<DistrictSearchEventArgs> Handler;
#pragma warning restore 0649

            public void OnDistrictSearched(global::Com.Amap.Api.Services.District.DistrictResult p0)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new DistrictSearchEventArgs(p0));
            }

            internal static bool __IsEmpty(IOnDistrictSearchListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        internal static new IntPtr java_class_handle;
        internal static new IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/amap/api/services/district/DistrictSearch", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(DistrictSearch); }
        }

        protected DistrictSearch(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_ctor_Landroid_content_Context_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.services.district']/class[@name='DistrictSearch']/constructor[@name='DistrictSearch' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
        [Register(".ctor", "(Landroid/content/Context;)V", "")]
        public unsafe DistrictSearch(global::Android.Content.Context p0)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                if (((object)this).GetType() != typeof(DistrictSearch))
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
            global::Com.Amap.Api.Services.District.DistrictSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Query);
        }
#pragma warning restore 0169

        static Delegate cb_setQuery_Lcom_amap_api_services_district_DistrictSearchQuery_;
#pragma warning disable 0169
        static Delegate GetSetQuery_Lcom_amap_api_services_district_DistrictSearchQuery_Handler()
        {
            if (cb_setQuery_Lcom_amap_api_services_district_DistrictSearchQuery_ == null)
                cb_setQuery_Lcom_amap_api_services_district_DistrictSearchQuery_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetQuery_Lcom_amap_api_services_district_DistrictSearchQuery_);
            return cb_setQuery_Lcom_amap_api_services_district_DistrictSearchQuery_;
        }

        static void n_SetQuery_Lcom_amap_api_services_district_DistrictSearchQuery_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Amap.Api.Services.District.DistrictSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Amap.Api.Services.District.DistrictSearchQuery p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearchQuery>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.Query = p0;
        }
#pragma warning restore 0169

        static IntPtr id_getQuery;
        static IntPtr id_setQuery_Lcom_amap_api_services_district_DistrictSearchQuery_;
        public virtual unsafe global::Com.Amap.Api.Services.District.DistrictSearchQuery Query
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.district']/class[@name='DistrictSearch']/method[@name='getQuery' and count(parameter)=0]"
            [Register("getQuery", "()Lcom/amap/api/services/district/DistrictSearchQuery;", "GetGetQueryHandler")]
            get
            {
                if (id_getQuery == IntPtr.Zero)
                    id_getQuery = JNIEnv.GetMethodID(class_ref, "getQuery", "()Lcom/amap/api/services/district/DistrictSearchQuery;");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearchQuery>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
                    else
                        return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearchQuery>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getQuery", "()Lcom/amap/api/services/district/DistrictSearchQuery;")), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.district']/class[@name='DistrictSearch']/method[@name='setQuery' and count(parameter)=1 and parameter[1][@type='com.amap.api.services.district.DistrictSearchQuery']]"
            [Register("setQuery", "(Lcom/amap/api/services/district/DistrictSearchQuery;)V", "GetSetQuery_Lcom_amap_api_services_district_DistrictSearchQuery_Handler")]
            set
            {
                if (id_setQuery_Lcom_amap_api_services_district_DistrictSearchQuery_ == IntPtr.Zero)
                    id_setQuery_Lcom_amap_api_services_district_DistrictSearchQuery_ = JNIEnv.GetMethodID(class_ref, "setQuery", "(Lcom/amap/api/services/district/DistrictSearchQuery;)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setQuery_Lcom_amap_api_services_district_DistrictSearchQuery_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setQuery", "(Lcom/amap/api/services/district/DistrictSearchQuery;)V"), __args);
                }
                finally
                {
                }
            }
        }

        static Delegate cb_searchDistrict;
#pragma warning disable 0169
        static Delegate GetSearchDistrictHandler()
        {
            if (cb_searchDistrict == null)
                cb_searchDistrict = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_SearchDistrict);
            return cb_searchDistrict;
        }

        static IntPtr n_SearchDistrict(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Amap.Api.Services.District.DistrictSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.SearchDistrict());
        }
#pragma warning restore 0169

        static IntPtr id_searchDistrict;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.district']/class[@name='DistrictSearch']/method[@name='searchDistrict' and count(parameter)=0]"
        [Register("searchDistrict", "()Lcom/amap/api/services/district/DistrictResult;", "GetSearchDistrictHandler")]
        public virtual unsafe global::Com.Amap.Api.Services.District.DistrictResult SearchDistrict()
        {
            if (id_searchDistrict == IntPtr.Zero)
                id_searchDistrict = JNIEnv.GetMethodID(class_ref, "searchDistrict", "()Lcom/amap/api/services/district/DistrictResult;");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictResult>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_searchDistrict), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictResult>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "searchDistrict", "()Lcom/amap/api/services/district/DistrictResult;")), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_searchDistrictAnsy;
#pragma warning disable 0169
        static Delegate GetSearchDistrictAnsyHandler()
        {
            if (cb_searchDistrictAnsy == null)
                cb_searchDistrictAnsy = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_SearchDistrictAnsy);
            return cb_searchDistrictAnsy;
        }

        static void n_SearchDistrictAnsy(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Amap.Api.Services.District.DistrictSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SearchDistrictAnsy();
        }
#pragma warning restore 0169

        static IntPtr id_searchDistrictAnsy;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.district']/class[@name='DistrictSearch']/method[@name='searchDistrictAnsy' and count(parameter)=0]"
        [Register("searchDistrictAnsy", "()V", "GetSearchDistrictAnsyHandler")]
        public virtual unsafe void SearchDistrictAnsy()
        {
            if (id_searchDistrictAnsy == IntPtr.Zero)
                id_searchDistrictAnsy = JNIEnv.GetMethodID(class_ref, "searchDistrictAnsy", "()V");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_searchDistrictAnsy);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "searchDistrictAnsy", "()V"));
            }
            finally
            {
            }
        }

        static Delegate cb_searchDistrictAsyn;
#pragma warning disable 0169
        static Delegate GetSearchDistrictAsynHandler()
        {
            if (cb_searchDistrictAsyn == null)
                cb_searchDistrictAsyn = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_SearchDistrictAsyn);
            return cb_searchDistrictAsyn;
        }

        static void n_SearchDistrictAsyn(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Amap.Api.Services.District.DistrictSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SearchDistrictAsyn();
        }
#pragma warning restore 0169

        static IntPtr id_searchDistrictAsyn;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.district']/class[@name='DistrictSearch']/method[@name='searchDistrictAsyn' and count(parameter)=0]"
        [Register("searchDistrictAsyn", "()V", "GetSearchDistrictAsynHandler")]
        public virtual unsafe void SearchDistrictAsyn()
        {
            if (id_searchDistrictAsyn == IntPtr.Zero)
                id_searchDistrictAsyn = JNIEnv.GetMethodID(class_ref, "searchDistrictAsyn", "()V");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_searchDistrictAsyn);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "searchDistrictAsyn", "()V"));
            }
            finally
            {
            }
        }

        static Delegate cb_setOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_;
#pragma warning disable 0169
        static Delegate GetSetOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_Handler()
        {
            if (cb_setOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_ == null)
                cb_setOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_);
            return cb_setOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_;
        }

        static void n_SetOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Amap.Api.Services.District.DistrictSearch __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearch>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListener p0 = (global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListener>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.SetOnDistrictSearchListener(p0);
        }
#pragma warning restore 0169

        static IntPtr id_setOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.district']/class[@name='DistrictSearch']/method[@name='setOnDistrictSearchListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.services.district.DistrictSearch.OnDistrictSearchListener']]"
        [Register("setOnDistrictSearchListener", "(Lcom/amap/api/services/district/DistrictSearch$OnDistrictSearchListener;)V", "GetSetOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_Handler")]
        public virtual unsafe void SetOnDistrictSearchListener(global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListener p0)
        {
            if (id_setOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_ == IntPtr.Zero)
                id_setOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_ = JNIEnv.GetMethodID(class_ref, "setOnDistrictSearchListener", "(Lcom/amap/api/services/district/DistrictSearch$OnDistrictSearchListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOnDistrictSearchListener_Lcom_amap_api_services_district_DistrictSearch_OnDistrictSearchListener_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setOnDistrictSearchListener", "(Lcom/amap/api/services/district/DistrictSearch$OnDistrictSearchListener;)V"), __args);
            }
            finally
            {
            }
        }

        #region "Event implementation for Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListener"
        public event EventHandler<global::Com.Amap.Api.Services.District.DistrictSearch.DistrictSearchEventArgs> DistrictSearchEvent
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListener, global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListenerImplementor>(
                        ref weak_implementor_SetOnDistrictSearchListener,
                        __CreateIOnDistrictSearchListenerImplementor,
                        SetOnDistrictSearchListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListener, global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListenerImplementor>(
                        ref weak_implementor_SetOnDistrictSearchListener,
                        global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListenerImplementor.__IsEmpty,
                        __v => SetOnDistrictSearchListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetOnDistrictSearchListener;

        global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListenerImplementor __CreateIOnDistrictSearchListenerImplementor()
        {
            return new global::Com.Amap.Api.Services.District.DistrictSearch.IOnDistrictSearchListenerImplementor(this);
        }
        #endregion
    }
}
