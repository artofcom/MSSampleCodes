using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace App.MVCS
{
    public class SurgeLoading : IMVCS
    {
        //  Events ----------------------------------------

        //  Properties ------------------------------------
        SurgeLoadingModel _model;
        SurgeLoadingView _view;
        SurgeLoadingController _controller;
        SurgeLoadingService _service;
        SurgeContext _context;
        bool _isInitialized = false;

        //  Fields ----------------------------------------

        //  Methods ---------------------------------------
        public SurgeLoading(AView view, IContext context)
        {
            _view = view as SurgeLoadingView;
            _context = context as SurgeContext;
        }
        public void Initialize()
        {
            if (_isInitialized) return;

            _model = new SurgeLoadingModel();
            _service = new SurgeLoadingService(_model, _context);
            _controller = new SurgeLoadingController(_model, _view, _service, _context);


            //
            // TEMP Code, since we know we not gonna have the Summary View.
            //
            //_context.SurgeAniService = _service;
        }
    }
}