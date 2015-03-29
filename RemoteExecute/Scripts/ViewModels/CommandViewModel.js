function CommandViewModel(commandType) {
    var self = this;

    self.type = commandType;
    self.text = ko.observable();
}