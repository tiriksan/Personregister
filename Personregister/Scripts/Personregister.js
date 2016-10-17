var Personregister = angular.module('Personregister', []);

Personregister.controller('LandingPageController', ['$scope', '$http', function ($scope, $http) {
    $scope.model = {};

    $scope.sendForm = function () {
        $http({
            method: 'POST',
            url: '/Home/GetPerson',
            params: { NIN: $scope.models.NIN }
        }).success(function (data) {
            $scope.model.result = data;
        }).error(function (data) {
            $scope.model.result = 'Could not find any data on this person.';
        });
    }
}]);