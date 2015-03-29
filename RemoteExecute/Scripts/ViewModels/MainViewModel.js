function MainViewModel() {
    var self = this;

    self.commands = ko.observableArray();
    self.selectedCommand = ko.observable();
    self.commandTypes = { 'SSH': ['Mac Server', 'Synology NAS'], 'PowerShell': ['A Windows Server'] };

    self.addCommand = function () {
        var commandType = self.selectedCommand();
        self.commands.push(new CommandViewModel(commandType));
    };
}