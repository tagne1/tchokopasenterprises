import { Component, OnInit } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';

// Import the Image interface
import { Image } from './palm-carousel.image.interface';

@Component({
  selector: 'app-palm-carousel',
  templateUrl: './palm-carousel.component.html',
  styleUrls: ['./palm-carousel.component.css'],
   providers: [NgbCarouselConfig]  // add NgbCarouselConfig to the component providers
})
export class PalmCarouselComponent implements OnInit {

  //images data to be bound to the template
  public images = IMAGES;

  constructor(config: NgbCarouselConfig) {
    // customize default values of carousels used by this component tree

    config.interval = 10000;
    config.wrap = false;
    config.keyboard = false;
    config.pauseOnHover = false;
  }

  ngOnInit() {
  }

}
//IMAGES array implementing Image interface
var IMAGES: Image[] = [
  { "title": "We are covered", "url": "../Images/PalmTrees/Palmtree00.jpg" },
  { "title": "Generation Gap", "url": "../Images/PalmTrees/Palmtree01.jpg" },
  { "title": "Potter Me", "url": "../Images/PalmTrees/Palmtree02.jpg" },
  { "title": "Pre-School Kids", "url": "../Images/PalmTrees/Palmtree3.jpg" },
  { "title": "We are covered", "url": "../Images/PalmTrees/Palmtree04.jpg" },
  { "title": "Generation Gap", "url": "../Images/PalmTrees/Palmtree5.jpg" },
  { "title": "Potter Me", "url": "../Images/PalmTrees/Palmtree6.jpg" },
  { "title": "Pre-School Kids", "url": "../Images/PalmTrees/Palmtree7.jpg" },
  { "title": "Generation Gap", "url": "../Images/PalmTrees/Palmtree8.jpg" },
  { "title": "Potter Me", "url": "../Images/PalmTrees/Palmtree9.jpg" },
  { "title": "Pre-School Kids", "url": "../Images/PalmTrees/Palmtree10.jpg" },
  { "title": "Potter Me", "url": "../Images/PalmTrees/Palmtree11.jpg" },
  { "title": "Pre-School Kids", "url": "../Images/PalmTrees/Palmtree12.jpg" }
];
