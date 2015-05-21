function CommandViewModel(commandType) {
    var self = this;

    self.type = commandType;
    self.serverId = ko.observable();
    self.text = ko.observable();
}