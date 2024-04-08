using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace App.MVCS.Factory
{
    public interface IMVCSFactory
    {
        IMVCS CreateMVCSScreen(AView view, IContext context);
    }

    public class SurgeLoadingMVCSFactory : IMVCSFactory
    {
        public IMVCS CreateMVCSScreen(AView view, IContext context)
        {
            return new SurgeLoading(view, context);
        }
    }

    public class SurgeHomeMVCSFactory : IMVCSFactory
    {
        public IMVCS CreateMVCSScreen(AView view, IContext context)
        {
            return new SurgeHome(view, context);
        }
    }

    public class SurgeAnimationMVCSFactory : IMVCSFactory
    {
        public IMVCS CreateMVCSScreen(AView view, IContext context)
        {
            return new SurgeAnimation(view, context);
        }
    }
}