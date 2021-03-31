mergeInto(LibraryManager.library, {
  sendStringFromUnity: function(utf8String) {
    var jsString = UTF8ToString(utf8String);
    useStringFromUnity(jsString);
  }
});
