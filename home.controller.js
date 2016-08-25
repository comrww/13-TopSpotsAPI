angular.module("myApp", []);

angular.module("myApp").controller('HomeController', function($scope, $http) {
	$http.get('https://raw.githubusercontent.com/OriginCodeAcademy/2016-CW-FallCohort/master/Projects/Week%201/04-SanDiegoTopSpots/topspots.json').then(
			function(response) {
				$scope.topspots = response.data;
			},
			function(err) {
				alert(err);
			}
		);
}); 