using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Autonavi.AE.Search
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']"
    [Register("com/autonavi/ae/search/NativeSearchEngine", DoNotGenerateAcw = true)]
    public class NativeSearchEngine : global::Java.Lang.Object
    {


        // Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/field[@name='GSEARCH_TYPE_AROUND']"
        [Register("GSEARCH_TYPE_AROUND")]
        public const int GsearchTypeAround = (int)3;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/field[@name='GSEARCH_TYPE_FTS']"
        [Register("GSEARCH_TYPE_FTS")]
        public const int GsearchTypeFts = (int)8;
        // Metadata.xml XPath class reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine.GSearchForm']"
        [global::Android.Runtime.Register("com/autonavi/ae/search/NativeSearchEngine$GSearchForm", DoNotGenerateAcw = true)]
        public partial class GSearchForm : global::Java.Lang.Object
        {


            // Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine.GSearchForm']/field[@name='GSEARCH_FORM_FINAL']"
            [Register("GSEARCH_FORM_FINAL")]
            public const int GsearchFormFinal = (int)2;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine.GSearchForm']/field[@name='GSEARCH_FORM_MAX']"
            [Register("GSEARCH_FORM_MAX")]
            public const int GsearchFormMax = (int)3;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine.GSearchForm']/field[@name='GSEARCH_FORM_NONE']"
            [Register("GSEARCH_FORM_NONE")]
            public const int GsearchFormNone = (int)0;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine.GSearchForm']/field[@name='GSEARCH_FORM_PRE']"
            [Register("GSEARCH_FORM_PRE")]
            public const int GsearchFormPre = (int)1;
            internal static new IntPtr java_class_handle;
            internal static new IntPtr class_ref
            {
                get
                {
                    return JNIEnv.FindClass("com/autonavi/ae/search/NativeSearchEngine$GSearchForm", ref java_class_handle);
                }
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(GSearchForm); }
            }

            protected GSearchForm(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            static IntPtr id_ctor_Lcom_autonavi_ae_search_NativeSearchEngine_;
            // Metadata.xml XPath constructor reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine.GSearchForm']/constructor[@name='NativeSearchEngine.GSearchForm' and count(parameter)=1 and parameter[1][@type='com.autonavi.ae.search.NativeSearchEngine']]"
            [Register(".ctor", "(Lcom/autonavi/ae/search/NativeSearchEngine;)V", "")]
            public unsafe GSearchForm(global::Com.Autonavi.AE.Search.NativeSearchEngine __self)
                : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
            {
                if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                    return;

                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(__self);
                    if (((object)this).GetType() != typeof(GSearchForm))
                    {
                        SetHandle(
                                global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(L" + global::Android.Runtime.JNIEnv.GetJniName(GetType().DeclaringType) + ";)V", __args),
                                JniHandleOwnership.TransferLocalRef);
                        global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName(GetType().DeclaringType) + ";)V", __args);
                        return;
                    }

                    if (id_ctor_Lcom_autonavi_ae_search_NativeSearchEngine_ == IntPtr.Zero)
                        id_ctor_Lcom_autonavi_ae_search_NativeSearchEngine_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Lcom/autonavi/ae/search/NativeSearchEngine;)V");
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Lcom_autonavi_ae_search_NativeSearchEngine_, __args),
                            JniHandleOwnership.TransferLocalRef);
                    JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor_Lcom_autonavi_ae_search_NativeSearchEngine_, __args);
                }
                finally
                {
                }
            }

        }

        internal static new IntPtr java_class_handle;
        internal static new IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/autonavi/ae/search/NativeSearchEngine", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(NativeSearchEngine); }
        }

        protected NativeSearchEngine(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_nativeAbortSearch;
#pragma warning disable 0169
        static Delegate GetNativeAbortSearchHandler()
        {
            if (cb_nativeAbortSearch == null)
                cb_nativeAbortSearch = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_NativeAbortSearch);
            return cb_nativeAbortSearch;
        }

        static int n_NativeAbortSearch(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.NativeAbortSearch();
        }
#pragma warning restore 0169

        static IntPtr id_nativeAbortSearch;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeAbortSearch' and count(parameter)=0]"
        [Register("nativeAbortSearch", "()I", "GetNativeAbortSearchHandler")]
        protected virtual unsafe int NativeAbortSearch()
        {
            if (id_nativeAbortSearch == IntPtr.Zero)
                id_nativeAbortSearch = JNIEnv.GetMethodID(class_ref, "nativeAbortSearch", "()I");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeAbortSearch);
                else
                    return JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeAbortSearch", "()I"));
            }
            finally
            {
            }
        }

        static Delegate cb_nativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_;
