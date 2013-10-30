define(['durandal/app', 'durandal/system', 'knockout', 'people/data'], function (app, system, ko, data) {


    var vm = {
        
        people: ko.observableArray(),
        activate: function () {
            system.log('Lifecycle : activate : hello');
            var that = this;
            //go get some data
            return data.getPeople('people/all').then(function (results) {
                system.log(results);
                that.people = ko.observableArray(results);
            });
        },
        binding: function () {
            system.log('Lifecycle : binding : hello');
            return { cacheViews: false }; //cancels view caching for this module, allowing the triggering of the detached callback
        },
        bindingComplete: function () {
            system.log('Lifecycle : bindingComplete : hello');
        },
        attached: function (view, parent) {
            system.log('Lifecycle : attached : hello');
        },
        compositionComplete: function (view) {
            system.log('Lifecycle : compositionComplete : hello');
        },
        detached: function (view) {
            system.log('Lifecycle : detached : hello');
        }
    };

    return vm;
});