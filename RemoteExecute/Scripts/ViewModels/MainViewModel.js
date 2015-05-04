function MainViewModel(name, commands) {
    var self = this;

    self.name = ko.observable(name);
    self.commands = ko.observableArray(commands);
    self.selectedCommand = ko.observable();
    self.commandTypes = { 'SSH': ['Mac Server', 'Synology NAS'], 'PowerShell': ['A Windows Server'] };

    self.addCommand = function () {
        var commandType = self.selectedCommand();
        self.commands.push(new CommandViewModel(commandType));
    };
}