#pragma warning disable 0169
        static Delegate GetNativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_Handler()
        {
            if (cb_nativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_ == null)
                cb_nativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int>)n_NativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_);
            return cb_nativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_;
        }

        static int n_NativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Autonavi.AE.Search.INativeSearchObserver p0 = (global::Com.Autonavi.AE.Search.INativeSearchObserver)global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.INativeSearchObserver>(native_p0, JniHandleOwnership.DoNotTransfer);
            int __ret = __this.NativeAddSearchObserver(p0);
            return __ret;
        }
#pragma warning restore 0169

        static IntPtr id_nativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeAddSearchObserver' and count(parameter)=1 and parameter[1][@type='com.autonavi.ae.search.INativeSearchObserver']]"
        [Register("nativeAddSearchObserver", "(Lcom/autonavi/ae/search/INativeSearchObserver;)I", "GetNativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_Handler")]
        protected virtual unsafe int NativeAddSearchObserver(global::Com.Autonavi.AE.Search.INativeSearchObserver p0)
        {
            if (id_nativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_ == IntPtr.Zero)
                id_nativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_ = JNIEnv.GetMethodID(class_ref, "nativeAddSearchObserver", "(Lcom/autonavi/ae/search/INativeSearchObserver;)I");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                int __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeAddSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_, __args);
                else
                    __ret = JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeAddSearchObserver", "(Lcom/autonavi/ae/search/INativeSearchObserver;)I"), __args);
                return __ret;
            }
            finally
            {
            }
        }

        static Delegate cb_nativeCreateSearcher;
#pragma warning disable 0169
        static Delegate GetNativeCreateSearcherHandler()
        {
            if (cb_nativeCreateSearcher == null)
                cb_nativeCreateSearcher = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_NativeCreateSearcher);
            return cb_nativeCreateSearcher;
        }

        static int n_NativeCreateSearcher(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.NativeCreateSearcher();
        }
#pragma warning restore 0169

        static IntPtr id_nativeCreateSearcher;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeCreateSearcher' and count(parameter)=0]"
        [Register("nativeCreateSearcher", "()I", "GetNativeCreateSearcherHandler")]
        protected virtual unsafe int NativeCreateSearcher()
        {
            if (id_nativeCreateSearcher == IntPtr.Zero)
                id_nativeCreateSearcher = JNIEnv.GetMethodID(class_ref, "nativeCreateSearcher", "()I");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeCreateSearcher);
                else
                    return JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeCreateSearcher", "()I"));
            }
            finally
            {
            }
        }

        static Delegate cb_nativeDestroy;
#pragma warning disable 0169
        static Delegate GetNativeDestroyHandler()
        {
            if (cb_nativeDestroy == null)
                cb_nativeDestroy = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_NativeDestroy);
            return cb_nativeDestroy;
        }

        static int n_NativeDestroy(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.NativeDestroy();
        }
#pragma warning restore 0169

        static IntPtr id_nativeDestroy;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeDestroy' and count(parameter)=0]"
        [Register("nativeDestroy", "()I", "GetNativeDestroyHandler")]
        protected virtual unsafe int NativeDestroy()
        {
            if (id_nativeDestroy == IntPtr.Zero)
                id_nativeDestroy = JNIEnv.GetMethodID(class_ref, "nativeDestroy", "()I");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeDestroy);
                else
                    return JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeDestroy", "()I"));
            }
            finally
            {
            }
        }

        static Delegate cb_nativeGetPoiCategoryList_I;
#pragma warning disable 0169
        static Delegate GetNativeGetPoiCategoryList_IHandler()
        {
            if (cb_nativeGetPoiCategoryList_I == null)
                cb_nativeGetPoiCategoryList_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int>)n_NativeGetPoiCategoryList_I);
            return cb_nativeGetPoiCategoryList_I;
        }

        static int n_NativeGetPoiCategoryList_I(IntPtr jnienv, IntPtr native__this, int p0)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.NativeGetPoiCategoryList(p0);
        }
