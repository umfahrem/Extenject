using System;
using System.Collections.Generic;
#if !NOT_UNITY3D
using JetBrains.Annotations;
#endif

namespace Zenject
{
    // Zero parameters
    public class PlaceholderFactory<TValue> : PlaceholderFactoryBase<TValue>, IFactory<TValue>
    {
        private List<TypeValuePair> m_List = new List<TypeValuePair>(0);
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create()
        {
            return CreateInternal(m_List);
        }

        protected sealed override IEnumerable<Type> ParamTypes
        {
            get { yield break; }
        }
    }

    [Obsolete("Zenject.Factory has been renamed to PlaceholderFactory.  Zenject.Factory will be removed in future versions")]
    public class Factory<TValue> : PlaceholderFactory<TValue>
    {
    }

    // One parameter
    public class PlaceholderFactory<TParam1, TValue>
        : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TValue>
    {
        private List<TypeValuePair> m_List = new List<TypeValuePair>(1)
        {
            InjectUtil.CreateTypePair(0)
        };
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param)
        {
            m_List[0] = InjectUtil.CreateTypePair(param);
            return CreateInternal(m_List);
        }

        protected sealed override IEnumerable<Type> ParamTypes
        {
            get { yield return typeof(TParam1); }
        }
    }

    [Obsolete("Zenject.Factory has been renamed to PlaceholderFactory.  Zenject.Factory will be removed in future versions")]
    public class Factory<TParam1, TValue> : PlaceholderFactory<TParam1, TValue>
    {
    }

    // Two parameters
    public class PlaceholderFactory<TParam1, TParam2, TValue>
        : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TValue>
    {
        private List<TypeValuePair> m_List = new List<TypeValuePair>(2)
        {
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0)
        };
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2)
        {
            m_List[0] = InjectUtil.CreateTypePair(param1);
            m_List[1] = InjectUtil.CreateTypePair(param2);
            return CreateInternal(m_List);
        }

        protected sealed override IEnumerable<Type> ParamTypes
        {
            get
            {
                yield return typeof(TParam1);
                yield return typeof(TParam2);
            }
        }
    }

    [Obsolete("Zenject.Factory has been renamed to PlaceholderFactory.  Zenject.Factory will be removed in future versions")]
    public class Factory<TParam1, TParam2, TValue> : PlaceholderFactory<TParam1, TParam2, TValue>
    {
    }

    // Three parameters
    public class PlaceholderFactory<TParam1, TParam2, TParam3, TValue>
        : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TValue>
    {
        private List<TypeValuePair> m_List = new List<TypeValuePair>(3)
        {
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0)
        };
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3)
        {
            m_List[0] = InjectUtil.CreateTypePair(param1);
            m_List[1] = InjectUtil.CreateTypePair(param2);
            m_List[2] = InjectUtil.CreateTypePair(param3);
            return CreateInternal(m_List);
        }

        protected sealed override IEnumerable<Type> ParamTypes
        {
            get
            {
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
            }
        }
    }

    [Obsolete("Zenject.Factory has been renamed to PlaceholderFactory.  Zenject.Factory will be removed in future versions")]
    public class Factory<TParam1, TParam2, TParam3, TValue> : PlaceholderFactory<TParam1, TParam2, TParam3, TValue>
    {
    }

    // Four parameters
    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TValue>
        : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TValue>
    {
        private List<TypeValuePair> m_List = new List<TypeValuePair>(4)
        {
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0)
        };
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
        {
            m_List[0] = InjectUtil.CreateTypePair(param1);
            m_List[1] = InjectUtil.CreateTypePair(param2);
            m_List[2] = InjectUtil.CreateTypePair(param3);
            m_List[3] = InjectUtil.CreateTypePair(param4);
            return CreateInternal(m_List);
        }

        protected sealed override IEnumerable<Type> ParamTypes
        {
            get
            {
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
            }
        }
    }

    [Obsolete("Zenject.Factory has been renamed to PlaceholderFactory.  Zenject.Factory will be removed in future versions")]
    public class Factory<TParam1, TParam2, TParam3, TParam4, TValue>
        : PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TValue>
    {
    }

    // Five parameters
    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
        : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
    {
        private List<TypeValuePair> m_List = new List<TypeValuePair>(5)
        {
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0)
        };
    // Note: Most of the time you should not override this method and should instead
    // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
    [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
        {
            m_List[0] = InjectUtil.CreateTypePair(param1);
            m_List[1] = InjectUtil.CreateTypePair(param2);
            m_List[2] = InjectUtil.CreateTypePair(param3);
            m_List[3] = InjectUtil.CreateTypePair(param4);
            m_List[4] = InjectUtil.CreateTypePair(param5);
            return CreateInternal(m_List);
        }

        protected sealed override IEnumerable<Type> ParamTypes
        {
            get
            {
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
                yield return typeof(TParam5);
            }
        }
    }

    [Obsolete("Zenject.Factory has been renamed to PlaceholderFactory.  Zenject.Factory will be removed in future versions")]
    public class Factory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
        : PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
    {
    }

    // Six parameters
    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>
        : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>
    {
        private List<TypeValuePair> m_List = new List<TypeValuePair>(6)
        {
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0)
        };
        // Note: Most of the time you should not override this method and should instead
        // use BindFactory<>.FromIFactory if you want to do some custom logic
