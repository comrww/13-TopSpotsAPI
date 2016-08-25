"use strict";
//angular.module('topSpots', []);
//$http.get('https://raw.githubusercontent.com/OriginCodeAcademy/2016-CW-FallCohort/master/Projects/Week%201/04-SanDiegoTopSpots/topspots.json').success(function(data) {
		//$scope.topSpots = data;
//});

//GENERAL NOTES
//look into strict header for angular
//Agnular can handle non-existant variables
//     ORDER OF OPERATIONS
//1. HTML Loaded
//2. HTTP Call is made
//Future. There will be an http response - that is when you do the topspots (this has to be assigned to the scope)
//This is a lot of moving data around
//Just like jquery but the concatenation is done in the HTML
//Look at notes from lecture today to look at view document model. etc. 
//factory.$http - I think this is for the Google Maps API feature (extra)

console.log('flag one');

var app = angular.module("topSpots", []); 

app.controller("MyFunction", ['$scope','$http', function($scope, $http) { 

	$http.get('https://raw.githubusercontent.com/OriginCodeAcademy/2016-CW-FallCohort/master/Projects/Week%201/04-SanDiegoTopSpots/topspots.json').success (function(data) { 
		$scope.topSpots = function() {
			console.log(topspots)
			return data;
		};
	});
}]);