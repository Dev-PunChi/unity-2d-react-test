mergeInto(LibraryManager.library, {
  CallReact: function (userName, score) {
    window.dispatchReactUnityEvent(
      "CallReact",
      Pointer_stringify(userName),
      score
    );
  },
});