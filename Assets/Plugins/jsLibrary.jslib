mergeInto(LibraryManager.library, {
  sendStringFromUnity: function(utf8String) {
    var jsString = UTF8ToString(utf8String);
    useStringFromUnity(jsString);
  },
  sendValueFromUnity: function(utf8String) {
    var unityFloat = UTF8ToString(utf8String);
    useValueFromUnity(unityFloat);
  },
  pickSampleFromUnity: function(x) {
    useSampleFromUnity(x);
  },
  setParamWithFloat: function(paramName, value) {
    var param = UTF8ToString(paramName);
    updateParamWithFloat(param, value);
  },
  setIndexFromUnity: function(arrayName, index) {
    var array = UTF8ToString(arrayName);
    getIndexFromUnity(array, index);
  },
});