#pragma warning restore 0169

        static IntPtr id_nativeGetPoiCategoryList_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeGetPoiCategoryList' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("nativeGetPoiCategoryList", "(I)I", "GetNativeGetPoiCategoryList_IHandler")]
        protected virtual unsafe int NativeGetPoiCategoryList(int p0)
        {
            if (id_nativeGetPoiCategoryList_I == IntPtr.Zero)
                id_nativeGetPoiCategoryList_I = JNIEnv.GetMethodID(class_ref, "nativeGetPoiCategoryList", "(I)I");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (((object)this).GetType() == ThresholdType)
                    return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeGetPoiCategoryList_I, __args);
                else
                    return JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeGetPoiCategoryList", "(I)I"), __args);
            }
            finally
            {
            }
        }

        static Delegate cb_nativeGetPoiParam_I;
#pragma warning disable 0169
        static Delegate GetNativeGetPoiParam_IHandler()
        {
            if (cb_nativeGetPoiParam_I == null)
                cb_nativeGetPoiParam_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int>)n_NativeGetPoiParam_I);
            return cb_nativeGetPoiParam_I;
        }

        static int n_NativeGetPoiParam_I(IntPtr jnienv, IntPtr native__this, int p0)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.NativeGetPoiParam(p0);
        }
#pragma warning restore 0169

        static IntPtr id_nativeGetPoiParam_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeGetPoiParam' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("nativeGetPoiParam", "(I)I", "GetNativeGetPoiParam_IHandler")]
        protected virtual unsafe int NativeGetPoiParam(int p0)
        {
            if (id_nativeGetPoiParam_I == IntPtr.Zero)
                id_nativeGetPoiParam_I = JNIEnv.GetMethodID(class_ref, "nativeGetPoiParam", "(I)I");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (((object)this).GetType() == ThresholdType)
                    return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeGetPoiParam_I, __args);
                else
                    return JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeGetPoiParam", "(I)I"), __args);
            }
            finally
            {
            }
        }

        static Delegate cb_nativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II;
#pragma warning disable 0169
        static Delegate GetNativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIHandler()
        {
            if (cb_nativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II == null)
                cb_nativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int>)n_NativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II);
            return cb_nativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II;
        }

        static int n_NativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, int p5)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            string p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
            string p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
            string p2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
            string p3 = JNIEnv.GetString(native_p3, JniHandleOwnership.DoNotTransfer);
            int __ret = __this.NativeInit(p0, p1, p2, p3, p4, p5);
            return __ret;
        }
#pragma warning restore 0169

        static IntPtr id_nativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeInit' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
        [Register("nativeInit", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)I", "GetNativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIHandler")]
        protected virtual unsafe int NativeInit(string p0, string p1, string p2, string p3, int p4, int p5)
        {
            if (id_nativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
                id_nativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetMethodID(class_ref, "nativeInit", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)I");
            IntPtr native_p0 = JNIEnv.NewString(p0);
            IntPtr native_p1 = JNIEnv.NewString(p1);
            IntPtr native_p2 = JNIEnv.NewString(p2);
            IntPtr native_p3 = JNIEnv.NewString(p3);
            try
            {
                JValue* __args = stackalloc JValue[6];
                __args[0] = new JValue(native_p0);
                __args[1] = new JValue(native_p1);
                __args[2] = new JValue(native_p2);
                __args[3] = new JValue(native_p3);
                __args[4] = new JValue(p4);
                __args[5] = new JValue(p5);

                int __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeInit_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_II, __args);
                else
                    __ret = JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeInit", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)I"), __args);
                return __ret;
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
                JNIEnv.DeleteLocalRef(native_p1);
                JNIEnv.DeleteLocalRef(native_p2);
                JNIEnv.DeleteLocalRef(native_p3);
            }
        }

        static Delegate cb_nativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_;
#pragma warning disable 0169
        static Delegate GetNativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_Handler()
        {
            if (cb_nativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_ == null)
                cb_nativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int>)n_NativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_);
            return cb_nativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_;
        }

        static int n_NativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Autonavi.AE.Search.INativeSearchObserver p0 = (global::Com.Autonavi.AE.Search.INativeSearchObserver)global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.INativeSearchObserver>(native_p0, JniHandleOwnership.DoNotTransfer);
            int __ret = __this.NativeRemoveSearchObserver(p0);
            return __ret;
        }
