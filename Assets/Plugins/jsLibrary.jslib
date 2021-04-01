mergeInto(LibraryManager.library, {
  sendStringFromUnity: function(utf8String) {
    var jsString = UTF8ToString(utf8String);
    useStringFromUnity(jsString);
  }
  sendValueFromUnity: function(utf8StringTwo){
    var unityFloat = UTF*ToString(utf8StringTwo);
    useValueFromUnity(unityFloat)
  }
});
