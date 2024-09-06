using LINQSamples;

SampleViewModel vm = new();


var result = vm.GetAllQuery();

vm.Display(result);
