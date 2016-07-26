(function () {
    "use strict";

    var myAppModule = angular.module(
        'myApp',
        [
            'ngRoute',
            'ui.bootstrap'
        ]);

    myAppModule.config([
        '$routeProvider', function ($routeProvider) {
            $routeProvider
                .when('/', { templateUrl: 'scripts/app/views/default.html' })
                .when('/bicycles', { templateUrl: 'scripts/app/views/bicyclesIndex.html', controller: 'BicyclesController' })
                .when('/bicycles/new', { templateUrl: 'scripts/app/views/bicyclesEditor.html', controller: 'BicycleController' })
                .when('/bicycles/:bicycleId/edit', { templateUrl: 'scripts/app/views/bicyclesEditor.html', controller: 'BicycleController' })
                .when('/customers', { templateUrl: 'scripts/app/views/customersIndex.html' })
                .when('/rentals', { templateUrl: 'scripts/app/views/rentalsIndex.html' });
        }
    ]);

})();