#pragma warning restore 0169

        static IntPtr id_nativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeRemoveSearchObserver' and count(parameter)=1 and parameter[1][@type='com.autonavi.ae.search.INativeSearchObserver']]"
        [Register("nativeRemoveSearchObserver", "(Lcom/autonavi/ae/search/INativeSearchObserver;)I", "GetNativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_Handler")]
        protected virtual unsafe int NativeRemoveSearchObserver(global::Com.Autonavi.AE.Search.INativeSearchObserver p0)
        {
            if (id_nativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_ == IntPtr.Zero)
                id_nativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_ = JNIEnv.GetMethodID(class_ref, "nativeRemoveSearchObserver", "(Lcom/autonavi/ae/search/INativeSearchObserver;)I");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                int __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeRemoveSearchObserver_Lcom_autonavi_ae_search_INativeSearchObserver_, __args);
                else
                    __ret = JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeRemoveSearchObserver", "(Lcom/autonavi/ae/search/INativeSearchObserver;)I"), __args);
                return __ret;
            }
            finally
            {
            }
        }

        static Delegate cb_nativeSearchAdareaInfo_ILjava_lang_String_;
#pragma warning disable 0169
        static Delegate GetNativeSearchAdareaInfo_ILjava_lang_String_Handler()
        {
            if (cb_nativeSearchAdareaInfo_ILjava_lang_String_ == null)
                cb_nativeSearchAdareaInfo_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr, int>)n_NativeSearchAdareaInfo_ILjava_lang_String_);
            return cb_nativeSearchAdareaInfo_ILjava_lang_String_;
        }

        static int n_NativeSearchAdareaInfo_ILjava_lang_String_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            string p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
            int __ret = __this.NativeSearchAdareaInfo(p0, p1);
            return __ret;
        }
#pragma warning restore 0169

        static IntPtr id_nativeSearchAdareaInfo_ILjava_lang_String_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeSearchAdareaInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
        [Register("nativeSearchAdareaInfo", "(ILjava/lang/String;)I", "GetNativeSearchAdareaInfo_ILjava_lang_String_Handler")]
        protected virtual unsafe int NativeSearchAdareaInfo(int p0, string p1)
        {
            if (id_nativeSearchAdareaInfo_ILjava_lang_String_ == IntPtr.Zero)
                id_nativeSearchAdareaInfo_ILjava_lang_String_ = JNIEnv.GetMethodID(class_ref, "nativeSearchAdareaInfo", "(ILjava/lang/String;)I");
            IntPtr native_p1 = JNIEnv.NewString(p1);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(native_p1);

                int __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeSearchAdareaInfo_ILjava_lang_String_, __args);
                else
                    __ret = JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeSearchAdareaInfo", "(ILjava/lang/String;)I"), __args);
                return __ret;
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p1);
            }
        }

        static Delegate cb_nativeSetMccPath_Ljava_lang_String_I;
#pragma warning disable 0169
        static Delegate GetNativeSetMccPath_Ljava_lang_String_IHandler()
        {
            if (cb_nativeSetMccPath_Ljava_lang_String_I == null)
                cb_nativeSetMccPath_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int, int>)n_NativeSetMccPath_Ljava_lang_String_I);
            return cb_nativeSetMccPath_Ljava_lang_String_I;
        }

        static int n_NativeSetMccPath_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            string p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
            int __ret = __this.NativeSetMccPath(p0, p1);
            return __ret;
        }
#pragma warning restore 0169

        static IntPtr id_nativeSetMccPath_Ljava_lang_String_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeSetMccPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
        [Register("nativeSetMccPath", "(Ljava/lang/String;I)I", "GetNativeSetMccPath_Ljava_lang_String_IHandler")]
        protected virtual unsafe int NativeSetMccPath(string p0, int p1)
        {
            if (id_nativeSetMccPath_Ljava_lang_String_I == IntPtr.Zero)
                id_nativeSetMccPath_Ljava_lang_String_I = JNIEnv.GetMethodID(class_ref, "nativeSetMccPath", "(Ljava/lang/String;I)I");
            IntPtr native_p0 = JNIEnv.NewString(p0);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(native_p0);
                __args[1] = new JValue(p1);

                int __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeSetMccPath_Ljava_lang_String_I, __args);
                else
                    __ret = JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeSetMccPath", "(Ljava/lang/String;I)I"), __args);
                return __ret;
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
            }
        }

        static Delegate cb_nativeSetPoiParam_II;