#if !NOT_UNITY3D
        [NotNull]
#endif
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6)
        {
            m_List[0] = InjectUtil.CreateTypePair(param1);
            m_List[1] = InjectUtil.CreateTypePair(param2);
            m_List[2] = InjectUtil.CreateTypePair(param3);
            m_List[3] = InjectUtil.CreateTypePair(param4);
            m_List[4] = InjectUtil.CreateTypePair(param5);
            m_List[5] = InjectUtil.CreateTypePair(param6);
            return CreateInternal(m_List);
        }

        protected sealed override IEnumerable<Type> ParamTypes
        {
            get
            {
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
                yield return typeof(TParam5);
                yield return typeof(TParam6);
            }
        }
    }

    [Obsolete("Zenject.Factory has been renamed to PlaceholderFactory.  Zenject.Factory will be removed in future versions")]
    public class Factory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>
        : PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TValue>
    {
    }

    // Ten parameters
    public class PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>
        : PlaceholderFactoryBase<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>
    {
        private List<TypeValuePair> m_List = new List<TypeValuePair>(10)
        {
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0),
            InjectUtil.CreateTypePair(0)
        };
        // If you were hoping to override this method, use BindFactory<>.ToFactory instead
        public virtual TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10)
        {
            m_List[0] = InjectUtil.CreateTypePair(param1);
            m_List[1] = InjectUtil.CreateTypePair(param2);
            m_List[2] = InjectUtil.CreateTypePair(param3);
            m_List[3] = InjectUtil.CreateTypePair(param4);
            m_List[4] = InjectUtil.CreateTypePair(param5);
            m_List[5] = InjectUtil.CreateTypePair(param6);
            m_List[6] = InjectUtil.CreateTypePair(param7);
            m_List[7] = InjectUtil.CreateTypePair(param8);
            m_List[8] = InjectUtil.CreateTypePair(param9);
            m_List[9] = InjectUtil.CreateTypePair(param10);
            return CreateInternal(m_List);
        }

        protected sealed override IEnumerable<Type> ParamTypes
        {
            get
            {
                yield return typeof(TParam1);
                yield return typeof(TParam2);
                yield return typeof(TParam3);
                yield return typeof(TParam4);
                yield return typeof(TParam5);
                yield return typeof(TParam6);
                yield return typeof(TParam7);
                yield return typeof(TParam8);
                yield return typeof(TParam9);
                yield return typeof(TParam10);
            }
        }
    }

    [Obsolete("Zenject.Factory has been renamed to PlaceholderFactory.  Zenject.Factory will be removed in future versions")]
    public class Factory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>
        : PlaceholderFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TValue>
    {
    }
}

