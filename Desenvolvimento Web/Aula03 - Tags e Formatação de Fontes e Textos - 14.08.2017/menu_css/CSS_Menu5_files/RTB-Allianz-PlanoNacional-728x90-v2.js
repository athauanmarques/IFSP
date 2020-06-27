(function (lib, img, cjs, ss) {

var p; // shortcut to reference prototypes

// library properties:
lib.properties = {
	width: 728,
	height: 90,
	fps: 24,
	color: "#FFFFFF",
	manifest: [
		{src:"images/fundo_728x90.jpg", id:"fundo_728x90"},
		{src:"images/logo.png", id:"logo"}
	]
};



// symbols:



(lib.fundo_728x90 = function() {
	this.initialize(img.fundo_728x90);
}).prototype = p = new cjs.Bitmap();
p.nominalBounds = new cjs.Rectangle(0,0,728,90);


(lib.logo = function() {
	this.initialize(img.logo);
}).prototype = p = new cjs.Bitmap();
p.nominalBounds = new cjs.Rectangle(0,0,82,52);


(lib.titulo2 = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("AgSAVQgIgIAAgNQAAgLAIgIQAHgJALAAQAMAAAHAJQAIAIAAALQAAAMgHAJQgIAHgMABQgLAAgHgIg");
	this.shape.setTransform(171.5,19.2,0.797,0.797);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AhKABQAAgpATgZQAVgZAlAAQAuAAARAjQAJAVAAAoIAAAFIhnAAQABAVAIALQANAPAbAAQATAAARgIQAHgEAEgEIgCAlQgEADgJADQgSAGgbAAQhSAAAAhagAgbgSIA5AAQgBgTgEgJQgHgOgQAAQgdAAAAAqg");
	this.shape_1.setTransform(160.9,14.1,0.797,0.797);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("Ag7BtQgRgWAAgrQAAheBKAAQAVAAALANIAAhYIAvgGIAAECIguADIAAgXQgCAGgHAHQgOAMgUAAQgeAAgRgXgAgUgCQgJAMAAAdQAAAdAIANQAJAMAPAAQAMAAAHgHQAJgHgBgOIAAhFQgHgLgSAAQgRAAgIANg");
	this.shape_2.setTransform(146.2,10.9,0.797,0.797);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FFFFFF").s().p("Ag5B4QgQgPAAgjIAAhzIAuAAIAABnQAAARAEAIQAGAMARAAQAKAAAIgGQAKgHAAgOIAAhxIAuAAIAACuIguADIAAgXQgDAGgIAHQgPALgVABQgXgBgPgNgAgnhYIA+gtIASAeIhBAmg");
	this.shape_3.setTransform(131.5,10.7,0.797,0.797);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#FFFFFF").s().p("Ag5BJQgLgOAAgXQAAgjAagMQAQgIAegBIAUgBIAAgIQAAgNgEgFQgHgKgUAAQgSAAgPAIIgLAIIAAgjIAOgHQASgHAXAAQApAAAPAVQAJANAAAZIAAB2IgrACIAAgVQgDAGgGAFQgOAMgUAAQgaAAgOgSgAAJAGQgPABgHAFQgKAGAAAPQAAAYAXAAQAKAAAIgIQAGgHABgLIAAgag");
	this.shape_4.setTransform(117,14.1,0.797,0.797);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("#FFFFFF").s().p("AgsBVIgNgHIgBglIAMAIQARAJAUAAQAYAAAAgRQAAgHgEgEQgDgDgJgGIgTgKQgRgJgHgHQgLgNAAgVQAAgzA7AAQAVAAAPAGQAIAEAEADIAAAlQgEgEgIgEQgOgJgRAAQgUAAAAAPQAAAHAFAFQADADAIAFIATAKQAQAIAIAHQALANAAAUQAAA3hAAAQgXAAgQgGg");
	this.shape_5.setTransform(105,14.1,0.797,0.797);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#FFFFFF").s().p("Ag4BJQgMgOAAgXQAAgjAagMQAPgIAggBIATgBIAAgIQAAgNgEgFQgHgKgUAAQgRAAgQAIIgLAIIAAgjIAOgHQASgHAYAAQApAAAPAVQAIANAAAZIAAB2IgrACIAAgVQgDAGgGAFQgOAMgUAAQgaAAgNgSgAAJAGQgPABgHAFQgKAGAAAPQAAAYAXAAQAKAAAHgIQAIgHAAgLIAAgag");
	this.shape_6.setTransform(86.9,14.1,0.797,0.797);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f("#FFFFFF").s().p("Ag0BaIAAiwIAtAAIAAAZIAHgOQALgOASAAQARAAAHAGIgEApQgIgIgRAAQgeAAAAAhIAABrg");
	this.shape_7.setTransform(76.4,14,0.797,0.797);

	this.shape_8 = new cjs.Shape();
	this.shape_8.graphics.f("#FFFFFF").s().p("AhMCBIAAj+IAuAAIAAAWIAJgMQAOgNAUAAQAeAAARAXQARAXAAAqQAABehKAAQgNAAgLgGIgJgHIAABYgAgVhTQgJAIAAAOIAABFIAGAGQAJAFALAAQAQAAAJgNQAJgMAAgdQAAgdgIgNQgIgNgQAAQgMAAgHAHg");
	this.shape_8.setTransform(63.4,17.1,0.797,0.797);

	this.shape_9 = new cjs.Shape();
	this.shape_9.graphics.f("#FFFFFF").s().p("ABPBaIAAhnQAAgRgEgIQgGgMgRAAQgMAAgJAHQgIAGgBAOIAABxIgsAAIAAhnQAAgRgDgIQgHgMgRAAQgLAAgIAHQgKAGAAAOIAABxIguAAIAAiwIAuAAIAAAWIAKgMQAQgMAWAAQAXAAALAMQAIAGACAGIAMgMQAQgNAZAAQAaAAAPANQARAQAAAkIAAByg");
	this.shape_9.setTransform(38.7,14,0.797,0.797);

	this.shape_10 = new cjs.Shape();
	this.shape_10.graphics.f("#FFFFFF").s().p("AhKABQAAgpATgZQAVgZAlAAQAuAAARAjQAJAVAAAoIAAAFIhnAAQABAVAIALQAMAPAbAAQAUAAAQgIQAIgEADgEIgBAlQgFADgJADQgSAGgbAAQhRAAAAhagAgcgSIA6AAQgBgTgEgJQgHgOgRAAQgcAAgBAqg");
	this.shape_10.setTransform(20.2,14.1,0.797,0.797);

	this.shape_11 = new cjs.Shape();
	this.shape_11.graphics.f("#FFFFFF").s().p("AgbB8IgLgHIgmAOIAAkAIAvgGIAABoQADgFAGgGQAOgMATAAQAeAAARAXQARAWAAApQAABghLAAQgPAAgOgIgAgWgFQgHAGAAAOIAABHIAFAGQAJAFALAAQAQAAAJgNQAJgOAAgdQAAgdgJgMQgIgMgPAAQgMAAgIAHg");
	this.shape_11.setTransform(6.2,10.9,0.797,0.797);

	this.addChild(this.shape_11,this.shape_10,this.shape_9,this.shape_8,this.shape_7,this.shape_6,this.shape_5,this.shape_4,this.shape_3,this.shape_2,this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(0,0,173.7,27.4);


(lib.titulo1 = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("Ag8BWIAAgNIBfiOIhXAAIAAgQIBxAAIAAANIhfCOIBfAAIgBAQg");
	this.shape.setTransform(191.9,13.9,0.797,0.797);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AgtBKQgMgOAAgVQAAgiAagLQAOgGAggDIAWgBIAAgSQgBgQgEgIQgIgNgXAAQgRAAgOAJIgLAJIAAgVIALgHQAQgHATAAQAjAAALATQAHALAAAZIAAB2IgVADIAAgXQgCAGgIAGQgOAMgVAAQgYAAgNgPgAANAAQgXACgLAGQgOAJAAAVQAAAhAjAAQAOAAALgLQALgKABgPIAAgjg");
	this.shape_1.setTransform(179.7,13.9,0.797,0.797);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("AgWCCIAAiaIgSAAIAAgRIASAAIAAgkQAAgZAIgMQAJgPAWAAQAQAAAIAFIgCASQgFgGgPAAQgNAAgEAIQgCAHAAARIAAAnIAhAAIAAARIghAAIAACag");
	this.shape_2.setTransform(170.8,10.4,0.797,0.797);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FFFFFF").s().p("AgyBDQgTgYAAgpQAAgoARgZQATgaAiAAQAgAAATAXQASAXAAAqQAAAogRAYQgSAbgjAAQggAAgSgXgAgjg0QgMATAAAhQAAAfAKATQANAWAYAAQAwAAAAhIQAAgfgKgSQgMgXgaAAQgXAAgMAUg");
	this.shape_3.setTransform(154.1,14,0.797,0.797);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#FFFFFF").s().p("AgJCCIAAj/IATgEIAAEDg");
	this.shape_4.setTransform(144.5,10.4,0.797,0.797);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("#FFFFFF").s().p("AgJB8IAAirIATAAIAACrgAgIhjQgFgEAAgGQAAgOANAAQAFAAAFAEQADADAAAGQAAAHgDAEQgEAEgGAAQgEAAgEgEg");
	this.shape_5.setTransform(138.8,10.9,0.797,0.797);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#FFFFFF").s().p("AgtBLQgLgKgEgQQgCgKAAgRIAAhtIAVAAIAABqQAAAYAFAKQAKAQAaAAQAPAAAMgIQAPgKAAgTIAAh3IAVAAIAACrIgVACIAAgXQgDAGgIAHQgQAMgVAAQgZAAgOgNg");
	this.shape_6.setTransform(128.8,14,0.797,0.797);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f("#FFFFFF").s().p("AAuB/IAAhjQgQAXgeAAQggAAgSgaQgPgWAAgjQAAgyAWgXQATgVAeAAQARAAANAHQAHAEADADIAAgLIAUAAIAAD6gAgrgkQAABFAvAAQATAAALgKQALgKAAgOIAAhfQgDgDgGgDQgNgHgPAAQgzAAAABJg");
	this.shape_7.setTransform(114.4,16.9,0.797,0.797);

	this.shape_8 = new cjs.Shape();
	this.shape_8.graphics.f("#FFFFFF").s().p("AAqBYIAAhpQAAgYgGgKQgJgRgbgBQgOAAgMAJQgPALAAASIAAB3IgVAAIAAisIAUAAIAAAWIAMgMQAQgNAVAAQAZAAAOAOQARAQAAAkIAABtg");
	this.shape_8.setTransform(101.1,13.8,0.797,0.797);

	this.shape_9 = new cjs.Shape();
	this.shape_9.graphics.f("#FFFFFF").s().p("AgtBKQgMgOAAgVQAAgiAagLQAPgGAfgDIAWgBIAAgSQAAgQgFgIQgHgNgYAAQgQAAgPAJIgLAJIAAgVIALgHQAPgHAUAAQAjAAALATQAHALAAAZIAAB2IgUADIAAgXQgEAGgGAGQgPAMgVAAQgYAAgNgPgAANAAQgXACgLAGQgOAJAAAVQAAAhAjAAQAOAAAMgLQALgKAAgPIAAgjg");
	this.shape_9.setTransform(87.4,13.9,0.797,0.797);

	this.shape_10 = new cjs.Shape();
	this.shape_10.graphics.f("#FFFFFF").s().p("AgoBYIAAisIAVAAIAAAYIAJgNQAKgOASAAQAPABAIAFIgCAUQgHgHgSAAQgOAAgKANQgIAMAAASIAABxg");
	this.shape_10.setTransform(78.4,13.8,0.797,0.797);

	this.shape_11 = new cjs.Shape();
	this.shape_11.graphics.f("#FFFFFF").s().p("AgPBbQgHgKAAgcIAAhnIgSAAIAAgRIASAAIAAggIAWgGIAAAmIAoAAIAAARIgoAAIAABuQAAAPACAGQAFAIAMAAQAPAAAHgHIgBATQgIAFgPAAQgWAAgKgPg");
	this.shape_11.setTransform(69.3,12.5,0.797,0.797);

	this.shape_12 = new cjs.Shape();
	this.shape_12.graphics.f("#FFFFFF").s().p("AgoBYIAAisIAVAAIAAAYIAJgNQAKgOASAAQAPABAIAFIgCAUQgHgHgSAAQgOAAgKANQgIAMAAASIAABxg");
	this.shape_12.setTransform(56.3,13.8,0.797,0.797);

	this.shape_13 = new cjs.Shape();
	this.shape_13.graphics.f("#FFFFFF").s().p("AgtBKQgMgOAAgVQAAgiAbgLQANgGAggDIAWgBIAAgSQAAgQgFgIQgHgNgYAAQgQAAgPAJIgKAJIAAgVIALgHQAPgHATAAQAjAAALATQAHALAAAZIAAB2IgUADIAAgXQgDAGgHAGQgPAMgVAAQgYAAgNgPgAANAAQgXACgLAGQgOAJAAAVQAAAhAjAAQAOAAALgLQAMgKAAgPIAAgjg");
	this.shape_13.setTransform(44.4,13.9,0.797,0.797);

	this.shape_14 = new cjs.Shape();
	this.shape_14.graphics.f("#FFFFFF").s().p("AgZCiIgFgCIgBgSIAEACQAGACAGAAQAPAAADgJQAEgGAAgPIAAjKIAWAAIAADGQAAAWgGALQgJASgZAAQgIAAgGgBgAAIiKQgEgEAAgGQAAgOAOAAQAGAAAEAEQAEADAAAGQAAAPgOAAQgGAAgEgEg");
	this.shape_14.setTransform(34.4,14,0.797,0.797);

	this.shape_15 = new cjs.Shape();
	this.shape_15.graphics.f("#FFFFFF").s().p("AgtBKQgMgOAAgVQAAgiAbgLQAOgGAfgDIAWgBIAAgSQAAgQgEgIQgJgNgXAAQgQAAgPAJIgLAJIAAgVIAMgHQAOgHAVAAQAhAAAMATQAHALAAAZIAAB2IgVADIAAgXQgCAGgIAGQgPAMgUAAQgYAAgNgPgAANAAQgXACgKAGQgPAJAAAVQAAAhAjAAQAOAAALgLQAMgKAAgPIAAgjg");
	this.shape_15.setTransform(26.3,13.9,0.797,0.797);

	this.shape_16 = new cjs.Shape();
	this.shape_16.graphics.f("#FFFFFF").s().p("AgJB8IAAirIATAAIAACrgAgIhjQgEgEAAgGQAAgOAMAAQAFAAAEAEQAEADAAAGQAAAPgNAAQgFAAgDgEg");
	this.shape_16.setTransform(17.8,10.9,0.797,0.797);

	this.shape_17 = new cjs.Shape();
	this.shape_17.graphics.f("#FFFFFF").s().p("AgJB3IhUjtIAYAAIA8CuIAJAiQADgOAHgTIA/ivIAVAAIhXDtg");
	this.shape_17.setTransform(7.5,11.4,0.797,0.797);

	this.addChild(this.shape_17,this.shape_16,this.shape_15,this.shape_14,this.shape_13,this.shape_12,this.shape_11,this.shape_10,this.shape_9,this.shape_8,this.shape_7,this.shape_6,this.shape_5,this.shape_4,this.shape_3,this.shape_2,this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(0,0,196.8,27.1);


(lib.texto4b = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("AgHAAQAAgHAHAAQAIAAAAAHQAAAIgIAAQgHAAAAgIg");
	this.shape.setTransform(100.3,12.9,1.232,1.232);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AgDA3IAAhrIAHgCIAABtg");
	this.shape_1.setTransform(96.5,6.8,1.232,1.232);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("AgDA1IAAhIIAHAAIAABIgAgFgtQAAgHAFAAQAFABAAAFQAAAHgFgBQgFAAAAgFg");
	this.shape_2.setTransform(92.7,7.1,1.232,1.232);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FFFFFF").s().p("AgPAjIgFgEIgBgJIAGAEQAGAEAJAAQANAAAAgLQAAgFgCgDQgCgCgGgEIgHgFQgPgGAAgMQAAgTAVAAQAKAAAHAGIAAAJQgHgHgLAAQgMAAAAAKQAAAGADADIAIAFIAHAEQAPAGAAAMQAAAVgXAAQgHAAgHgDg");
	this.shape_3.setTransform(87.5,9.1,1.232,1.232);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#FFFFFF").s().p("AgXAQQAAgOALgEQAGgDAMAAIAJgBIAAgIQAAgHgCgDQgDgFgKAAQgGAAgGAEIgEADIAAgJIAEgCQAHgDAHAAQAPAAAEAIQADAEAAALIAAAxIgJABIAAgKQgFAKgNAAQgUAAAAgVgAAFAAQgJAAgEADQgGAEAAAJQAAAOAOAAQAGAAAEgFQAFgEAAgHIAAgOg");
	this.shape_4.setTransform(79.8,9.1,1.232,1.232);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("#FFFFFF").s().p("AgQAlIAAhIIAIAAIAAAKIAFgFQADgGAHAAQAGAAAEACIgBAJQgDgDgHAAQgGAAgDAGQgEAFAAAIIAAAug");
	this.shape_5.setTransform(73.9,9,1.232,1.232);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#FFFFFF").s().p("AgaAyIAAhjIARAAQAQAAAGAEQAKAGAAAOQABAOgJAGIgJAEIALABQALAHAAAPQgBASgOAHQgHADgPAAgAgRArIAMAAQAKAAAFgEQAIgFAAgMQgBgNgIgFQgGgDgJAAIgLAAgAgRgEIAJAAQAIAAAFgDQAJgEgBgMQABgMgHgEQgFgDgIAAIgLAAg");
	this.shape_6.setTransform(66.2,7.4,1.232,1.232);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f("#FFFFFF").s().p("AgVAdQgHgKgBgTQAAglAdAAQAOAAAHAKQAJAJgBASQAAAmgdAAQgMAAgJgJgAgUAAQAAAfAUAAQAUAAAAgfQAAgdgUAAQgUAAAAAdg");
	this.shape_7.setTransform(53.5,9.2,1.232,1.232);

	this.shape_8 = new cjs.Shape();
	this.shape_8.graphics.f("#FFFFFF").s().p("AgUAtQgHgKAAgQQAAgmAeAAQAKAAAGAGIAAgoIAJgCIAABtIgJABIAAgKQgFALgOAAQgNAAgHgLgAgSASQAAAeAUAAQARAAAAgQIAAgmQgGgFgKAAQgUAAgBAdg");
	this.shape_8.setTransform(44.2,6.9,1.232,1.232);

	this.shape_9 = new cjs.Shape();
	this.shape_9.graphics.f("#FFFFFF").s().p("AgVAdQgHgKgBgTQAAglAdAAQAOAAAHAKQAJAJgBASQAAARgHAJQgIAMgOAAQgNAAgIgJgAgUAAQAAAfAUAAQAUAAAAgfQAAgdgUAAQgUAAAAAdg");
	this.shape_9.setTransform(35.6,9.2,1.232,1.232);

	this.shape_10 = new cjs.Shape();
	this.shape_10.graphics.f("#FFFFFF").s().p("AgFAmQgEgEAAgMIAAgrIgHAAIAAgHIAHAAIAAgNIAJgDIAAAQIAQAAIAAAHIgQAAIAAAuQAAAHAAACQACAEAFAAQAHAAADgEIgBAJQgDACgHAAQgIAAgDgHg");
	this.shape_10.setTransform(28.7,8.2,1.232,1.232);

	this.shape_11 = new cjs.Shape();
	this.shape_11.graphics.f("#FFFFFF").s().p("AAnAlIAAgsQAAgJgCgFQgEgHgLAAQgHAAgFADQgGAFAAAIIAAAxIgHAAIAAgsQAAgJgDgFQgDgHgMAAQgHAAgFADQgGAFAAAIIAAAxIgJAAIAAhIIAJAAIAAAJIAFgEQAHgGAJAAQARAAACALIAFgFQAIgGAKAAQALAAAHAGQAHAHAAAPIAAAtg");
	this.shape_11.setTransform(15.1,9,1.232,1.232);

	this.shape_12 = new cjs.Shape();
	this.shape_12.graphics.f("#FFFFFF").s().p("AgbAAQAAgPAIgLQAHgLANAAQAbAAAAAjIAAACIguAAQAAAOAGAIQAFAIAMAAQAMAAAHgHIAAAJQgGAGgQAAQgdAAAAgmgAgNgUQgEAGAAAIIAkAAQAAgYgTAAQgIAAgFAKg");
	this.shape_12.setTransform(3.5,9.1,1.232,1.232);

	this.addChild(this.shape_12,this.shape_11,this.shape_10,this.shape_9,this.shape_8,this.shape_7,this.shape_6,this.shape_5,this.shape_4,this.shape_3,this.shape_2,this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(0,0,101.3,14);


(lib.texto4a = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("AgXAfQgFgGAAgKQAAgPALgEQAHgDAMgBIAIAAIAAgEQAAgLgLAAQgJAAgGADIgFAEIAAgPIAGgDQAIgDAJAAQARAAAHAJQADAFAAALIAAAxIgTABIAAgKQgDAKgOAAQgLAAgFgHgAAEACQgNABAAALQAAAKAJAAQAKAAAAgLIAAgLg");
	this.shape.setTransform(154.2,9.4,1.232,1.232);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AgaAAQAAglAfAAQAPgBAHAGIAAAQQgFgHgLAAQgRAAAAAXQAAAXASAAQAKAAAFgGIgBAQQgGAGgPgBQgfAAAAgmg");
	this.shape_1.setTransform(146.2,9.4,1.232,1.232);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("AgIA2IAAhJIARAAIAABJgAgKgrQAAgKAKAAQALAAAAAJQAAALgLAAQgKAAAAgKg");
	this.shape_2.setTransform(139.9,7.3,1.232,1.232);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FFFFFF").s().p("AgYAuQgIgKABgSQgBgmAgAAQAHAAAGAFIAAglIAUgDIAABtIgUABIAAgKQgEALgNAAQgNAAgHgKgAgLAQQAAAXAMAAQAMAAAAgMIAAgcQgEgFgHAAQgNAAAAAWg");
	this.shape_3.setTransform(132.4,7.3,1.232,1.232);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#FFFFFF").s().p("AgeASQAAglAfAAQAUAAAHAOQADAHAAASIAAADIgqAAQABATASAAQAOAAAHgHIgBAQQgHAGgSgBQghAAAAgmgAgLAJIAYAAQgBgQgLAAQgLAAgBAQgAgQgkIAZgTIAIAMIgbAQg");
	this.shape_4.setTransform(123.2,7.2,1.232,1.232);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("#FFFFFF").s().p("AAfAyIAAhWQAAANgEANIgRA8IgVAAIgRg8IgEgaIAABWIgSAAIAAhjIAfAAIAQA7QADAMAAAKQAAgKADgNIASg6IAeAAIAABjg");
	this.shape_5.setTransform(111.3,7.8,1.232,1.232);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#FFFFFF").s().p("AgXAfQgFgGAAgKQAAgPALgEQAGgDANgBIAIAAIAAgEQAAgLgMAAQgHAAgGADIgGAEIAAgPIAGgDQAIgDAJAAQASAAAFAJQAEAFAAALIAAAxIgSABIAAgKQgEAKgNAAQgLAAgGgHgAAEACQgNABAAALQAAAKAJAAQALAAAAgLIAAgLg");
	this.shape_6.setTransform(95.6,9.4,1.232,1.232);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f("#FFFFFF").s().p("AgJA2IAAhJIASAAIAABJgAgKgrQAAgKAKAAQALAAAAAJQAAALgLAAQgKAAAAgKg");
	this.shape_7.setTransform(89.1,7.3,1.232,1.232);

	this.shape_8 = new cjs.Shape();
	this.shape_8.graphics.f("#FFFFFF").s().p("AgaAAQAAglAgAAQANgBAIAGIAAAQQgGgHgLAAQgQAAAAAXQAAAXARAAQALAAAFgGIgBAQQgFAGgQgBQgfAAAAgmg");
	this.shape_8.setTransform(83,9.4,1.232,1.232);

	this.shape_9 = new cjs.Shape();
	this.shape_9.graphics.f("#FFFFFF").s().p("AALAmIAAgqQAAgIgBgDQgDgFgHAAQgDAAgEACQgEADAAAGIAAAvIgTAAIAAhKIATAAIAAAKIAFgFQAGgGAIAAQAKAAAGAGQAHAHAAAPIAAAvg");
	this.shape_9.setTransform(74.1,9.3,1.232,1.232);

	this.shape_10 = new cjs.Shape();
	this.shape_10.graphics.f("#FFFFFF").s().p("AgeATQAAgmAfAAQAUAAAHAPQADAHAAASIAAACIgqAAQAAAUATAAQAOAAAHgHIgBAQQgHAFgSAAQghAAAAgmgAgLAKIAXAAQAAgQgMAAQgLAAAAAQgAAAgnIgSANIgHgJIAZgVIAZAVIgHAJg");
	this.shape_10.setTransform(64.6,7.1,1.232,1.232);

	this.shape_11 = new cjs.Shape();
	this.shape_11.graphics.f("#FFFFFF").s().p("AgKAnQgEgGABgMIAAgjIgIAAIAAgOIAIAAIAAgNIARgEIAAARIASAAIAAAOIgSAAIAAAiQABAGABACQACAEAFAAQAGAAADgDIgBAPQgEACgLAAQgKAAgGgHg");
	this.shape_11.setTransform(57,8.4,1.232,1.232);

	this.shape_12 = new cjs.Shape();
	this.shape_12.graphics.f("#FFFFFF").s().p("AgTAkIgEgDIgBgQIAFADQAIAEAIAAQAJAAAAgHQAAgEgGgEIgHgEQgPgHgBgOQAAgWAZABQANgBAGAGIAAAQQgGgIgMAAQgHABAAAGQAAAFAGAEIAIADQAPAGAAAOQAAAXgbAAQgJAAgIgCg");
	this.shape_12.setTransform(50.3,9.4,1.232,1.232);

	this.shape_13 = new cjs.Shape();
	this.shape_13.graphics.f("#FFFFFF").s().p("AgIA2IAAhJIASAAIAABJgAgKgrQAAgKAKAAQALAAAAAJQAAALgLAAQgKAAAAgKg");
	this.shape_13.setTransform(44.2,7.3,1.232,1.232);

	this.shape_14 = new cjs.Shape();
	this.shape_14.graphics.f("#FFFFFF").s().p("AgSAkIgFgDIgBgQIAGADQAGAEAJAAQAKAAAAgHQgBgEgGgEIgHgEQgPgHAAgOQAAgWAYABQANgBAHAGIAAAQQgHgIgMAAQgGABgBAGQAAAFAGAEIAIADQAPAHAAANQAAAXgaAAQgJAAgIgCg");
	this.shape_14.setTransform(38.2,9.4,1.232,1.232);

	this.shape_15 = new cjs.Shape();
	this.shape_15.graphics.f("#FFFFFF").s().p("AgSAkIgFgDIgBgQIAGADQAHAEAIAAQAJAAAAgHQAAgEgGgEIgHgEQgPgHAAgOQAAgWAXABQAOgBAHAGIAAAQQgHgIgLAAQgIABAAAGQAAAFAGAEIAIADQAPAHAAANQAAAXgaAAQgKAAgHgCg");
	this.shape_15.setTransform(30.9,9.4,1.232,1.232);

	this.shape_16 = new cjs.Shape();
	this.shape_16.graphics.f("#FFFFFF").s().p("AAXAyIgIgdIgeAAIgIAdIgUAAIAghjIAZAAIAeBjgAgCgZIgIAeIAUAAIgKgqIgCAMg");
	this.shape_16.setTransform(21.9,7.8,1.232,1.232);

	this.shape_17 = new cjs.Shape();
	this.shape_17.graphics.f("#FFFFFF").s().p("AAnAlIAAgsQAAgKgCgEQgEgHgLAAQgHAAgFADQgGAFAAAIIAAAxIgHAAIAAgsQAAgKgDgEQgDgHgMAAQgHAAgFADQgFAFgBAIIAAAxIgJAAIAAhIIAJAAIAAAJIAFgFQAHgFAJAAQAQAAACALIAGgGQAIgFAKAAQALAAAHAGQAGAGAAAQIAAAtg");
	this.shape_17.setTransform(97.7,-10.6,1.232,1.232);

	this.shape_18 = new cjs.Shape();
	this.shape_18.graphics.f("#FFFFFF").s().p("AgUAcQgJgJABgTQAAgPAHgLQAIgLANAAQAOAAAIAKQAIAKAAARQAAAmgeAAQgNAAgHgKgAgTAAQAAAeATABQAVgBAAgeQAAgdgVAAQgTAAAAAdg");
	this.shape_18.setTransform(85.8,-10.5,1.232,1.232);

	this.shape_19 = new cjs.Shape();
	this.shape_19.graphics.f("#FFFFFF").s().p("AgZABQAAgmAeAAQAPAAAFAGIAAAJQgGgHgNAAQgVAAAAAdQAAAfAWAAQANAAAGgJIgBAKQgGAGgOAAQgegBAAgkg");
	this.shape_19.setTransform(77.7,-10.5,1.232,1.232);

	this.addChild(this.shape_19,this.shape_18,this.shape_17,this.shape_16,this.shape_15,this.shape_14,this.shape_13,this.shape_12,this.shape_11,this.shape_10,this.shape_9,this.shape_8,this.shape_7,this.shape_6,this.shape_5,this.shape_4,this.shape_3,this.shape_2,this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(16.5,-15.2,141.4,29.5);


(lib.texto3c = function() {
	this.initialize();

	// Camada 2
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("AgsBKQgPgXAAgxQAAgyAQgYQAPgYAcAAQAeAAAPAXQAPAXAAAyQAAAxgQAYQgPAYgdAAQgdAAgPgXgAgZg5QgHATAAAnQAAAnAHASQAIATARgBQARABAJgTQAHgUAAgmQAAgngIgSQgIgTgRAAQgRAAgIATg");
	this.shape.setTransform(26.1,10.1);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AgsBKQgPgXABgxQAAgyAPgYQAPgYAdAAQAdAAAPAXQAOAXAAAyQAAAxgPAYQgPAYgdAAQgeAAgOgXgAgYg5QgJATABAnQgBAnAJASQAHATARgBQARABAJgTQAHgUAAgmQAAgngIgSQgIgTgRAAQgRAAgHATg");
	this.shape_1.setTransform(11.4,10.1);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("AgIARQAIgSgCgRIALAAQABARgKAUg");
	this.shape_2.setTransform(1.6,20.3,1.609,1.609);

	this.addChild(this.shape_2,this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(0,0,32.1,23.5);


(lib.texto3b = function() {
	this.initialize();

	// Camada 3
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#EC7802").s().p("AhKDEQgXgGgLgHQgLgFAAgCIgDhMIAEAGQAFAGAMAIQAKAHASAGQARAGAZAAQAlAAATgUQASgUAAghQABgUgIgPQgHgQgRgKQgQgGgfgBQgXAAgQADQgRADgJAFIgKADIAAjWIDcAAIAABDIiZAAIAABRIANgDQAMgDATAAQAnABAXAMQAZANANAUQANARAFAWQAEAVAAATQABAqgRAfQgPAeggASQggARgtAAQgiAAgXgHg");
	this.shape.setTransform(40.8,20.8);

	// Camada 1
	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#EC7802").s().p("AhKB9IAAgtQAkgbAfgeQAQgSAIgMQAHgPAAgTQABgrgrAAQgWAAgSALIgNALIAAguIAPgIQAUgIAfAAQAcAAAVANQAeATABAtQgBAcgMAVQgLAWgaAXQgZAYgUAMIBfAAIAAAqg");
	this.shape_1.setTransform(11.9,20.1,1.609,1.609);

	this.addChild(this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(-0.3,0,53.5,41.2);


(lib.texto3a = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("AgBBOIAAgRIgBAAQgTgBgKgHIgBgMQALAKATAAIABAAIAAgyIgGgBQgLgGgEgGQgHgIAAgMQAAgZAcgEIAAgNIAGgDIAAAQQAQABAIAGIAAAMQgJgIgPgCIAAAuIAHAEQAJAEAFAFQAHAIAAAMQAAAcgcAFIAAASgAAFAzQAQgFAAgRQAAgRgOgGIgCgBgAgSghQAAAJAFAGQADAEAJAFIAAgrQgRADAAAQg");
	this.shape.setTransform(18.3,12.6,1.609,1.609);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AAUA7Igrg5IAAA5IgLAAIAAh1IASAAQAUAAAIADQAOAIAAASQAAARgLAJQgKAGgNAAIArA4gAgXgDIAMAAQAZAAAAgZQAAgNgIgFQgGgEgMAAIgLAAg");
	this.shape_1.setTransform(5.7,12.5,1.609,1.609);

	this.addChild(this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(0,0,23.7,25.1);


(lib.texto2a = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("AgSAAQAAgZATABQASAAAAAXIAAABIgfAAQAAAKAEAEQADAHAIgBQAJABAFgGIgBAHQgEAEgLAAQgTAAAAgagAgJgOQgDAFAAAFIAYAAQAAgQgMAAQgGAAgDAGg");
	this.shape.setTransform(58.6,7.3,1.439,1.439);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AgSANQAAgZAUAAQAHAAAEAEIAAgcIAGgBIAABKIgGABIAAgHQgEAHgJAAQgSAAAAgZgAgLAMQAAAVAMAAQAMAAAAgLIAAgaQgEgDgHAAQgNgBAAAUg");
	this.shape_1.setTransform(50.9,5.5,1.439,1.439);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("AgKAZIAAgxIAFAAIAAAHIADgDQACgEAFAAQAEAAACABIAAAGQgCgCgGAAQgHAAgBANIAAAfg");
	this.shape_2.setTransform(42.1,7.3,1.439,1.439);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FFFFFF").s().p("AgCAkIAAgxIAFAAIAAAxgAgCgfQAAgEACAAQAEAAAAAEQAAAEgEAAQgCAAAAgEg");
	this.shape_3.setTransform(37.3,5.8,1.439,1.439);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#FFFFFF").s().p("AgDAaQgCgCAAgJIAAgdIgGAAIAAgFIAGAAIAAgJIAFgCIAAALIALAAIAAAFIgLAAIAAAfIAAAGQABADAEAAQAFAAABgCIAAAFQgCACgFAAQgEAAgDgFg");
	this.shape_4.setTransform(33.4,6.6,1.439,1.439);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("#FFFFFF").s().p("AgKAZIAAgxIAFAAIAAAHIADgDQACgEAFAAQAEAAACABIAAAGQgDgCgFAAQgHAAgBANIAAAfg");
	this.shape_5.setTransform(29,7.3,1.439,1.439);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#FFFFFF").s().p("AgQALQAAgKAIgCQAEgCAIgBIAGAAIAAgFQAAgLgKAAQgDAAgFADIgDADIAAgHIAEgBQAEgCAEAAQAKgBAEAGQACADAAAIIAAAgIgGABIAAgGQgEAGgIABQgPAAAAgPgAAEAAQgNAAAAALQAAAJAJAAQAEAAADgDQADgDAAgEIAAgKg");
	this.shape_6.setTransform(22.3,7.3,1.439,1.439);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f("#FFFFFF").s().p("AgSAkIAAhHIAGAAIAAAGIADgDQAEgEAFABQAKAAAEAHQAFAHAAAKQAAAagUAAQgEAAgEgCIgDgCIAAAZgAgMgUIAAAaIADACQAEABAEAAQANABABgUQgBgUgMgBQgMAAAAALg");
	this.shape_7.setTransform(15.5,8.9,1.439,1.439);

	this.shape_8 = new cjs.Shape();
	this.shape_8.graphics.f("#FFFFFF").s().p("AAVAjIgJgaIgXAAIgJAaIgGAAIAZhFIAEAAIAYBFgAgJAEIATAAIgKgeg");
	this.shape_8.setTransform(4,6,1.439,1.439);

	this.addChild(this.shape_8,this.shape_7,this.shape_6,this.shape_5,this.shape_4,this.shape_3,this.shape_2,this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(0,0,61.5,14.3);


(lib.texto1b = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("AgMBvIAAjZIAZgEIAADdg");
	this.shape.setTransform(28.7,39.9,1.026,1.026);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AgqA/QgKgNAAgSQAAgdAXgKQAMgFAagDIASAAIAAgMQAAgNgEgFQgGgKgRAAQgQAAgMAHIgJAHIAAgWIAKgGQAOgGARAAQAgAAALAQQAGALAAAVIAABkIgZACIAAgTQgCAFgHAFQgMAKgRAAQgVAAgLgNgAAKACQgQACgJAFQgKAGAAAPQAAAZAZAAQALAAAIgIQAIgIAAgLIAAgcg");
	this.shape_1.setTransform(17.8,43.6,1.026,1.026);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("AAfBLIAAhYQAAgSgEgIQgHgNgUABQgKAAgJAGQgLAIABANIAABjIgbAAIAAiTIAaAAIAAATIAKgKQANgLARAAQAWAAAMAMQANAMAAAfIAABeg");
	this.shape_2.setTransform(3.4,43.5,1.026,1.026);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FFFFFF").s().p("AgtA6QgRgUAAgkQAAgjAQgVQARgWAeAAQAcAAARATQARAUAAAkQAAAjgQAVQgRAWgeAAQgcAAgRgTgAgiAAQAAA4AiAAQAjAAAAg4QAAg3gjAAQgiAAAAA3g");
	this.shape_3.setTransform(-12.1,43.7,1.026,1.026);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#FFFFFF").s().p("AgMBrIAAiTIAZAAIAACTgAgKhPQgFgEAAgHQAAgQAPAAQAQAAAAAPQAAAQgQAAQgGAAgEgEg");
	this.shape_4.setTransform(-23.1,40.3,1.026,1.026);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("#FFFFFF").s().p("Ag0ABQAAggAOgTQAQgZAhAAQAdAAAMAKIAAAYQgDgEgGgDQgMgHgPAAQgoAAgBA3QABA3AqAAQAOAAAMgHQAGgDADgEIgCAZQgMALgdAAQg+gBAAhLg");
	this.shape_5.setTransform(-32.7,43.7,1.026,1.026);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#FFFFFF").s().p("AgqA/QgKgNAAgSQAAgdAWgKQANgFAagDIASAAIAAgMQAAgNgEgFQgGgKgRAAQgQAAgNAHIgJAHIAAgWIAKgGQAPgGARAAQAgAAALAQQAGALAAAVIAABkIgZACIAAgTQgCAFgHAFQgMAKgRAAQgVAAgLgNgAAKACQgRACgIAFQgKAGAAAPQAAAZAZAAQALAAAIgIQAIgIAAgLIAAgcg");
	this.shape_6.setTransform(-46.7,43.6,1.026,1.026);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f("#FFFFFF").s().p("AAsBlIhLiAQgHgNgEgKIgDgIIAACfIgZAAIAAjJIAdAAIBGB7QANAVAEAPIAAifIAZAAIAADJg");
	this.shape_7.setTransform(-62.6,40.9,1.026,1.026);

	this.addChild(this.shape_7,this.shape_6,this.shape_5,this.shape_4,this.shape_3,this.shape_2,this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(-70,28.5,100.1,23.2);


(lib.texto1a = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("AgrA5QgPgUgBgjQAAgiAPgVQAQgWAdAAQAcAAAPATQAPAUABAkQAAAhgPAVQgQAWgdAAQgcAAgPgTgAgoAAQAAAbAJAQQALATAUAAQApAAAAg+QAAg8gpAAQgoAAAAA8g");
	this.shape.setTransform(54.4,15.3,1.026,1.026);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AAkBLIAAhZQAAgUgFgJQgIgOgXAAQgMgBgKAIQgMAIAAAQIAABlIgTAAIAAiSIASAAIAAASIAKgKQANgLASAAQAWAAAMAMQAOANAAAfIAABdg");
	this.shape_1.setTransform(39.4,15.1,1.026,1.026);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("AgnA+QgKgLABgSQAAgdAWgJQAMgFAbgCIASgBIAAgQQABgOgEgGQgHgLgUAAQgOAAgMAIIgJAHIAAgSIAJgFQANgGAQAAQAeAAAJAQQAHAJgBAVIAABkIgRADIAAgUQgDAFgGAFQgMAKgRAAQgVAAgMgNgAALAAQgTACgKAFQgMAHAAASQABAcAdAAQAMAAAKgJQAKgJgBgNIAAgdg");
	this.shape_2.setTransform(24.4,15.2,1.026,1.026);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FFFFFF").s().p("AgIBvIAAjZIAQgEIAADdg");
	this.shape_3.setTransform(15.1,11.4,1.026,1.026);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#FFFFFF").s().p("Ag1BlIAAjJIAlAAQAfAAAQAKQAXAOAAAiQAAAogbAMQgQAIgZAAIgUAAIAABTgAgiADIATAAQAXAAALgFQAPgKAAgdQAAgcgQgKQgLgGgWAAIgTAAg");
	this.shape_4.setTransform(5.6,12.4,1.026,1.026);

	this.addChild(this.shape_4,this.shape_3,this.shape_2,this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(0,0,60.5,23.2);


(lib.logo_vermelho = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FF010C").s().p("AlaA2IAAhsIK1AAIAABsg");
	this.shape.setTransform(34.8,5.5);

	this.addChild(this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(0,0,69.5,11);


(lib.logo_azul = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#035193").s().p("AlaBmIAAjLIK1AAIAADLg");
	this.shape.setTransform(34.8,10.3);

	this.addChild(this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(0,0,69.5,20.5);


(lib.fundo_efeito = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#0D2133").s().p("Eg43AHCIAAuDMBxvAAAIAAODg");
	this.shape.setTransform(364,45);

	this.addChild(this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(0,0,728,90);


(lib.botao_texto = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("AA/BeIAAiqQgCATgGASIgtCFIgVAAIgtiFQgDgLgDgOIgCgMIAACqIgXAAIAAi7IAnAAIAsCCQAEARAAALQAAgLAGgSIAsiBIAmAAIAAC7g");
	this.shape.setTransform(139.1,11.4,0.503,0.503);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AgwBeIAAi7IBcAAIAAAWIhCAAIAAA7IA3AAIAAATIg3AAIAABBIBHAAIgBAWg");
	this.shape_1.setTransform(130.7,11.4,0.503,0.503);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("AgvBHQgWgYAAgrQAAgjAOgZQAXgnAzAAQAWAAAQAGQAJACAEADIAAAaQgEgEgIgEQgQgIgXAAQgfAAgRAXQgOATAAAgQAABMA7AAQASAAAKgFIAAg9IAaAAIAABHQgEAEgJAEQgTAHgaAAQglAAgWgZg");
	this.shape_2.setTransform(122.7,11.4,0.503,0.503);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FFFFFF").s().p("AAyBeIgUg/Ig9AAIgUA/IgZAAIBAi7IAbAAIA+C7gAgGguIgSA5IAwAAIgYhRIgGAYg");
	this.shape_3.setTransform(114.5,11.4,0.503,0.503);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#FFFFFF").s().p("AgLBeIAAi7IAYAAIAAC7g");
	this.shape_4.setTransform(108.8,11.4,0.503,0.503);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("#FFFFFF").s().p("AgNBeIg/i7IAbAAIAtCIIAFAZQACgLAEgOIAtiIIAZAAIhAC7g");
	this.shape_5.setTransform(103.1,11.4,0.503,0.503);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#FFFFFF").s().p("Ag3BJQgUgYAAguQAAguAUgaQAUgbAjAAQAjAAAVAZQAVAYAAAtQAAAugVAbQgVAagjAAQgjAAgUgYgAgxAAQAABMAxAAQAyAAAAhMQgBhLgxAAQgxAAAABLg");
	this.shape_6.setTransform(91.7,11.4,0.503,0.503);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f("#FFFFFF").s().p("AAcBeIg9hYIAABYIgaAAIAAi7IAmAAQAgAAANAIQAVALAAAdQAAAbgRAOQgOAKgSAAIBABYgAghgHIAQAAQAkAAgBgjQABgTgLgHQgIgGgRAAIgQAAg");
	this.shape_7.setTransform(83.9,11.4,0.503,0.503);

	this.shape_8 = new cjs.Shape();
	this.shape_8.graphics.f("#FFFFFF").s().p("Ag0BNQgIgKgDgPQgCgLAAgWIAAhxIAZAAIAAB5QAAAWAGAKQAJAPAZAAQAbAAAJgPQAGgKAAgYIAAh3IAYAAIAABqQAAAagBALQgDAPgIALQgQAUgmAAQgjAAgRgSg");
	this.shape_8.setTransform(75.5,11.5,0.503,0.503);

	this.shape_9 = new cjs.Shape();
	this.shape_9.graphics.f("#FFFFFF").s().p("AgvBHQgWgYAAgrQAAgjAOgZQAXgnAzAAQAWAAAQAGQAJACAEADIAAAaQgEgEgIgEQgQgIgXAAQgfAAgQAXQgOATAAAgQAABMA6AAQASAAAKgFIAAg9IAaAAIAABHQgEAEgJAEQgTAHgaAAQglAAgWgZg");
	this.shape_9.setTransform(66.6,11.4,0.503,0.503);

	this.shape_10 = new cjs.Shape();
	this.shape_10.graphics.f("#FFFFFF").s().p("AgwBeIAAi7IBcAAIAAAWIhCAAIAAA7IA2AAIAAATIg2AAIAABBIBHAAIgBAWg");
	this.shape_10.setTransform(59.6,11.4,0.503,0.503);

	this.shape_11 = new cjs.Shape();
	this.shape_11.graphics.f("#FFFFFF").s().p("AgnBaIgMgGIgBgaIALAJQAQAIATAAQAiAAAAgdQAAgMgFgHQgEgFgNgIIgUgNQgRgIgGgHQgMgNAAgTQAAgXANgMQAPgOAaAAQAcAAAOALIAAAZQgDgEgHgDQgOgIgSAAQgdAAAAAZQAAAMAHAHQAEAFANAHIAUANQAQAHAHAJQAKANAAATQAAAZgPAOQgPAOgbAAQgUAAgPgGg");
	this.shape_11.setTransform(52.7,11.4,0.503,0.503);

	this.shape_12 = new cjs.Shape();
	this.shape_12.graphics.f("#FFFFFF").s().p("AA/BeIAAiqQgCATgGASIgtCFIgVAAIgtiFQgDgLgDgOIgCgMIAACqIgXAAIAAi7IAnAAIAsCCQAEARAAALQAAgLAGgSIAsiBIAmAAIAAC7g");
	this.shape_12.setTransform(96.9,-3.1,0.503,0.503);

	this.shape_13 = new cjs.Shape();
	this.shape_13.graphics.f("#FFFFFF").s().p("Ag0BNQgIgKgDgPQgDgMAAgVIAAhxIAaAAIAAB5QABAWAFAKQAKAPAYAAQAbAAAKgPQAFgKAAgYIAAh3IAYAAIAABqQAAAagBALQgDAPgIALQgPAUgnAAQgjAAgRgSg");
	this.shape_13.setTransform(87,-3,0.503,0.503);

	this.shape_14 = new cjs.Shape();
	this.shape_14.graphics.f("#FFFFFF").s().p("AgwBeIAAi7IBcAAIAAAWIhCAAIAAA7IA3AAIAAATIg3AAIAABBIBHAAIgBAWg");
	this.shape_14.setTransform(76.8,-3.1,0.503,0.503);

	this.shape_15 = new cjs.Shape();
	this.shape_15.graphics.f("#FFFFFF").s().p("AgMBeIAAilIg1AAIAAgWICDAAIgBAWIg1AAIAAClg");
	this.shape_15.setTransform(69.7,-3.1,0.503,0.503);

	this.shape_16 = new cjs.Shape();
	this.shape_16.graphics.f("#FFFFFF").s().p("Ag3BJQgVgYABguQgBguAVgaQAUgbAjAAQAjAAAVAZQAVAYAAAtQAAAugVAbQgUAagkAAQgjAAgUgYgAgxAAQAABMAxAAQAyAAAAhMQAAhLgyAAQgxAAAABLg");
	this.shape_16.setTransform(61.7,-3.1,0.503,0.503);

	this.shape_17 = new cjs.Shape();
	this.shape_17.graphics.f("#FFFFFF").s().p("AgvBFQgTgZAAgpQAAgjANgYQAXgnAwAAQAUAAAQAGQAIACAEADIAAAaQgDgEgIgEQgPgIgUAAQgbAAgQATQgRATAAAkQAABLA7AAQAUAAAQgIQAIgFAEgEIgCAaQgEADgIADQgQAGgXAAQgnAAgWgbg");
	this.shape_17.setTransform(53.4,-3.1,0.503,0.503);

	this.addChild(this.shape_17,this.shape_16,this.shape_15,this.shape_14,this.shape_13,this.shape_12,this.shape_11,this.shape_10,this.shape_9,this.shape_8,this.shape_7,this.shape_6,this.shape_5,this.shape_4,this.shape_3,this.shape_2,this.shape_1,this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(50,-8,93.6,24.3);


(lib.botao_seta = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f().s("#FFFFFF").ss(1.5,1,1).p("AgXgvIAvAvIgvAw");
	this.shape.setTransform(2.4,4.8);

	this.addChild(this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(-1,-1,6.8,11.6);


(lib.botao_base = function() {
	this.initialize();

	// Camada 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#EC7802").s().p("Aq4EEIAAoHIVxAAIAAGCIiFCFg");
	this.shape.setTransform(120.3,26);

	this.addChild(this.shape);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(50.5,0,139.5,52);


(lib.titulo = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// titulo2
	this.instance = new lib.titulo2("synched",0);
	this.instance.setTransform(148.9,41.4,1,1,0,0,0,86.8,13.7);
	this.instance.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(1).to({x:148.7,alpha:0.003},0).wait(1).to({x:148.2,alpha:0.013},0).wait(1).to({x:147.3,alpha:0.033},0).wait(1).to({x:145.7,alpha:0.063},0).wait(1).to({x:143.4,alpha:0.11},0).wait(1).to({x:140,alpha:0.179},0).wait(1).to({x:134.8,alpha:0.281},0).wait(1).to({x:127.3,alpha:0.433},0).wait(1).to({x:117.4,alpha:0.63},0).wait(1).to({x:108.7,alpha:0.803},0).wait(1).to({x:103.5,alpha:0.909},0).wait(1).to({x:100.6,alpha:0.966},0).wait(1).to({x:99.3,alpha:0.993},0).wait(1).to({x:98.9,alpha:1},0).wait(65).to({startPosition:0},0).wait(1).to({x:98.5,alpha:0.992},0).wait(1).to({x:97.1,alpha:0.965},0).wait(1).to({x:94.3,alpha:0.908},0).wait(1).to({x:89,alpha:0.802},0).wait(1).to({x:79.2,alpha:0.606},0).wait(1).to({x:64.2,alpha:0.305},0).wait(1).to({x:54,alpha:0.1},0).wait(1).to({x:49.9,alpha:0.019},0).wait(1).to({x:48.9,alpha:0},0).to({_off:true},1).wait(1));

	// titulo1
	this.instance_1 = new lib.titulo1("synched",0);
	this.instance_1.setTransform(48.4,13.5,1,1,0,0,0,98.4,13.5);
	this.instance_1.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(1).to({x:48.6,alpha:0.003},0).wait(1).to({x:49.1,alpha:0.013},0).wait(1).to({x:50.1,alpha:0.033},0).wait(1).to({x:51.6,alpha:0.063},0).wait(1).to({x:53.9,alpha:0.11},0).wait(1).to({x:57.4,alpha:0.179},0).wait(1).to({x:62.5,alpha:0.281},0).wait(1).to({x:70.1,alpha:0.433},0).wait(1).to({x:80,alpha:0.63},0).wait(1).to({x:88.6,alpha:0.803},0).wait(1).to({x:93.9,alpha:0.909},0).wait(1).to({x:96.7,alpha:0.966},0).wait(1).to({x:98.1,alpha:0.993},0).wait(1).to({x:98.4,alpha:1},0).wait(65).to({startPosition:0},0).wait(1).to({x:98.8,alpha:0.992},0).wait(1).to({x:100.2,alpha:0.965},0).wait(1).to({x:103,alpha:0.908},0).wait(1).to({x:108.3,alpha:0.802},0).wait(1).to({x:118.1,alpha:0.606},0).wait(1).to({x:133.1,alpha:0.305},0).wait(1).to({x:143.4,alpha:0.1},0).wait(1).to({x:147.4,alpha:0.019},0).wait(1).to({x:148.4,alpha:0},0).to({_off:true},1).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(-50,0,285.8,55.1);


(lib.texto4 = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// texto4b
	this.instance = new lib.texto4b("synched",0);
	this.instance.setTransform(137.8,38.7,1,1,0,0,0,50.6,7);
	this.instance.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(1).to({x:137.7,alpha:0.002},0).wait(1).to({x:137.5,alpha:0.007},0).wait(1).to({x:137,alpha:0.017},0).wait(1).to({x:136.2,alpha:0.031},0).wait(1).to({x:135.2,alpha:0.052},0).wait(1).to({x:133.8,alpha:0.081},0).wait(1).to({x:131.8,alpha:0.119},0).wait(1).to({x:129.3,alpha:0.17},0).wait(1).to({x:125.9,alpha:0.239},0).wait(1).to({x:121.3,alpha:0.33},0).wait(1).to({x:115.2,alpha:0.452},0).wait(1).to({x:107.9,alpha:0.598},0).wait(1).to({x:100.9,alpha:0.738},0).wait(1).to({x:95.6,alpha:0.843},0).wait(1).to({x:92.2,alpha:0.913},0).wait(1).to({x:90,alpha:0.957},0).wait(1).to({x:88.7,alpha:0.983},0).wait(1).to({x:88,alpha:0.996},0).wait(1).to({x:87.8,alpha:1},0).wait(1));

	// texto4a
	this.instance_1 = new lib.texto4a("synched",0);
	this.instance_1.setTransform(37.7,17.2,1,1,0,0,0,87.7,7.2);
	this.instance_1.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(1).to({regX:87.1,regY:-0.5,x:37.2,y:9.5,alpha:0.002},0).wait(1).to({x:37.5,alpha:0.007},0).wait(1).to({x:38,alpha:0.017},0).wait(1).to({x:38.7,alpha:0.031},0).wait(1).to({x:39.8,alpha:0.052},0).wait(1).to({x:41.2,alpha:0.081},0).wait(1).to({x:43.1,alpha:0.119},0).wait(1).to({x:45.7,alpha:0.17},0).wait(1).to({x:49.1,alpha:0.239},0).wait(1).to({x:53.7,alpha:0.33},0).wait(1).to({x:59.8,alpha:0.452},0).wait(1).to({x:67.1,alpha:0.598},0).wait(1).to({x:74.1,alpha:0.738},0).wait(1).to({x:79.3,alpha:0.843},0).wait(1).to({x:82.8,alpha:0.913},0).wait(1).to({x:85,alpha:0.957},0).wait(1).to({x:86.3,alpha:0.983},0).wait(1).to({x:87,alpha:0.996},0).wait(1).to({regX:87.7,regY:7.2,x:87.7,y:17.2,alpha:1},0).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(-33.5,-5.2,222,50.9);


(lib.texto3 = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// texto3a
	this.instance = new lib.texto3a("synched",0);
	this.instance.setTransform(-38.2,19.8,1,1,0,0,0,11.8,12.6);
	this.instance.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(1).to({x:-38.1,alpha:0.002},0).wait(1).to({x:-37.8,alpha:0.007},0).wait(1).to({x:-37.4,alpha:0.017},0).wait(1).to({x:-36.7,alpha:0.031},0).wait(1).to({x:-35.8,alpha:0.052},0).wait(1).to({x:-34.4,alpha:0.081},0).wait(1).to({x:-32.7,alpha:0.119},0).wait(1).to({x:-30.3,alpha:0.17},0).wait(1).to({x:-27.2,alpha:0.239},0).wait(1).to({x:-23,alpha:0.33},0).wait(1).to({x:-17.4,alpha:0.452},0).wait(1).to({x:-10.7,alpha:0.598},0).wait(1).to({x:-4.2,alpha:0.738},0).wait(1).to({x:0.6,alpha:0.843},0).wait(1).to({x:3.8,alpha:0.913},0).wait(1).to({x:5.8,alpha:0.957},0).wait(1).to({x:7,alpha:0.983},0).wait(1).to({x:7.6,alpha:0.996},0).wait(1).to({x:7.8,alpha:1},0).wait(1));

	// texto3b
	this.instance_1 = new lib.texto3b("synched",0);
	this.instance_1.setTransform(51.4,20.2,0.44,0.44,0,0,0,24.1,20.1);
	this.instance_1.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(1).to({regX:26.5,regY:20.6,scaleX:0.44,scaleY:0.44,x:52.4,y:20.4,alpha:0.002},0).wait(1).to({scaleX:0.44,scaleY:0.44,alpha:0.007},0).wait(1).to({scaleX:0.45,scaleY:0.45,alpha:0.017},0).wait(1).to({scaleX:0.46,scaleY:0.46,y:20.3,alpha:0.031},0).wait(1).to({scaleX:0.47,scaleY:0.47,x:52.5,y:20.4,alpha:0.052},0).wait(1).to({scaleX:0.49,scaleY:0.49,x:52.4,alpha:0.081},0).wait(1).to({scaleX:0.51,scaleY:0.51,alpha:0.119},0).wait(1).to({scaleX:0.54,scaleY:0.54,x:52.5,alpha:0.17},0).wait(1).to({scaleX:0.57,scaleY:0.57,alpha:0.239},0).wait(1).to({scaleX:0.63,scaleY:0.63,x:52.6,alpha:0.33},0).wait(1).to({scaleX:0.69,scaleY:0.69,y:20.5,alpha:0.452},0).wait(1).to({scaleX:0.78,scaleY:0.78,x:52.7,alpha:0.598},0).wait(1).to({scaleX:0.85,scaleY:0.85,x:52.8,y:20.6,alpha:0.738},0).wait(1).to({scaleX:0.91,scaleY:0.91,alpha:0.843},0).wait(1).to({scaleX:0.95,scaleY:0.95,x:52.9,alpha:0.913},0).wait(1).to({scaleX:0.98,scaleY:0.98,alpha:0.957},0).wait(1).to({scaleX:0.99,scaleY:0.99,alpha:0.983},0).wait(1).to({scaleX:1,scaleY:1,alpha:0.996},0).wait(1).to({regX:24.1,regY:20.2,scaleX:1,scaleY:1,x:50.6,y:20.2,alpha:1},0).wait(1));

	// texto3c
	this.instance_2 = new lib.texto3c("synched",0);
	this.instance_2.setTransform(149.5,21.5,1,1,0,0,0,13.3,11.8);
	this.instance_2.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance_2).wait(1).to({regX:16,regY:11.9,x:152.1,y:21.6,alpha:0.002},0).wait(1).to({x:151.8,alpha:0.007},0).wait(1).to({x:151.3,alpha:0.017},0).wait(1).to({x:150.5,alpha:0.031},0).wait(1).to({x:149.3,alpha:0.052},0).wait(1).to({x:147.8,alpha:0.081},0).wait(1).to({x:145.7,alpha:0.119},0).wait(1).to({x:142.9,alpha:0.17},0).wait(1).to({x:139.3,alpha:0.239},0).wait(1).to({x:134.3,alpha:0.33},0).wait(1).to({x:127.7,alpha:0.452},0).wait(1).to({x:119.8,alpha:0.598},0).wait(1).to({x:112.2,alpha:0.738},0).wait(1).to({x:106.6,alpha:0.843},0).wait(1).to({x:102.8,alpha:0.913},0).wait(1).to({x:100.4,alpha:0.957},0).wait(1).to({x:99,alpha:0.983},0).wait(1).to({x:98.3,alpha:0.996},0).wait(1).to({regX:13.3,regY:11.8,x:95.4,y:21.5,alpha:1},0).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(-50,7.2,218.3,26);


(lib.texto2 = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// Camada 1
	this.instance = new lib.texto2a("synched",0);
	this.instance.setTransform(30.7,7.1,1,1,0,0,0,30.7,7.1);
	this.instance.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(1).to({alpha:0.002},0).wait(1).to({alpha:0.007},0).wait(1).to({alpha:0.017},0).wait(1).to({alpha:0.031},0).wait(1).to({alpha:0.052},0).wait(1).to({alpha:0.081},0).wait(1).to({alpha:0.119},0).wait(1).to({alpha:0.17},0).wait(1).to({alpha:0.239},0).wait(1).to({alpha:0.33},0).wait(1).to({alpha:0.452},0).wait(1).to({alpha:0.598},0).wait(1).to({alpha:0.738},0).wait(1).to({alpha:0.843},0).wait(1).to({alpha:0.913},0).wait(1).to({alpha:0.957},0).wait(1).to({alpha:0.983},0).wait(1).to({alpha:0.996},0).wait(1).to({alpha:1},0).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(0,0,61.5,14.3);


(lib.texto1 = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// texto1a
	this.instance = new lib.texto1a("synched",0);
	this.instance.setTransform(-19.7,11.6,1,1,0,0,0,30.3,11.6);
	this.instance.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(1).to({x:-19.6,alpha:0.002},0).wait(1).to({x:-19.3,alpha:0.007},0).wait(1).to({x:-18.8,alpha:0.017},0).wait(1).to({x:-18.1,alpha:0.031},0).wait(1).to({x:-17,alpha:0.052},0).wait(1).to({x:-15.6,alpha:0.081},0).wait(1).to({x:-13.7,alpha:0.119},0).wait(1).to({x:-11.1,alpha:0.17},0).wait(1).to({x:-7.7,alpha:0.239},0).wait(1).to({x:-3.1,alpha:0.33},0).wait(1).to({x:3,alpha:0.452},0).wait(1).to({x:10.3,alpha:0.598},0).wait(1).to({x:17.3,alpha:0.738},0).wait(1).to({x:22.5,alpha:0.843},0).wait(1).to({x:26,alpha:0.913},0).wait(1).to({x:28.2,alpha:0.957},0).wait(1).to({x:29.5,alpha:0.983},0).wait(1).to({x:30.2,alpha:0.996},0).wait(1).to({x:30.3,alpha:1},0).wait(1));

	// texto1b
	this.instance_1 = new lib.texto1b("synched",0);
	this.instance_1.setTransform(169.7,11.6,1,1,0,0,0,50,11.6);
	this.instance_1.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(1).to({regX:-20,regY:40.1,x:99.6,y:40.1,alpha:0.002},0).wait(1).to({x:99.3,alpha:0.007},0).wait(1).to({x:98.8,alpha:0.017},0).wait(1).to({x:98.1,alpha:0.031},0).wait(1).to({x:97,alpha:0.052},0).wait(1).to({x:95.6,alpha:0.081},0).wait(1).to({x:93.7,alpha:0.119},0).wait(1).to({x:91.1,alpha:0.17},0).wait(1).to({x:87.7,alpha:0.239},0).wait(1).to({x:83.1,alpha:0.33},0).wait(1).to({x:77,alpha:0.452},0).wait(1).to({x:69.7,alpha:0.598},0).wait(1).to({x:62.7,alpha:0.738},0).wait(1).to({x:57.5,alpha:0.843},0).wait(1).to({x:54,alpha:0.913},0).wait(1).to({x:51.8,alpha:0.957},0).wait(1).to({x:50.5,alpha:0.983},0).wait(1).to({x:49.8,alpha:0.996},0).wait(1).to({regX:50,regY:11.6,x:119.7,y:11.6,alpha:1},0).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(-50,0,199.7,51.7);


(lib.texto = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// texto4
	this.instance = new lib.texto4("synched",0,false);
	this.instance.setTransform(268.7,43.9,0.636,0.636,11.2,0,0,87.6,17.9);
	this.instance.alpha = 0;
	this.instance._off = true;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(6).to({_off:false},0).wait(1).to({regX:77.4,regY:20.2,scaleX:0.64,scaleY:0.64,x:262.1,y:44.1,alpha:0.002,startPosition:1},0).wait(1).to({scaleX:0.64,scaleY:0.64,rotation:11.1,x:262.4,y:43.9,alpha:0.009,startPosition:2},0).wait(1).to({scaleX:0.64,scaleY:0.64,rotation:11,x:263.1,y:43.7,alpha:0.021,startPosition:3},0).wait(1).to({scaleX:0.65,scaleY:0.65,rotation:10.7,x:264,y:43.4,alpha:0.04,startPosition:4},0).wait(1).to({scaleX:0.66,scaleY:0.66,rotation:10.4,x:265.4,y:42.9,alpha:0.068,startPosition:5},0).wait(1).to({scaleX:0.68,scaleY:0.68,rotation:10,x:267.4,y:42.2,alpha:0.107,startPosition:6},0).wait(1).to({scaleX:0.69,scaleY:0.69,rotation:9.4,x:270,y:41.4,alpha:0.16,startPosition:7},0).wait(1).to({scaleX:0.72,scaleY:0.72,rotation:8.6,x:273.8,y:40.1,alpha:0.234,startPosition:8},0).wait(1).to({scaleX:0.76,scaleY:0.76,rotation:7.4,x:278.9,y:38.4,alpha:0.337,startPosition:9},0).wait(1).to({scaleX:0.81,scaleY:0.81,rotation:5.9,x:285.9,y:36.1,alpha:0.477,startPosition:10},0).wait(1).to({scaleX:0.87,scaleY:0.87,rotation:4,x:294.3,y:33.3,alpha:0.642,startPosition:11},0).wait(1).to({scaleX:0.92,scaleY:0.92,rotation:2.4,x:301.5,y:31.1,alpha:0.786,startPosition:12},0).wait(1).to({scaleX:0.96,scaleY:0.96,rotation:1.3,x:306.5,y:29.5,alpha:0.884,startPosition:13},0).wait(1).to({scaleX:0.98,scaleY:0.98,rotation:0.6,x:309.6,y:28.6,alpha:0.944,startPosition:14},0).wait(1).to({scaleX:0.99,scaleY:0.99,rotation:0.2,x:311.3,y:28,alpha:0.978,startPosition:15},0).wait(1).to({scaleX:1,scaleY:1,rotation:0.1,x:312.2,y:27.7,alpha:0.995,startPosition:16},0).wait(1).to({regX:87.7,regY:17.8,scaleX:1,scaleY:1,rotation:0,x:322.7,y:25.3,alpha:1,startPosition:19},0).wait(7));

	// texto3
	this.instance_1 = new lib.texto3("synched",0,false);
	this.instance_1.setTransform(164.2,31.9,0.78,0.78,11.2,0,0,56.4,20.2);
	this.instance_1.alpha = 0;
	this.instance_1._off = true;

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(4).to({_off:false},0).wait(1).to({regX:59.1,regY:20.6,scaleX:0.78,scaleY:0.78,x:166.1,y:32.6,alpha:0.002,startPosition:1},0).wait(1).to({scaleX:0.78,scaleY:0.78,rotation:11.1,alpha:0.009,startPosition:2},0).wait(1).to({scaleX:0.79,scaleY:0.79,rotation:11,x:166,y:32.7,alpha:0.021,startPosition:3},0).wait(1).to({scaleX:0.8,scaleY:0.8,rotation:10.7,x:165.9,y:32.8,alpha:0.04,startPosition:4},0).wait(1).to({scaleX:0.81,scaleY:0.81,rotation:10.4,x:165.8,y:33,alpha:0.068,startPosition:5},0).wait(1).to({scaleX:0.83,scaleY:0.83,rotation:10,x:165.6,y:33.3,alpha:0.107,startPosition:6},0).wait(1).to({scaleX:0.85,scaleY:0.85,rotation:9.4,x:165.3,y:33.6,alpha:0.16,startPosition:7},0).wait(1).to({scaleX:0.88,scaleY:0.88,rotation:8.6,x:164.9,y:34.1,alpha:0.234,startPosition:8},0).wait(1).to({scaleX:0.93,scaleY:0.93,rotation:7.4,x:164.4,y:34.8,alpha:0.337,startPosition:9},0).wait(1).to({scaleX:0.99,scaleY:0.99,rotation:5.9,x:163.7,y:35.8,alpha:0.477,startPosition:10},0).wait(1).to({scaleX:1.07,scaleY:1.07,rotation:4,x:162.8,y:36.8,alpha:0.642,startPosition:11},0).wait(1).to({scaleX:1.13,scaleY:1.13,rotation:2.4,x:162.1,y:37.7,alpha:0.786,startPosition:12},0).wait(1).to({scaleX:1.17,scaleY:1.17,rotation:1.3,x:161.6,y:38.4,alpha:0.884,startPosition:13},0).wait(1).to({scaleX:1.2,scaleY:1.2,rotation:0.6,x:161.3,y:38.8,alpha:0.944,startPosition:14},0).wait(1).to({scaleX:1.22,scaleY:1.22,rotation:0.2,x:161.1,y:39,alpha:0.978,startPosition:15},0).wait(1).to({scaleX:1.22,scaleY:1.22,rotation:0.1,x:161,alpha:0.995,startPosition:16},0).wait(1).to({regX:56.4,regY:20.2,scaleX:1.23,scaleY:1.23,rotation:0,x:157.7,y:38.6,alpha:1,startPosition:19},0).wait(9));

	// texto2
	this.instance_2 = new lib.texto2("synched",0,false);
	this.instance_2.setTransform(168.8,8,0.78,0.78,11.2,0,0,30.8,7);
	this.instance_2.alpha = 0;
	this.instance_2._off = true;

	this.timeline.addTween(cjs.Tween.get(this.instance_2).wait(2).to({_off:false},0).wait(1).to({regX:30.7,regY:7.1,scaleX:0.78,scaleY:0.78,x:168.6,y:8.1,alpha:0.002,startPosition:1},0).wait(1).to({scaleX:0.78,scaleY:0.78,rotation:11.1,y:8,alpha:0.009,startPosition:2},0).wait(1).to({scaleX:0.79,scaleY:0.79,rotation:11,x:168.4,y:7.9,alpha:0.021,startPosition:3},0).wait(1).to({scaleX:0.8,scaleY:0.8,rotation:10.7,x:168.2,y:7.7,alpha:0.04,startPosition:4},0).wait(1).to({scaleX:0.81,scaleY:0.81,rotation:10.4,x:167.9,y:7.6,alpha:0.068,startPosition:5},0).wait(1).to({scaleX:0.83,scaleY:0.83,rotation:10,x:167.5,y:7.3,alpha:0.107,startPosition:6},0).wait(1).to({scaleX:0.85,scaleY:0.85,rotation:9.4,x:166.8,y:6.9,alpha:0.16,startPosition:7},0).wait(1).to({scaleX:0.88,scaleY:0.88,rotation:8.6,x:166,y:6.3,alpha:0.234,startPosition:8},0).wait(1).to({scaleX:0.93,scaleY:0.93,rotation:7.4,x:164.8,y:5.6,alpha:0.337,startPosition:9},0).wait(1).to({scaleX:0.99,scaleY:0.99,rotation:5.9,x:163.3,y:4.5,alpha:0.477,startPosition:10},0).wait(1).to({scaleX:1.07,scaleY:1.07,rotation:4,x:161.4,y:3.3,alpha:0.642,startPosition:11},0).wait(1).to({scaleX:1.13,scaleY:1.13,rotation:2.4,x:159.8,y:2.2,alpha:0.786,startPosition:12},0).wait(1).to({scaleX:1.17,scaleY:1.17,rotation:1.3,x:158.6,y:1.5,alpha:0.884,startPosition:13},0).wait(1).to({scaleX:1.2,scaleY:1.2,rotation:0.6,x:157.9,y:1.1,alpha:0.944,startPosition:14},0).wait(1).to({scaleX:1.22,scaleY:1.22,rotation:0.2,x:157.6,y:0.8,alpha:0.978,startPosition:15},0).wait(1).to({scaleX:1.22,scaleY:1.22,rotation:0.1,x:157.4,y:0.7,alpha:0.995,startPosition:16},0).wait(1).to({scaleX:1.23,scaleY:1.23,rotation:0,y:0.5,alpha:1,startPosition:19},0).wait(11));

	// texto1
	this.instance_3 = new lib.texto1("synched",0,false);
	this.instance_3.setTransform(99.7,3.1,0.636,0.636,11.2,0,0,84.8,11.5);
	this.instance_3.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance_3).wait(1).to({regX:49.8,regY:25.8,scaleX:0.64,scaleY:0.64,x:75.9,y:7.8,alpha:0.002,startPosition:1},0).wait(1).to({scaleX:0.64,scaleY:0.64,rotation:11.1,x:75.5,y:8,alpha:0.009,startPosition:2},0).wait(1).to({scaleX:0.64,scaleY:0.64,rotation:11,x:74.7,y:8.2,alpha:0.021,startPosition:3},0).wait(1).to({scaleX:0.65,scaleY:0.65,rotation:10.7,x:73.5,y:8.5,alpha:0.04,startPosition:4},0).wait(1).to({scaleX:0.66,scaleY:0.66,rotation:10.4,x:71.7,y:9,alpha:0.068,startPosition:5},0).wait(1).to({scaleX:0.68,scaleY:0.68,rotation:10,x:69.4,y:9.8,alpha:0.107,startPosition:6},0).wait(1).to({scaleX:0.69,scaleY:0.69,rotation:9.4,x:66,y:10.7,alpha:0.16,startPosition:7},0).wait(1).to({scaleX:0.72,scaleY:0.72,rotation:8.6,x:61.4,y:12.2,alpha:0.234,startPosition:8},0).wait(1).to({scaleX:0.76,scaleY:0.76,rotation:7.4,x:55,y:14.2,alpha:0.337,startPosition:9},0).wait(1).to({scaleX:0.81,scaleY:0.81,rotation:5.9,x:46.3,y:17,alpha:0.477,startPosition:10},0).wait(1).to({scaleX:0.87,scaleY:0.87,rotation:4,x:36.2,y:20.5,alpha:0.642,startPosition:11},0).wait(1).to({scaleX:0.92,scaleY:0.92,rotation:2.4,x:27.4,y:23.6,alpha:0.786,startPosition:12},0).wait(1).to({scaleX:0.96,scaleY:0.96,rotation:1.3,x:21.5,y:25.8,alpha:0.884,startPosition:13},0).wait(1).to({scaleX:0.98,scaleY:0.98,rotation:0.6,x:17.8,y:27.1,alpha:0.944,startPosition:14},0).wait(1).to({scaleX:0.99,scaleY:0.99,rotation:0.2,x:15.8,y:27.8,alpha:0.978,startPosition:15},0).wait(1).to({scaleX:1,scaleY:1,rotation:0.1,x:14.8,y:28.2,alpha:0.995,startPosition:16},0).wait(1).to({regX:84.9,regY:11.6,scaleX:1,scaleY:1,rotation:0,x:49.4,y:14.1,alpha:1,startPosition:19},0).wait(13));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(14.2,-19.4,123.9,55.4);


(lib.logo_1 = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// mascara (mask)
	var mask = new cjs.Shape();
	mask._off = true;
	var mask_graphics_0 = new cjs.Graphics().p("AGZEJIAAihIALAAIAAChg");
	var mask_graphics_1 = new cjs.Graphics().p("AGYEJIAAihIAMAAIAAChg");
	var mask_graphics_2 = new cjs.Graphics().p("AGTEJIAAihIAQAAIAAChg");
	var mask_graphics_3 = new cjs.Graphics().p("AGJEJIAAihIAaAAIAAChg");
	var mask_graphics_4 = new cjs.Graphics().p("AF6EJIAAihIApAAIAAChg");
	var mask_graphics_5 = new cjs.Graphics().p("AFlEJIAAihIA+AAIAAChg");
	var mask_graphics_6 = new cjs.Graphics().p("AFHEJIAAihIBcAAIAAChg");
	var mask_graphics_7 = new cjs.Graphics().p("AEeEJIAAihICFAAIAAChg");
	var mask_graphics_8 = new cjs.Graphics().p("ADnEJIAAihIC8AAIAAChg");
	var mask_graphics_9 = new cjs.Graphics().p("ACdEJIAAihIEFAAIAAChg");
	var mask_graphics_10 = new cjs.Graphics().p("AA5EJIAAihIFpAAIAAChg");
	var mask_graphics_11 = new cjs.Graphics().p("Ag+EJIAAihIHfAAIAAChg");
	var mask_graphics_12 = new cjs.Graphics().p("Ai1EJIAAihIJVAAIAAChg");
	var mask_graphics_13 = new cjs.Graphics().p("AkTEJIAAihIKzAAIAAChg");
	var mask_graphics_14 = new cjs.Graphics().p("AlUEJIAAihIL0AAIAAChg");
	var mask_graphics_15 = new cjs.Graphics().p("AmBEJIAAihIMgAAIAAChg");
	var mask_graphics_16 = new cjs.Graphics().p("AmdEJIAAihIM8AAIAAChg");
	var mask_graphics_17 = new cjs.Graphics().p("AmmEJIAAihINNAAIAAChg");
	var mask_graphics_18 = new cjs.Graphics().p("AmrEJIAAihINXAAIAAChg");
	var mask_graphics_19 = new cjs.Graphics().p("AmsEJIAAihINZAAIAAChg");

	this.timeline.addTween(cjs.Tween.get(mask).to({graphics:mask_graphics_0,x:42,y:26.5}).wait(1).to({graphics:mask_graphics_1,x:42,y:26.5}).wait(1).to({graphics:mask_graphics_2,x:42,y:26.5}).wait(1).to({graphics:mask_graphics_3,x:42,y:26.5}).wait(1).to({graphics:mask_graphics_4,x:42,y:26.5}).wait(1).to({graphics:mask_graphics_5,x:42,y:26.5}).wait(1).to({graphics:mask_graphics_6,x:42,y:26.5}).wait(1).to({graphics:mask_graphics_7,x:41.9,y:26.5}).wait(1).to({graphics:mask_graphics_8,x:41.9,y:26.5}).wait(1).to({graphics:mask_graphics_9,x:41.9,y:26.5}).wait(1).to({graphics:mask_graphics_10,x:41.8,y:26.5}).wait(1).to({graphics:mask_graphics_11,x:41.8,y:26.5}).wait(1).to({graphics:mask_graphics_12,x:41.7,y:26.5}).wait(1).to({graphics:mask_graphics_13,x:41.6,y:26.5}).wait(1).to({graphics:mask_graphics_14,x:41.6,y:26.5}).wait(1).to({graphics:mask_graphics_15,x:41.6,y:26.5}).wait(1).to({graphics:mask_graphics_16,x:41.6,y:26.5}).wait(1).to({graphics:mask_graphics_17,x:40.7,y:26.5}).wait(1).to({graphics:mask_graphics_18,x:40.2,y:26.5}).wait(1).to({graphics:mask_graphics_19,x:40,y:26.5}).wait(10).to({graphics:null,x:0,y:0}).wait(1));

	// Camada 6
	this.instance = new lib.logo_vermelho("synched",0);
	this.instance.setTransform(39.8,46,1,1,0,0,0,34.8,5.5);

	this.instance.mask = mask;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(14).to({startPosition:0},0).wait(1).to({alpha:0.996},0).wait(1).to({alpha:0.984},0).wait(1).to({alpha:0.962},0).wait(1).to({alpha:0.925},0).wait(1).to({alpha:0.867},0).wait(1).to({alpha:0.781},0).wait(1).to({alpha:0.649},0).wait(1).to({alpha:0.467},0).wait(1).to({alpha:0.28},0).wait(1).to({alpha:0.149},0).wait(1).to({alpha:0.071},0).wait(1).to({alpha:0.027},0).wait(1).to({alpha:0.006},0).wait(1).to({alpha:0},0).to({_off:true},1).wait(1));

	// logo
	this.instance_1 = new lib.logo();

	this.instance_1.mask = mask;

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(30));

	// mascara (mask)
	var mask_1 = new cjs.Shape();
	mask_1._off = true;
	var mask_1_graphics_0 = new cjs.Graphics().p("AgNC4IAAlvIAJAAIAAFvg");
	var mask_1_graphics_1 = new cjs.Graphics().p("AgNC4IAAlvIALAAIAAFvg");
	var mask_1_graphics_2 = new cjs.Graphics().p("AgOC4IAAlvIAPAAIAAFvg");
	var mask_1_graphics_3 = new cjs.Graphics().p("AgOC4IAAlvIAZAAIAAFvg");
	var mask_1_graphics_4 = new cjs.Graphics().p("AgTC4IAAlvIAnAAIAAFvg");
	var mask_1_graphics_5 = new cjs.Graphics().p("AgeC4IAAlvIA9AAIAAFvg");
	var mask_1_graphics_6 = new cjs.Graphics().p("AgsC4IAAlvIBaAAIAAFvg");
	var mask_1_graphics_7 = new cjs.Graphics().p("AhBC4IAAlvICDAAIAAFvg");
	var mask_1_graphics_8 = new cjs.Graphics().p("AhcC4IAAlvIC5AAIAAFvg");
	var mask_1_graphics_9 = new cjs.Graphics().p("AiBC4IAAlvIEDAAIAAFvg");
	var mask_1_graphics_10 = new cjs.Graphics().p("AizC4IAAlvIFnAAIAAFvg");
	var mask_1_graphics_11 = new cjs.Graphics().p("AjvC4IAAlvIHfAAIAAFvg");
	var mask_1_graphics_12 = new cjs.Graphics().p("AkqC4IAAlvIJVAAIAAFvg");
	var mask_1_graphics_13 = new cjs.Graphics().p("AlZC4IAAlvIKzAAIAAFvg");
	var mask_1_graphics_14 = new cjs.Graphics().p("Al5C4IAAlvILzAAIAAFvg");
	var mask_1_graphics_15 = new cjs.Graphics().p("AmPC4IAAlvIMfAAIAAFvg");
	var mask_1_graphics_16 = new cjs.Graphics().p("AmeC4IAAlvIM9AAIAAFvg");
	var mask_1_graphics_17 = new cjs.Graphics().p("AmmC4IAAlvINNAAIAAFvg");
	var mask_1_graphics_18 = new cjs.Graphics().p("AmrC4IAAlvINXAAIAAFvg");
	var mask_1_graphics_19 = new cjs.Graphics().p("AmsC4IAAlvINZAAIAAFvg");

	this.timeline.addTween(cjs.Tween.get(mask_1).to({graphics:mask_1_graphics_0,x:-1.5,y:18.5}).wait(1).to({graphics:mask_1_graphics_1,x:-1.5,y:18.5}).wait(1).to({graphics:mask_1_graphics_2,x:-1.5,y:18.5}).wait(1).to({graphics:mask_1_graphics_3,x:-1.5,y:18.5}).wait(1).to({graphics:mask_1_graphics_4,x:-0.9,y:18.5}).wait(1).to({graphics:mask_1_graphics_5,x:0.1,y:18.5}).wait(1).to({graphics:mask_1_graphics_6,x:1.6,y:18.5}).wait(1).to({graphics:mask_1_graphics_7,x:3.6,y:18.5}).wait(1).to({graphics:mask_1_graphics_8,x:6.3,y:18.5}).wait(1).to({graphics:mask_1_graphics_9,x:10.1,y:18.5}).wait(1).to({graphics:mask_1_graphics_10,x:15,y:18.5}).wait(1).to({graphics:mask_1_graphics_11,x:21,y:18.5}).wait(1).to({graphics:mask_1_graphics_12,x:26.9,y:18.5}).wait(1).to({graphics:mask_1_graphics_13,x:31.6,y:18.5}).wait(1).to({graphics:mask_1_graphics_14,x:34.8,y:18.5}).wait(1).to({graphics:mask_1_graphics_15,x:37,y:18.5}).wait(1).to({graphics:mask_1_graphics_16,x:38.5,y:18.5}).wait(1).to({graphics:mask_1_graphics_17,x:39.3,y:18.5}).wait(1).to({graphics:mask_1_graphics_18,x:39.8,y:18.5}).wait(1).to({graphics:mask_1_graphics_19,x:40,y:18.5}).wait(10).to({graphics:null,x:0,y:0}).wait(1));

	// Camada 5
	this.instance_2 = new lib.logo_azul("synched",0);
	this.instance_2.setTransform(39.8,17.8,1,1,0,0,0,34.8,10.3);

	this.instance_2.mask = mask_1;

	this.timeline.addTween(cjs.Tween.get(this.instance_2).wait(14).to({startPosition:0},0).wait(1).to({alpha:0.996},0).wait(1).to({alpha:0.984},0).wait(1).to({alpha:0.962},0).wait(1).to({alpha:0.925},0).wait(1).to({alpha:0.867},0).wait(1).to({alpha:0.781},0).wait(1).to({alpha:0.649},0).wait(1).to({alpha:0.467},0).wait(1).to({alpha:0.28},0).wait(1).to({alpha:0.149},0).wait(1).to({alpha:0.071},0).wait(1).to({alpha:0.027},0).wait(1).to({alpha:0.006},0).wait(1).to({alpha:0},0).to({_off:true},1).wait(1));

	// logo
	this.instance_3 = new lib.logo();

	this.instance_3.mask = mask_1;

	this.timeline.addTween(cjs.Tween.get(this.instance_3).to({_off:true},29).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = null;


(lib.fundo = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// Camada 2
	this.instance = new lib.fundo_efeito("synched",0);
	this.instance.setTransform(150,125,1,1,0,0,0,150,125);
	this.instance.alpha = 0;
	this.instance._off = true;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(89).to({_off:false},0).wait(1).to({regX:364,regY:45,x:364,y:45,alpha:0.001},0).wait(1).to({alpha:0.006},0).wait(1).to({alpha:0.013},0).wait(1).to({alpha:0.025},0).wait(1).to({alpha:0.042},0).wait(1).to({alpha:0.064},0).wait(1).to({alpha:0.094},0).wait(1).to({alpha:0.133},0).wait(1).to({alpha:0.185},0).wait(1).to({alpha:0.253},0).wait(1).to({alpha:0.343},0).wait(1).to({alpha:0.457},0).wait(1).to({alpha:0.584},0).wait(1).to({alpha:0.695},0).wait(1).to({alpha:0.776},0).wait(1).to({alpha:0.83},0).wait(1).to({alpha:0.864},0).wait(1).to({alpha:0.885},0).wait(1).to({alpha:0.895},0).wait(1).to({regX:150,regY:125,x:150,y:125,alpha:0.898},0).wait(1));

	// Camada 4
	this.shape = new cjs.Shape();
	this.shape.graphics.lf(["#0167AD","rgba(1,103,173,0)"],[0,1],130.5,0,-130.4,0).s().p("A0XHEIAAuHMAovAAAIAAOHg");
	this.shape.setTransform(598,44.8);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.lf(["#0167AD","rgba(1,103,173,0)"],[0,1],-130.5,0,130.4,0).s().p("A0XHEIAAuHMAovAAAIAAOHg");
	this.shape_1.setTransform(130.5,45.2);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.shape_1},{t:this.shape}]}).wait(110));

	// Camada 3
	this.instance_1 = new lib.fundo_728x90();
	this.instance_1.setTransform(0.5,0.5);

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(110));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(0,-0.4,728.5,90.9);


(lib.botao = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// mascara (mask)
	var mask = new cjs.Shape();
	mask._off = true;
	var mask_graphics_0 = new cjs.Graphics().p("AD1EEIAAoHIAKAAIAAIHg");
	var mask_graphics_1 = new cjs.Graphics().p("ADzEEIAAoHIANAAIAAIHg");
	var mask_graphics_2 = new cjs.Graphics().p("ADwEEIAAoHIATAAIAAIHg");
	var mask_graphics_3 = new cjs.Graphics().p("ADpEEIAAoHIAhAAIAAIHg");
	var mask_graphics_4 = new cjs.Graphics().p("ADfEEIAAoHIA1AAIAAIHg");
	var mask_graphics_5 = new cjs.Graphics().p("ADQEEIAAoHIBTAAIAAIHg");
	var mask_graphics_6 = new cjs.Graphics().p("AC8EEIAAoHIB7AAIAAIHg");
	var mask_graphics_7 = new cjs.Graphics().p("ACiEEIAAoHICvAAIAAIHg");
	var mask_graphics_8 = new cjs.Graphics().p("AB+EEIAAoHID3AAIAAIHg");
	var mask_graphics_9 = new cjs.Graphics().p("ABPEEIAAoHIFVAAIAAIHg");
	var mask_graphics_10 = new cjs.Graphics().p("AAPEEIAAoHIHVAAIAAIHg");
	var mask_graphics_11 = new cjs.Graphics().p("AhEEEIAAoHIJ9AAIAAIHg");
	var mask_graphics_12 = new cjs.Graphics().p("AipEEIAAoHINHAAIAAIHg");
	var mask_graphics_13 = new cjs.Graphics().p("AkLEEIAAoHIQLAAIAAIHg");
	var mask_graphics_14 = new cjs.Graphics().p("AlUEEIAAoHISdAAIAAIHg");
	var mask_graphics_15 = new cjs.Graphics().p("AmEEEIAAoHIT9AAIAAIHg");
	var mask_graphics_16 = new cjs.Graphics().p("AmiEEIAAoHIU5AAIAAIHg");
	var mask_graphics_17 = new cjs.Graphics().p("Am1EEIAAoHIVfAAIAAIHg");
	var mask_graphics_18 = new cjs.Graphics().p("Am+EEIAAoHIVxAAIAAIHg");
	var mask_graphics_19 = new cjs.Graphics().p("AnBEEIAAoHIV3AAIAAIHg");

	this.timeline.addTween(cjs.Tween.get(mask).to({graphics:mask_graphics_0,x:25.5,y:26}).wait(1).to({graphics:mask_graphics_1,x:25.6,y:26}).wait(1).to({graphics:mask_graphics_2,x:26,y:26}).wait(1).to({graphics:mask_graphics_3,x:26.6,y:26}).wait(1).to({graphics:mask_graphics_4,x:27.7,y:26}).wait(1).to({graphics:mask_graphics_5,x:29.1,y:26}).wait(1).to({graphics:mask_graphics_6,x:31.1,y:26}).wait(1).to({graphics:mask_graphics_7,x:33.8,y:26}).wait(1).to({graphics:mask_graphics_8,x:37.3,y:26}).wait(1).to({graphics:mask_graphics_9,x:42.1,y:26}).wait(1).to({graphics:mask_graphics_10,x:48.5,y:26}).wait(1).to({graphics:mask_graphics_11,x:56.9,y:26}).wait(1).to({graphics:mask_graphics_12,x:67.1,y:26}).wait(1).to({graphics:mask_graphics_13,x:76.8,y:26}).wait(1).to({graphics:mask_graphics_14,x:84.1,y:26}).wait(1).to({graphics:mask_graphics_15,x:88.9,y:26}).wait(1).to({graphics:mask_graphics_16,x:92,y:26}).wait(1).to({graphics:mask_graphics_17,x:93.8,y:26}).wait(1).to({graphics:mask_graphics_18,x:94.7,y:26}).wait(1).to({graphics:mask_graphics_19,x:95,y:26}).wait(1));

	// botao_seta
	this.instance = new lib.botao_seta("synched",0);
	this.instance.setTransform(49.4,26.8,1,1,0,0,0,2.4,4.8);
	this.instance.alpha = 0;
	this.instance._off = true;

	this.instance.mask = mask;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(2).to({_off:false},0).wait(1).to({x:49.7,alpha:0.003},0).wait(1).to({x:50.8,alpha:0.011},0).wait(1).to({x:52.9,alpha:0.028},0).wait(1).to({x:56.1,alpha:0.054},0).wait(1).to({x:60.9,alpha:0.092},0).wait(1).to({x:67.9,alpha:0.148},0).wait(1).to({x:77.9,alpha:0.228},0).wait(1).to({x:92.5,alpha:0.345},0).wait(1).to({x:113,alpha:0.509},0).wait(1).to({x:136.3,alpha:0.695},0).wait(1).to({x:154.1,alpha:0.837},0).wait(1).to({x:164.8,alpha:0.923},0).wait(1).to({x:170.7,alpha:0.971},0).wait(1).to({x:173.6,alpha:0.994},0).wait(1).to({x:174.4,alpha:1},0).wait(3));

	// botao_texto
	this.instance_1 = new lib.botao_texto("synched",0);
	this.instance_1.setTransform(-37.2,26.9,1,1,0,0,0,74.8,4.9);
	this.instance_1.alpha = 0;
	this.instance_1._off = true;

	this.instance_1.mask = mask;

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(4).to({_off:false},0).wait(1).to({regX:96.8,regY:4.1,x:-14.8,y:26.1,alpha:0.003},0).wait(1).to({x:-13.7,alpha:0.011},0).wait(1).to({x:-11.7,alpha:0.028},0).wait(1).to({x:-8.4,alpha:0.054},0).wait(1).to({x:-3.6,alpha:0.092},0).wait(1).to({x:3.4,alpha:0.148},0).wait(1).to({x:13.4,alpha:0.228},0).wait(1).to({x:28,alpha:0.345},0).wait(1).to({x:48.4,alpha:0.509},0).wait(1).to({x:71.7,alpha:0.695},0).wait(1).to({x:89.5,alpha:0.837},0).wait(1).to({x:100.2,alpha:0.923},0).wait(1).to({x:106.1,alpha:0.971},0).wait(1).to({x:109,alpha:0.994},0).wait(1).to({regX:74.8,regY:4.9,x:87.8,y:26.9,alpha:1},0).wait(1));

	// botao_base
	this.instance_2 = new lib.botao_base("synched",0);
	this.instance_2.setTransform(95,41,1,0.404,0,0,0,95,26);

	this.instance_2.mask = mask;

	this.timeline.addTween(cjs.Tween.get(this.instance_2).wait(1).to({regX:120.3,scaleY:0.41,x:120.3},0).wait(1).to({scaleY:0.41,y:40.9},0).wait(1).to({scaleY:0.41,y:40.7},0).wait(1).to({scaleY:0.42,y:40.5},0).wait(1).to({scaleY:0.44,y:40.2},0).wait(1).to({scaleY:0.45,y:39.8},0).wait(1).to({scaleY:0.48,y:39.2},0).wait(1).to({scaleY:0.51,y:38.5},0).wait(1).to({scaleY:0.55,y:37.4},0).wait(1).to({scaleY:0.6,y:36},0).wait(1).to({scaleY:0.67,y:34.2},0).wait(1).to({scaleY:0.76,y:32},0).wait(1).to({scaleY:0.84,y:29.9},0).wait(1).to({scaleY:0.91,y:28.3},0).wait(1).to({scaleY:0.95,y:27.3},0).wait(1).to({scaleY:0.97,y:26.7},0).wait(1).to({scaleY:0.99,y:26.3},0).wait(1).to({scaleY:1,y:26.1},0).wait(1).to({regX:95,scaleY:1,x:95,y:26},0).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(50.5,30.5,0.5,21);


(lib.geral = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// timeline functions:
	this.frame_140 = function() {
		this.stop();
	}

	// actions tween:
	this.timeline.addTween(cjs.Tween.get(this).wait(140).call(this.frame_140).wait(1));

	// texto
	this.instance = new lib.texto("synched",0,false);
	this.instance.setTransform(148.7,94.8,1,1,0,0,0,87.7,77.8);
	this.instance._off = true;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(109).to({_off:false},0).wait(32));

	// botao
	this.instance_1 = new lib.botao("synched",0,false);
	this.instance_1.setTransform(518,46,1,1,0,0,0,95,26);
	this.instance_1._off = true;

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(119).to({_off:false},0).wait(22));

	// titulo
	this.instance_2 = new lib.titulo("synched",0,false);
	this.instance_2.setTransform(139.4,47.6,1,1,0,0,0,98.4,27.6);
	this.instance_2._off = true;

	this.timeline.addTween(cjs.Tween.get(this.instance_2).wait(9).to({_off:false},0).to({_off:true},90).wait(42));

	// logo
	this.instance_3 = new lib.logo_1("synched",0,false);
	this.instance_3.setTransform(666,46,1,1,0,0,0,41,26);

	this.timeline.addTween(cjs.Tween.get(this.instance_3).wait(141));

	// fundo
	this.instance_4 = new lib.fundo("synched",0,false);
	this.instance_4.setTransform(150,125,1,1,0,0,0,150,125);

	this.timeline.addTween(cjs.Tween.get(this.instance_4).wait(141));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(0,-0.4,728.5,90.9);


// stage content:
(lib.RTBAllianzPlanoNacional728x90v2 = function() {
	this.initialize();

	// Camada 1
	this.instance = new lib.geral();
	this.instance.setTransform(150,125,1,1,0,0,0,150,125);

	this.addChild(this.instance);
}).prototype = p = new cjs.Container();
p.nominalBounds = new cjs.Rectangle(364,44.6,728.5,90.9);

})(lib = lib||{}, images = images||{}, createjs = createjs||{}, ss = ss||{});
var lib, images, createjs, ss;