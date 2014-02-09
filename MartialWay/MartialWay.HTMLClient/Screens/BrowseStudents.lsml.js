/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.BrowseStudents.FullName_postRender = function (element, contentItem) {
    // Write code here.
    return contentItem.screen.Students.selectedItem.ModifiedBy;
};