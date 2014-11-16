///<reference path="~/Content/scripts/jasmine/jasmine.js"/>
///<reference path="~/Content/scripts/angular/angular.js"/>
///<reference path="~/Content/scripts/angular/angular-mocks.js"/>

///<reference path="~/Content/scripts/app/controllers.js"/>


/* jasmine specs for controllers go here */
describe('PhoneCat controllers', function () {

    describe('PhoneListCtrl', function () {

        beforeEach(module('phonecatApp'));

        it('should create "phones" model with 3 phones', inject(function ($controller) {
            var scope = {},
                ctrl = $controller('PhoneListCtrl', { $scope: scope });

            expect(scope.phones.length).toBe(3);
        }));

    });
});
