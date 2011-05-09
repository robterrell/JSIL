﻿using System;
using JSIL.Meta;

namespace JSIL.Proxies {
    [JSProxy(
        typeof(Object),
        JSProxyMemberPolicy.ReplaceNone
    )]
    public abstract class ObjectProxy {
        [JSReplacement("JSIL.GetType($this)")]
        new abstract public Type GetType ();

        [JSChangeName("toString")]
        new abstract public string ToString ();
    }
}