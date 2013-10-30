define(['plugins/router'], function (router) {
    return {
        router: router,
        activate: function () {
            return router.map([
                { route: 'people', moduleId: 'people/index', title: 'List', nav: true }
            ]).buildNavigationModel()
              .mapUnknownRoutes('people/index', 'not-found')
              .activate();
        }
    };
});