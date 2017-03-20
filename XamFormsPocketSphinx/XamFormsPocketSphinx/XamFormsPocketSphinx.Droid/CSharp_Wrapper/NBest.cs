//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

using SphinxBase;

namespace PocketSphinx {

public class NBest : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NBest(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NBest obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NBest() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PocketSphinxPINVOKE.delete_NBest(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string Hypstr {
    set {
      PocketSphinxPINVOKE.NBest_Hypstr_set(swigCPtr, value);
    } 
    get {
      string ret = PocketSphinxPINVOKE.NBest_Hypstr_get(swigCPtr);
      return ret;
    } 
  }

  public int Score {
    set {
      PocketSphinxPINVOKE.NBest_Score_set(swigCPtr, value);
    } 
    get {
      int ret = PocketSphinxPINVOKE.NBest_Score_get(swigCPtr);
      return ret;
    } 
  }

  public static NBest FromIter(SWIGTYPE_p_void itor) {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.NBest_FromIter(SWIGTYPE_p_void.getCPtr(itor));
    NBest ret = (cPtr == global::System.IntPtr.Zero) ? null : new NBest(cPtr, false);
    return ret;
  }

  public Hypothesis Hyp() {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.NBest_Hyp(swigCPtr);
    Hypothesis ret = (cPtr == global::System.IntPtr.Zero) ? null : new Hypothesis(cPtr, true);
    return ret;
  }

  public NBest() : this(PocketSphinxPINVOKE.new_NBest(), true) {
  }

}

}