#pragma warning disable 0169
        static Delegate GetNativeSetPoiParam_IIHandler()
        {
            if (cb_nativeSetPoiParam_II == null)
                cb_nativeSetPoiParam_II = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int, int>)n_NativeSetPoiParam_II);
            return cb_nativeSetPoiParam_II;
        }

        static int n_NativeSetPoiParam_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.NativeSetPoiParam(p0, p1);
        }
#pragma warning restore 0169

        static IntPtr id_nativeSetPoiParam_II;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeSetPoiParam' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
        [Register("nativeSetPoiParam", "(II)I", "GetNativeSetPoiParam_IIHandler")]
        protected virtual unsafe int NativeSetPoiParam(int p0, int p1)
        {
            if (id_nativeSetPoiParam_II == IntPtr.Zero)
                id_nativeSetPoiParam_II = JNIEnv.GetMethodID(class_ref, "nativeSetPoiParam", "(II)I");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);

                if (((object)this).GetType() == ThresholdType)
                    return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_nativeSetPoiParam_II, __args);
                else
                    return JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeSetPoiParam", "(II)I"), __args);
            }
            finally
            {
            }
        }

        static Delegate cb_nativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_;
#pragma warning disable 0169
        static Delegate GetNativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_Handler()
        {
            if (cb_nativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_ == null)
                cb_nativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int, IntPtr, int, float, float, int, int, int, int, IntPtr, IntPtr>)n_NativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_);
            return cb_nativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_;
        }

        static IntPtr n_NativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_(IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3, float p4, float p5, int p6, int p7, int p8, int p9, IntPtr native_p10)
        {
            global::Com.Autonavi.AE.Search.NativeSearchEngine __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.NativeSearchEngine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            string p2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
            global::Com.Autonavi.AE.Search.Model.GObjectID[] p10 = (global::Com.Autonavi.AE.Search.Model.GObjectID[])JNIEnv.GetArray(native_p10, JniHandleOwnership.DoNotTransfer, typeof(global::Com.Autonavi.AE.Search.Model.GObjectID));
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.NativeStartSearch(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
            if (p10 != null)
                JNIEnv.CopyArray(p10, native_p10);
            return __ret;
        }
#pragma warning restore 0169

        static IntPtr id_nativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.ae.search']/class[@name='NativeSearchEngine']/method[@name='nativeStartSearch' and count(parameter)=11 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='com.autonavi.ae.search.model.GObjectID[]']]"
        [Register("nativeStartSearch", "(IILjava/lang/String;IFFIIII[Lcom/autonavi/ae/search/model/GObjectID;)Lcom/autonavi/ae/search/model/SearchStatus;", "GetNativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_Handler")]
        protected virtual unsafe global::Com.Autonavi.AE.Search.Model.SearchStatus NativeStartSearch(int p0, int p1, string p2, int p3, float p4, float p5, int p6, int p7, int p8, int p9, global::Com.Autonavi.AE.Search.Model.GObjectID[] p10)
        {
            if (id_nativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_ == IntPtr.Zero)
                id_nativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_ = JNIEnv.GetMethodID(class_ref, "nativeStartSearch", "(IILjava/lang/String;IFFIIII[Lcom/autonavi/ae/search/model/GObjectID;)Lcom/autonavi/ae/search/model/SearchStatus;");
            IntPtr native_p2 = JNIEnv.NewString(p2);
            IntPtr native_p10 = JNIEnv.NewArray(p10);
            try
            {
                JValue* __args = stackalloc JValue[11];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(native_p2);
                __args[3] = new JValue(p3);
                __args[4] = new JValue(p4);
                __args[5] = new JValue(p5);
                __args[6] = new JValue(p6);
                __args[7] = new JValue(p7);
                __args[8] = new JValue(p8);
                __args[9] = new JValue(p9);
                __args[10] = new JValue(native_p10);

                global::Com.Autonavi.AE.Search.Model.SearchStatus __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.Model.SearchStatus>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_nativeStartSearch_IILjava_lang_String_IFFIIIIarrayLcom_autonavi_ae_search_model_GObjectID_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<global::Com.Autonavi.AE.Search.Model.SearchStatus>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "nativeStartSearch", "(IILjava/lang/String;IFFIIII[Lcom/autonavi/ae/search/model/GObjectID;)Lcom/autonavi/ae/search/model/SearchStatus;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p2);
                if (p10 != null)
                {
                    JNIEnv.CopyArray(native_p10, p10);
                    JNIEnv.DeleteLocalRef(native_p10);
                }
            }
        }

    }
}
