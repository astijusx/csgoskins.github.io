@charset "UTF-8";

/*!
 * animate.css -http://daneden.me/animate
 * Version - 3.5.0
 * Licensed under the MIT license - http://opensource.org/licenses/MIT
 *
 * Copyright (c) 2015 Daniel Eden
 */

.animated {
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-fill-mode: both;
  animation-fill-mode: both;
}

.animated.infinite {
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
}

.animated.hinge {
  -webkit-animation-duration: 2s;
  animation-duration: 2s;
}

.animated.flipOutX,
.animated.flipOutY,
.animated.bounceIn,
.animated.bounceOut {
  -webkit-animation-duration: .75s;
  animation-duration: .75s;
}

@-webkit-keyframes bounce {
  from, 20%, 53%, 80%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    -webkit-transform: translate3d(0,0,0);
    transform: translate3d(0,0,0);
  }

  40%, 43% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.050, 0.855, 0.060);
    animation-timing-function: cubic-bezier(0.755, 0.050, 0.855, 0.060);
    -webkit-transform: translate3d(0, -30px, 0);
    transform: translate3d(0, -30px, 0);
  }

  70% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.050, 0.855, 0.060);
    animation-timing-function: cubic-bezier(0.755, 0.050, 0.855, 0.060);
    -webkit-transform: translate3d(0, -15px, 0);
    transform: translate3d(0, -15px, 0);
  }

  90% {
    -webkit-transform: translate3d(0,-4px,0);
    transform: translate3d(0,-4px,0);
  }
}

@keyframes bounce {
  from, 20%, 53%, 80%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    -webkit-transform: translate3d(0,0,0);
    transform: translate3d(0,0,0);
  }

  40%, 43% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.050, 0.855, 0.060);
    animation-timing-function: cubic-bezier(0.755, 0.050, 0.855, 0.060);
    -webkit-transform: translate3d(0, -30px, 0);
    transform: translate3d(0, -30px, 0);
  }

  70% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.050, 0.855, 0.060);
    animation-timing-function: cubic-bezier(0.755, 0.050, 0.855, 0.060);
    -webkit-transform: translate3d(0, -15px, 0);
    transform: translate3d(0, -15px, 0);
  }

  90% {
    -webkit-transform: translate3d(0,-4px,0);
    transform: translate3d(0,-4px,0);
  }
}

.bounce {
  -webkit-animation-name: bounce;
  animation-name: bounce;
  -webkit-transform-origin: center bottom;
  transform-origin: center bottom;
}

@-webkit-keyframes flash {
  from, 50%, to {
    opacity: 1;
  }

  25%, 75% {
    opacity: 0;
  }
}

@keyframes flash {
  from, 50%, to {
    opacity: 1;
  }

  25%, 75% {
    opacity: 0;
  }
}

.flash {
  -webkit-animation-name: flash;
  animation-name: flash;
}

/* originally authored by Nick Pettit - http://github.com/nickpettit/glide */

@-webkit-keyframes pulse {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  50% {
    -webkit-transform: scale3d(1.05, 1.05, 1.05);
    transform: scale3d(1.05, 1.05, 1.05);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

@keyframes pulse {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  50% {
    -webkit-transform: scale3d(1.05, 1.05, 1.05);
    transform: scale3d(1.05, 1.05, 1.05);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

.pulse {
  -webkit-animation-name: pulse;
  animation-name: pulse;
}

@-webkit-keyframes rubberBand {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  30% {
    -webkit-transform: scale3d(1.25, 0.75, 1);
    transform: scale3d(1.25, 0.75, 1);
  }

  40% {
    -webkit-transform: scale3d(0.75, 1.25, 1);
    transform: scale3d(0.75, 1.25, 1);
  }

  50% {
    -webkit-transform: scale3d(1.15, 0.85, 1);
    transform: scale3d(1.15, 0.85, 1);
  }

  65% {
    -webkit-transform: scale3d(.95, 1.05, 1);
    transform: scale3d(.95, 1.05, 1);
  }

  75% {
    -webkit-transform: scale3d(1.05, .95, 1);
    transform: scale3d(1.05, .95, 1);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

@keyframes rubberBand {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  30% {
    -webkit-transform: scale3d(1.25, 0.75, 1);
    transform: scale3d(1.25, 0.75, 1);
  }

  40% {
    -webkit-transform: scale3d(0.75, 1.25, 1);
    transform: scale3d(0.75, 1.25, 1);
  }

  50% {
    -webkit-transform: scale3d(1.15, 0.85, 1);
    transform: scale3d(1.15, 0.85, 1);
  }

  65% {
    -webkit-transform: scale3d(.95, 1.05, 1);
    transform: scale3d(.95, 1.05, 1);
  }

  75% {
    -webkit-transform: scale3d(1.05, .95, 1);
    transform: scale3d(1.05, .95, 1);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

.rubberBand {
  -webkit-animation-name: rubberBand;
  animation-name: rubberBand;
}

@-webkit-keyframes shake {
  from, to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  10%, 30%, 50%, 70%, 90% {
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
  }

  20%, 40%, 60%, 80% {
    -webkit-transform: translate3d(10px, 0, 0);
    transform: translate3d(10px, 0, 0);
  }
}

@keyframes shake {
  from, to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  10%, 30%, 50%, 70%, 90% {
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
  }

  20%, 40%, 60%, 80% {
    -webkit-transform: translate3d(10px, 0, 0);
    transform: translate3d(10px, 0, 0);
  }
}

.shake {
  -webkit-animation-name: shake;
  animation-name: shake;
}

@-webkit-keyframes headShake {
  0% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }

  6.5% {
    -webkit-transform: translateX(-6px) rotateY(-9deg);
    transform: translateX(-6px) rotateY(-9deg);
  }

  18.5% {
    -webkit-transform: translateX(5px) rotateY(7deg);
    transform: translateX(5px) rotateY(7deg);
  }

  31.5% {
    -webkit-transform: translateX(-3px) rotateY(-5deg);
    transform: translateX(-3px) rotateY(-5deg);
  }

  43.5% {
    -webkit-transform: translateX(2px) rotateY(3deg);
    transform: translateX(2px) rotateY(3deg);
  }

  50% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes headShake {
  0% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }

  6.5% {
    -webkit-transform: translateX(-6px) rotateY(-9deg);
    transform: translateX(-6px) rotateY(-9deg);
  }

  18.5% {
    -webkit-transform: translateX(5px) rotateY(7deg);
    transform: translateX(5px) rotateY(7deg);
  }

  31.5% {
    -webkit-transform: translateX(-3px) rotateY(-5deg);
    transform: translateX(-3px) rotateY(-5deg);
  }

  43.5% {
    -webkit-transform: translateX(2px) rotateY(3deg);
    transform: translateX(2px) rotateY(3deg);
  }

  50% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

.headShake {
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-name: headShake;
  animation-name: headShake;
}

@-webkit-keyframes swing {
  20% {
    -webkit-transform: rotate3d(0, 0, 1, 15deg);
    transform: rotate3d(0, 0, 1, 15deg);
  }

  40% {
    -webkit-transform: rotate3d(0, 0, 1, -10deg);
    transform: rotate3d(0, 0, 1, -10deg);
  }

  60% {
    -webkit-transform: rotate3d(0, 0, 1, 5deg);
    transform: rotate3d(0, 0, 1, 5deg);
  }

  80% {
    -webkit-transform: rotate3d(0, 0, 1, -5deg);
    transform: rotate3d(0, 0, 1, -5deg);
  }

  to {
    -webkit-transform: rotate3d(0, 0, 1, 0deg);
    transform: rotate3d(0, 0, 1, 0deg);
  }
}

@keyframes swing {
  20% {
    -webkit-transform: rotate3d(0, 0, 1, 15deg);
    transform: rotate3d(0, 0, 1, 15deg);
  }

  40% {
    -webkit-transform: rotate3d(0, 0, 1, -10deg);
    transform: rotate3d(0, 0, 1, -10deg);
  }

  60% {
    -webkit-transform: rotate3d(0, 0, 1, 5deg);
    transform: rotate3d(0, 0, 1, 5deg);
  }

  80% {
    -webkit-transform: rotate3d(0, 0, 1, -5deg);
    transform: rotate3d(0, 0, 1, -5deg);
  }

  to {
    -webkit-transform: rotate3d(0, 0, 1, 0deg);
    transform: rotate3d(0, 0, 1, 0deg);
  }
}

.swing {
  -webkit-transform-origin: top center;
  transform-origin: top center;
  -webkit-animation-name: swing;
  animation-name: swing;
}

@-webkit-keyframes tada {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  10%, 20% {
    -webkit-transform: scale3d(.9, .9, .9) rotate3d(0, 0, 1, -3deg);
    transform: scale3d(.9, .9, .9) rotate3d(0, 0, 1, -3deg);
  }

  30%, 50%, 70%, 90% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, 3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, 3deg);
  }

  40%, 60%, 80% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, -3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, -3deg);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

@keyframes tada {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  10%, 20% {
    -webkit-transform: scale3d(.9, .9, .9) rotate3d(0, 0, 1, -3deg);
    transform: scale3d(.9, .9, .9) rotate3d(0, 0, 1, -3deg);
  }

  30%, 50%, 70%, 90% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, 3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, 3deg);
  }

  40%, 60%, 80% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, -3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, -3deg);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

.tada {
  -webkit-animation-name: tada;
  animation-name: tada;
}

/* originally authored by Nick Pettit - http://github.com/nickpettit/glide */

@-webkit-keyframes wobble {
  from {
    -webkit-transform: none;
    transform: none;
  }

  15% {
    -webkit-transform: translate3d(-25%, 0, 0) rotate3d(0, 0, 1, -5deg);
    transform: translate3d(-25%, 0, 0) rotate3d(0, 0, 1, -5deg);
  }

  30% {
    -webkit-transform: translate3d(20%, 0, 0) rotate3d(0, 0, 1, 3deg);
    transform: translate3d(20%, 0, 0) rotate3d(0, 0, 1, 3deg);
  }

  45% {
    -webkit-transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -3deg);
    transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -3deg);
  }

  60% {
    -webkit-transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 2deg);
    transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 2deg);
  }

  75% {
    -webkit-transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -1deg);
    transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -1deg);
  }

  to {
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes wobble {
  from {
    -webkit-transform: none;
    transform: none;
  }

  15% {
    -webkit-transform: translate3d(-25%, 0, 0) rotate3d(0, 0, 1, -5deg);
    transform: translate3d(-25%, 0, 0) rotate3d(0, 0, 1, -5deg);
  }

  30% {
    -webkit-transform: translate3d(20%, 0, 0) rotate3d(0, 0, 1, 3deg);
    transform: translate3d(20%, 0, 0) rotate3d(0, 0, 1, 3deg);
  }

  45% {
    -webkit-transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -3deg);
    transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -3deg);
  }

  60% {
    -webkit-transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 2deg);
    transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 2deg);
  }

  75% {
    -webkit-transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -1deg);
    transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -1deg);
  }

  to {
    -webkit-transform: none;
    transform: none;
  }
}

.wobble {
  -webkit-animation-name: wobble;
  animation-name: wobble;
}

@-webkit-keyframes jello {
  from, 11.1%, to {
    -webkit-transform: none;
    transform: none;
  }

  22.2% {
    -webkit-transform: skewX(-12.5deg) skewY(-12.5deg);
    transform: skewX(-12.5deg) skewY(-12.5deg);
  }

  33.3% {
    -webkit-transform: skewX(6.25deg) skewY(6.25deg);
    transform: skewX(6.25deg) skewY(6.25deg);
  }

  44.4% {
    -webkit-transform: skewX(-3.125deg) skewY(-3.125deg);
    transform: skewX(-3.125deg) skewY(-3.125deg);
  }

  55.5% {
    -webkit-transform: skewX(1.5625deg) skewY(1.5625deg);
    transform: skewX(1.5625deg) skewY(1.5625deg);
  }

  66.6% {
    -webkit-transform: skewX(-0.78125deg) skewY(-0.78125deg);
    transform: skewX(-0.78125deg) skewY(-0.78125deg);
  }

  77.7% {
    -webkit-transform: skewX(0.390625deg) skewY(0.390625deg);
    transform: skewX(0.390625deg) skewY(0.390625deg);
  }

  88.8% {
    -webkit-transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
    transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
  }
}

@keyframes jello {
  from, 11.1%, to {
    -webkit-transform: none;
    transform: none;
  }

  22.2% {
    -webkit-transform: skewX(-12.5deg) skewY(-12.5deg);
    transform: skewX(-12.5deg) skewY(-12.5deg);
  }

  33.3% {
    -webkit-transform: skewX(6.25deg) skewY(6.25deg);
    transform: skewX(6.25deg) skewY(6.25deg);
  }

  44.4% {
    -webkit-transform: skewX(-3.125deg) skewY(-3.125deg);
    transform: skewX(-3.125deg) skewY(-3.125deg);
  }

  55.5% {
    -webkit-transform: skewX(1.5625deg) skewY(1.5625deg);
    transform: skewX(1.5625deg) skewY(1.5625deg);
  }

  66.6% {
    -webkit-transform: skewX(-0.78125deg) skewY(-0.78125deg);
    transform: skewX(-0.78125deg) skewY(-0.78125deg);
  }

  77.7% {
    -webkit-transform: skewX(0.390625deg) skewY(0.390625deg);
    transform: skewX(0.390625deg) skewY(0.390625deg);
  }

  88.8% {
    -webkit-transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
    transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
  }
}

.jello {
  -webkit-animation-name: jello;
  animation-name: jello;
  -webkit-transform-origin: center;
  transform-origin: center;
}

@-webkit-keyframes bounceIn {
  from, 20%, 40%, 60%, 80%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
  }

  0% {
    opacity: 0;
    -webkit-transform: scale3d(.3, .3, .3);
    transform: scale3d(.3, .3, .3);
  }

  20% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }

  40% {
    -webkit-transform: scale3d(.9, .9, .9);
    transform: scale3d(.9, .9, .9);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(1.03, 1.03, 1.03);
    transform: scale3d(1.03, 1.03, 1.03);
  }

  80% {
    -webkit-transform: scale3d(.97, .97, .97);
    transform: scale3d(.97, .97, .97);
  }

  to {
    opacity: 1;
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

@keyframes bounceIn {
  from, 20%, 40%, 60%, 80%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
  }

  0% {
    opacity: 0;
    -webkit-transform: scale3d(.3, .3, .3);
    transform: scale3d(.3, .3, .3);
  }

  20% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }

  40% {
    -webkit-transform: scale3d(.9, .9, .9);
    transform: scale3d(.9, .9, .9);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(1.03, 1.03, 1.03);
    transform: scale3d(1.03, 1.03, 1.03);
  }

  80% {
    -webkit-transform: scale3d(.97, .97, .97);
    transform: scale3d(.97, .97, .97);
  }

  to {
    opacity: 1;
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

.bounceIn {
  -webkit-animation-name: bounceIn;
  animation-name: bounceIn;
}

@-webkit-keyframes bounceInDown {
  from, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
  }

  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -3000px, 0);
    transform: translate3d(0, -3000px, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, 25px, 0);
    transform: translate3d(0, 25px, 0);
  }

  75% {
    -webkit-transform: translate3d(0, -10px, 0);
    transform: translate3d(0, -10px, 0);
  }

  90% {
    -webkit-transform: translate3d(0, 5px, 0);
    transform: translate3d(0, 5px, 0);
  }

  to {
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes bounceInDown {
  from, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
  }

  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -3000px, 0);
    transform: translate3d(0, -3000px, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, 25px, 0);
    transform: translate3d(0, 25px, 0);
  }

  75% {
    -webkit-transform: translate3d(0, -10px, 0);
    transform: translate3d(0, -10px, 0);
  }

  90% {
    -webkit-transform: translate3d(0, 5px, 0);
    transform: translate3d(0, 5px, 0);
  }

  to {
    -webkit-transform: none;
    transform: none;
  }
}

.bounceInDown {
  -webkit-animation-name: bounceInDown;
  animation-name: bounceInDown;
}

@-webkit-keyframes bounceInLeft {
  from, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
  }

  0% {
    opacity: 0;
    -webkit-transform: translate3d(-3000px, 0, 0);
    transform: translate3d(-3000px, 0, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(25px, 0, 0);
    transform: translate3d(25px, 0, 0);
  }

  75% {
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
  }

  90% {
    -webkit-transform: translate3d(5px, 0, 0);
    transform: translate3d(5px, 0, 0);
  }

  to {
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes bounceInLeft {
  from, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
  }

  0% {
    opacity: 0;
    -webkit-transform: translate3d(-3000px, 0, 0);
    transform: translate3d(-3000px, 0, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(25px, 0, 0);
    transform: translate3d(25px, 0, 0);
  }

  75% {
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
  }

  90% {
    -webkit-transform: translate3d(5px, 0, 0);
    transform: translate3d(5px, 0, 0);
  }

  to {
    -webkit-transform: none;
    transform: none;
  }
}

.bounceInLeft {
  -webkit-animation-name: bounceInLeft;
  animation-name: bounceInLeft;
}

@-webkit-keyframes bounceInRight {
  from, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
  }

  from {
    opacity: 0;
    -webkit-transform: translate3d(3000px, 0, 0);
    transform: translate3d(3000px, 0, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(-25px, 0, 0);
    transform: translate3d(-25px, 0, 0);
  }

  75% {
    -webkit-transform: translate3d(10px, 0, 0);
    transform: translate3d(10px, 0, 0);
  }

  90% {
    -webkit-transform: translate3d(-5px, 0, 0);
    transform: translate3d(-5px, 0, 0);
  }

  to {
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes bounceInRight {
  from, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
  }

  from {
    opacity: 0;
    -webkit-transform: translate3d(3000px, 0, 0);
    transform: translate3d(3000px, 0, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(-25px, 0, 0);
    transform: translate3d(-25px, 0, 0);
  }

  75% {
    -webkit-transform: translate3d(10px, 0, 0);
    transform: translate3d(10px, 0, 0);
  }

  90% {
    -webkit-transform: translate3d(-5px, 0, 0);
    transform: translate3d(-5px, 0, 0);
  }

  to {
    -webkit-transform: none;
    transform: none;
  }
}

.bounceInRight {
  -webkit-animation-name: bounceInRight;
  animation-name: bounceInRight;
}

@-webkit-keyframes bounceInUp {
  from, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
  }

  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 3000px, 0);
    transform: translate3d(0, 3000px, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0);
    transform: translate3d(0, -20px, 0);
  }

  75% {
    -webkit-transform: translate3d(0, 10px, 0);
    transform: translate3d(0, 10px, 0);
  }

  90% {
    -webkit-transform: translate3d(0, -5px, 0);
    transform: translate3d(0, -5px, 0);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes bounceInUp {
  from, 60%, 75%, 90%, to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
    animation-timing-function: cubic-bezier(0.215, 0.610, 0.355, 1.000);
  }

  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 3000px, 0);
    transform: translate3d(0, 3000px, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0);
    transform: translate3d(0, -20px, 0);
  }

  75% {
    -webkit-transform: translate3d(0, 10px, 0);
    transform: translate3d(0, 10px, 0);
  }

  90% {
    -webkit-transform: translate3d(0, -5px, 0);
    transform: translate3d(0, -5px, 0);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.bounceInUp {
  -webkit-animation-name: bounceInUp;
  animation-name: bounceInUp;
}

@-webkit-keyframes bounceOut {
  20% {
    -webkit-transform: scale3d(.9, .9, .9);
    transform: scale3d(.9, .9, .9);
  }

  50%, 55% {
    opacity: 1;
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(.3, .3, .3);
    transform: scale3d(.3, .3, .3);
  }
}

@keyframes bounceOut {
  20% {
    -webkit-transform: scale3d(.9, .9, .9);
    transform: scale3d(.9, .9, .9);
  }

  50%, 55% {
    opacity: 1;
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(.3, .3, .3);
    transform: scale3d(.3, .3, .3);
  }
}

.bounceOut {
  -webkit-animation-name: bounceOut;
  animation-name: bounceOut;
}

@-webkit-keyframes bounceOutDown {
  20% {
    -webkit-transform: translate3d(0, 10px, 0);
    transform: translate3d(0, 10px, 0);
  }

  40%, 45% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0);
    transform: translate3d(0, -20px, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
}

@keyframes bounceOutDown {
  20% {
    -webkit-transform: translate3d(0, 10px, 0);
    transform: translate3d(0, 10px, 0);
  }

  40%, 45% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0);
    transform: translate3d(0, -20px, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
}

.bounceOutDown {
  -webkit-animation-name: bounceOutDown;
  animation-name: bounceOutDown;
}

@-webkit-keyframes bounceOutLeft {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(20px, 0, 0);
    transform: translate3d(20px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
}

@keyframes bounceOutLeft {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(20px, 0, 0);
    transform: translate3d(20px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
}

.bounceOutLeft {
  -webkit-animation-name: bounceOutLeft;
  animation-name: bounceOutLeft;
}

@-webkit-keyframes bounceOutRight {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(-20px, 0, 0);
    transform: translate3d(-20px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
}

@keyframes bounceOutRight {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(-20px, 0, 0);
    transform: translate3d(-20px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
}

.bounceOutRight {
  -webkit-animation-name: bounceOutRight;
  animation-name: bounceOutRight;
}

@-webkit-keyframes bounceOutUp {
  20% {
    -webkit-transform: translate3d(0, -10px, 0);
    transform: translate3d(0, -10px, 0);
  }

  40%, 45% {
    opacity: 1;
    -webkit-transform: translate3d(0, 20px, 0);
    transform: translate3d(0, 20px, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
}

@keyframes bounceOutUp {
  20% {
    -webkit-transform: translate3d(0, -10px, 0);
    transform: translate3d(0, -10px, 0);
  }

  40%, 45% {
    opacity: 1;
    -webkit-transform: translate3d(0, 20px, 0);
    transform: translate3d(0, 20px, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
}

.bounceOutUp {
  -webkit-animation-name: bounceOutUp;
  animation-name: bounceOutUp;
}

@-webkit-keyframes fadeIn {
  from {
    opacity: 0;
  }

  to {
    opacity: 1;
  }
}

@keyframes fadeIn {
  from {
    opacity: 0;
  }

  to {
    opacity: 1;
  }
}

.fadeIn.ng-enter,
.fadeIn {
  -webkit-animation-name: fadeIn;
  animation-name: fadeIn;
}

.fadeIn.ng-enter-active {
    opacity: 1;
}

@-webkit-keyframes fadeInDown {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes fadeInDown {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

.fadeInDown {
  -webkit-animation-name: fadeInDown;
  animation-name: fadeInDown;
}

@-webkit-keyframes fadeInDownBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes fadeInDownBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

.fadeInDownBig {
  -webkit-animation-name: fadeInDownBig;
  animation-name: fadeInDownBig;
}

@-webkit-keyframes fadeInLeft {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes fadeInLeft {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

.fadeInLeft {
  -webkit-animation-name: fadeInLeft;
  animation-name: fadeInLeft;
}

@-webkit-keyframes fadeInLeftBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes fadeInLeftBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

.fadeInLeftBig {
  -webkit-animation-name: fadeInLeftBig;
  animation-name: fadeInLeftBig;
}

@-webkit-keyframes fadeInRight {
  from {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes fadeInRight {
  from {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

.fadeInRight {
  -webkit-animation-name: fadeInRight;
  animation-name: fadeInRight;
}

@-webkit-keyframes fadeInRightBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes fadeInRightBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

.fadeInRightBig {
  -webkit-animation-name: fadeInRightBig;
  animation-name: fadeInRightBig;
}

@-webkit-keyframes fadeInUp {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes fadeInUp {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

.fadeInUp {
  -webkit-animation-name: fadeInUp;
  animation-name: fadeInUp;
}

@-webkit-keyframes fadeInUpBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes fadeInUpBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

.fadeInUpBig {
  -webkit-animation-name: fadeInUpBig;
  animation-name: fadeInUpBig;
}

@-webkit-keyframes fadeOut {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
  }
}

@keyframes fadeOut {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
  }
}

.fadeOut.ng-enter {
  -webkit-animation: fadeIn;
  animation: fadeIn;
}

.fadeOut.ng-hide-remove {
  -webkit-animation-name: fadeOut;
  animation-name: fadeOut;
}
 
.fadeOut.ng-hide-add {
    -webkit-animation: fadeOut;
    animation: fadeOut;
    display: block !important;
}

@-webkit-keyframes fadeOutDown {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}

@keyframes fadeOutDown {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}

.fadeOutDown {
  -webkit-animation-name: fadeOutDown;
  animation-name: fadeOutDown;
}

@-webkit-keyframes fadeOutDownBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
}

@keyframes fadeOutDownBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
}

.fadeOutDownBig {
  -webkit-animation-name: fadeOutDownBig;
  animation-name: fadeOutDownBig;
}

@-webkit-keyframes fadeOutLeft {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}

@keyframes fadeOutLeft {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}

.fadeOutLeft {
  -webkit-animation-name: fadeOutLeft;
  animation-name: fadeOutLeft;
}

@-webkit-keyframes fadeOutLeftBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
}

@keyframes fadeOutLeftBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
}

.fadeOutLeftBig {
  -webkit-animation-name: fadeOutLeftBig;
  animation-name: fadeOutLeftBig;
}

@-webkit-keyframes fadeOutRight {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}

@keyframes fadeOutRight {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}

.fadeOutRight {
  -webkit-animation-name: fadeOutRight;
  animation-name: fadeOutRight;
}

@-webkit-keyframes fadeOutRightBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
}

@keyframes fadeOutRightBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
}

.fadeOutRightBig {
  -webkit-animation-name: fadeOutRightBig;
  animation-name: fadeOutRightBig;
}

@-webkit-keyframes fadeOutUp {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}

@keyframes fadeOutUp {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}

.fadeOutUp {
  -webkit-animation-name: fadeOutUp;
  animation-name: fadeOutUp;
}

@-webkit-keyframes fadeOutUpBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
}

@keyframes fadeOutUpBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
}

.fadeOutUpBig {
  -webkit-animation-name: fadeOutUpBig;
  animation-name: fadeOutUpBig;
}

@-webkit-keyframes flip {
  from {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -360deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -360deg);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }

  40% {
    -webkit-transform: perspective(400px) translate3d(0, 0, 150px) rotate3d(0, 1, 0, -190deg);
    transform: perspective(400px) translate3d(0, 0, 150px) rotate3d(0, 1, 0, -190deg);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }

  50% {
    -webkit-transform: perspective(400px) translate3d(0, 0, 150px) rotate3d(0, 1, 0, -170deg);
    transform: perspective(400px) translate3d(0, 0, 150px) rotate3d(0, 1, 0, -170deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  80% {
    -webkit-transform: perspective(400px) scale3d(.95, .95, .95);
    transform: perspective(400px) scale3d(.95, .95, .95);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
}

@keyframes flip {
  from {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -360deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -360deg);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }

  40% {
    -webkit-transform: perspective(400px) translate3d(0, 0, 150px) rotate3d(0, 1, 0, -190deg);
    transform: perspective(400px) translate3d(0, 0, 150px) rotate3d(0, 1, 0, -190deg);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }

  50% {
    -webkit-transform: perspective(400px) translate3d(0, 0, 150px) rotate3d(0, 1, 0, -170deg);
    transform: perspective(400px) translate3d(0, 0, 150px) rotate3d(0, 1, 0, -170deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  80% {
    -webkit-transform: perspective(400px) scale3d(.95, .95, .95);
    transform: perspective(400px) scale3d(.95, .95, .95);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
}

.animated.flip {
  -webkit-backface-visibility: visible;
  backface-visibility: visible;
  -webkit-animation-name: flip;
  animation-name: flip;
}

@-webkit-keyframes flipInX {
  from {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }

  40% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  60% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 10deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 10deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -5deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -5deg);
  }

  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}

@keyframes flipInX {
  from {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }

  40% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  60% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 10deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 10deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -5deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -5deg);
  }

  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}

.flipInX {
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipInX;
  animation-name: flipInX;
}

@-webkit-keyframes flipInY {
  from {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }

  40% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -20deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  60% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 10deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 10deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -5deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -5deg);
  }

  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}

@keyframes flipInY {
  from {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }

  40% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -20deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  60% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 10deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 10deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -5deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -5deg);
  }

  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}

.flipInY {
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipInY;
  animation-name: flipInY;
}

@-webkit-keyframes flipOutX {
  from {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }

  30% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    opacity: 1;
  }

  to {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    opacity: 0;
  }
}

@keyframes flipOutX {
  from {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }

  30% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    opacity: 1;
  }

  to {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    opacity: 0;
  }
}

.flipOutX {
  -webkit-animation-name: flipOutX;
  animation-name: flipOutX;
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
}

@-webkit-keyframes flipOutY {
  from {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }

  30% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -15deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -15deg);
    opacity: 1;
  }

  to {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    opacity: 0;
  }
}

@keyframes flipOutY {
  from {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }

  30% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -15deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -15deg);
    opacity: 1;
  }

  to {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    opacity: 0;
  }
}

.flipOutY {
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipOutY;
  animation-name: flipOutY;
}

@-webkit-keyframes lightSpeedIn {
  from {
    -webkit-transform: translate3d(100%, 0, 0) skewX(-30deg);
    transform: translate3d(100%, 0, 0) skewX(-30deg);
    opacity: 0;
  }

  60% {
    -webkit-transform: skewX(20deg);
    transform: skewX(20deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: skewX(-5deg);
    transform: skewX(-5deg);
    opacity: 1;
  }

  to {
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

@keyframes lightSpeedIn {
  from {
    -webkit-transform: translate3d(100%, 0, 0) skewX(-30deg);
    transform: translate3d(100%, 0, 0) skewX(-30deg);
    opacity: 0;
  }

  60% {
    -webkit-transform: skewX(20deg);
    transform: skewX(20deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: skewX(-5deg);
    transform: skewX(-5deg);
    opacity: 1;
  }

  to {
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

.lightSpeedIn {
  -webkit-animation-name: lightSpeedIn;
  animation-name: lightSpeedIn;
  -webkit-animation-timing-function: ease-out;
  animation-timing-function: ease-out;
}

@-webkit-keyframes lightSpeedOut {
  from {
    opacity: 1;
  }

  to {
    -webkit-transform: translate3d(100%, 0, 0) skewX(30deg);
    transform: translate3d(100%, 0, 0) skewX(30deg);
    opacity: 0;
  }
}

@keyframes lightSpeedOut {
  from {
    opacity: 1;
  }

  to {
    -webkit-transform: translate3d(100%, 0, 0) skewX(30deg);
    transform: translate3d(100%, 0, 0) skewX(30deg);
    opacity: 0;
  }
}

.lightSpeedOut {
  -webkit-animation-name: lightSpeedOut;
  animation-name: lightSpeedOut;
  -webkit-animation-timing-function: ease-in;
  animation-timing-function: ease-in;
}

@-webkit-keyframes rotateIn {
  from {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: rotate3d(0, 0, 1, -200deg);
    transform: rotate3d(0, 0, 1, -200deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

@keyframes rotateIn {
  from {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: rotate3d(0, 0, 1, -200deg);
    transform: rotate3d(0, 0, 1, -200deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

.rotateIn {
  -webkit-animation-name: rotateIn;
  animation-name: rotateIn;
}

@-webkit-keyframes rotateInDownLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

@keyframes rotateInDownLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

.rotateInDownLeft {
  -webkit-animation-name: rotateInDownLeft;
  animation-name: rotateInDownLeft;
}

@-webkit-keyframes rotateInDownRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

@keyframes rotateInDownRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

.rotateInDownRight {
  -webkit-animation-name: rotateInDownRight;
  animation-name: rotateInDownRight;
}

@-webkit-keyframes rotateInUpLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

@keyframes rotateInUpLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

.rotateInUpLeft {
  -webkit-animation-name: rotateInUpLeft;
  animation-name: rotateInUpLeft;
}

@-webkit-keyframes rotateInUpRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, -90deg);
    transform: rotate3d(0, 0, 1, -90deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

@keyframes rotateInUpRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, -90deg);
    transform: rotate3d(0, 0, 1, -90deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: none;
    transform: none;
    opacity: 1;
  }
}

.rotateInUpRight {
  -webkit-animation-name: rotateInUpRight;
  animation-name: rotateInUpRight;
}

@-webkit-keyframes rotateOut {
  from {
    -webkit-transform-origin: center;
    transform-origin: center;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: rotate3d(0, 0, 1, 200deg);
    transform: rotate3d(0, 0, 1, 200deg);
    opacity: 0;
  }
}

@keyframes rotateOut {
  from {
    -webkit-transform-origin: center;
    transform-origin: center;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: rotate3d(0, 0, 1, 200deg);
    transform: rotate3d(0, 0, 1, 200deg);
    opacity: 0;
  }
}

.rotateOut {
  -webkit-animation-name: rotateOut;
  animation-name: rotateOut;
}

@-webkit-keyframes rotateOutDownLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }
}

@keyframes rotateOutDownLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }
}

.rotateOutDownLeft {
  -webkit-animation-name: rotateOutDownLeft;
  animation-name: rotateOutDownLeft;
}

@-webkit-keyframes rotateOutDownRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }
}

@keyframes rotateOutDownRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }
}

.rotateOutDownRight {
  -webkit-animation-name: rotateOutDownRight;
  animation-name: rotateOutDownRight;
}

@-webkit-keyframes rotateOutUpLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }
}

@keyframes rotateOutUpLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }
}

.rotateOutUpLeft {
  -webkit-animation-name: rotateOutUpLeft;
  animation-name: rotateOutUpLeft;
}

@-webkit-keyframes rotateOutUpRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, 90deg);
    transform: rotate3d(0, 0, 1, 90deg);
    opacity: 0;
  }
}

@keyframes rotateOutUpRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, 90deg);
    transform: rotate3d(0, 0, 1, 90deg);
    opacity: 0;
  }
}

.rotateOutUpRight {
  -webkit-animation-name: rotateOutUpRight;
  animation-name: rotateOutUpRight;
}

@-webkit-keyframes hinge {
  0% {
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }

  20%, 60% {
    -webkit-transform: rotate3d(0, 0, 1, 80deg);
    transform: rotate3d(0, 0, 1, 80deg);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }

  40%, 80% {
    -webkit-transform: rotate3d(0, 0, 1, 60deg);
    transform: rotate3d(0, 0, 1, 60deg);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
    opacity: 1;
  }

  to {
    -webkit-transform: translate3d(0, 700px, 0);
    transform: translate3d(0, 700px, 0);
    opacity: 0;
  }
}

@keyframes hinge {
  0% {
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }

  20%, 60% {
    -webkit-transform: rotate3d(0, 0, 1, 80deg);
    transform: rotate3d(0, 0, 1, 80deg);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }

  40%, 80% {
    -webkit-transform: rotate3d(0, 0, 1, 60deg);
    transform: rotate3d(0, 0, 1, 60deg);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
    opacity: 1;
  }

  to {
    -webkit-transform: translate3d(0, 700px, 0);
    transform: translate3d(0, 700px, 0);
    opacity: 0;
  }
}

.hinge {
  -webkit-animation-name: hinge;
  animation-name: hinge;
}

/* originally authored by Nick Pettit - http://github.com/nickpettit/glide */

@-webkit-keyframes rollIn {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0) rotate3d(0, 0, 1, -120deg);
    transform: translate3d(-100%, 0, 0) rotate3d(0, 0, 1, -120deg);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes rollIn {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0) rotate3d(0, 0, 1, -120deg);
    transform: translate3d(-100%, 0, 0) rotate3d(0, 0, 1, -120deg);
  }

  to {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

.rollIn {
  -webkit-animation-name: rollIn;
  animation-name: rollIn;
}

/* originally authored by Nick Pettit - http://github.com/nickpettit/glide */

@-webkit-keyframes rollOut {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0) rotate3d(0, 0, 1, 120deg);
    transform: translate3d(100%, 0, 0) rotate3d(0, 0, 1, 120deg);
  }
}

@keyframes rollOut {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0) rotate3d(0, 0, 1, 120deg);
    transform: translate3d(100%, 0, 0) rotate3d(0, 0, 1, 120deg);
  }
}

.rollOut {
  -webkit-animation-name: rollOut;
  animation-name: rollOut;
}

@-webkit-keyframes zoomIn {
  from {
    opacity: 0;
    -webkit-transform: scale3d(.3, .3, .3);
    transform: scale3d(.3, .3, .3);
  }

  50% {
    opacity: 1;
  }
}

@keyframes zoomIn {
  from {
    opacity: 0;
    -webkit-transform: scale3d(.3, .3, .3);
    transform: scale3d(.3, .3, .3);
  }

  50% {
    opacity: 1;
  }
}

.zoomIn {
  -webkit-animation-name: zoomIn;
  animation-name: zoomIn;
}

@-webkit-keyframes zoomInDown {
  from {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(0, -1000px, 0);
    transform: scale3d(.1, .1, .1) translate3d(0, -1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(0, 60px, 0);
    transform: scale3d(.475, .475, .475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

@keyframes zoomInDown {
  from {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(0, -1000px, 0);
    transform: scale3d(.1, .1, .1) translate3d(0, -1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(0, 60px, 0);
    transform: scale3d(.475, .475, .475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

.zoomInDown {
  -webkit-animation-name: zoomInDown;
  animation-name: zoomInDown;
}

@-webkit-keyframes zoomInLeft {
  from {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(-1000px, 0, 0);
    transform: scale3d(.1, .1, .1) translate3d(-1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(10px, 0, 0);
    transform: scale3d(.475, .475, .475) translate3d(10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

@keyframes zoomInLeft {
  from {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(-1000px, 0, 0);
    transform: scale3d(.1, .1, .1) translate3d(-1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(10px, 0, 0);
    transform: scale3d(.475, .475, .475) translate3d(10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

.zoomInLeft {
  -webkit-animation-name: zoomInLeft;
  animation-name: zoomInLeft;
}

@-webkit-keyframes zoomInRight {
  from {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(1000px, 0, 0);
    transform: scale3d(.1, .1, .1) translate3d(1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(-10px, 0, 0);
    transform: scale3d(.475, .475, .475) translate3d(-10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

@keyframes zoomInRight {
  from {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(1000px, 0, 0);
    transform: scale3d(.1, .1, .1) translate3d(1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(-10px, 0, 0);
    transform: scale3d(.475, .475, .475) translate3d(-10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

.zoomInRight {
  -webkit-animation-name: zoomInRight;
  animation-name: zoomInRight;
}

@-webkit-keyframes zoomInUp {
  from {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(0, 1000px, 0);
    transform: scale3d(.1, .1, .1) translate3d(0, 1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(0, -60px, 0);
    transform: scale3d(.475, .475, .475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

@keyframes zoomInUp {
  from {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(0, 1000px, 0);
    transform: scale3d(.1, .1, .1) translate3d(0, 1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(0, -60px, 0);
    transform: scale3d(.475, .475, .475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

.zoomInUp {
  -webkit-animation-name: zoomInUp;
  animation-name: zoomInUp;
}

@-webkit-keyframes zoomOut {
  from {
    opacity: 1;
  }

  50% {
    opacity: 0;
    -webkit-transform: scale3d(.3, .3, .3);
    transform: scale3d(.3, .3, .3);
  }

  to {
    opacity: 0;
  }
}

@keyframes zoomOut {
  from {
    opacity: 1;
  }

  50% {
    opacity: 0;
    -webkit-transform: scale3d(.3, .3, .3);
    transform: scale3d(.3, .3, .3);
  }

  to {
    opacity: 0;
  }
}

.zoomOut {
  -webkit-animation-name: zoomOut;
  animation-name: zoomOut;
}

@-webkit-keyframes zoomOutDown {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(0, -60px, 0);
    transform: scale3d(.475, .475, .475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(0, 2000px, 0);
    transform: scale3d(.1, .1, .1) translate3d(0, 2000px, 0);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

@keyframes zoomOutDown {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(0, -60px, 0);
    transform: scale3d(.475, .475, .475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(0, 2000px, 0);
    transform: scale3d(.1, .1, .1) translate3d(0, 2000px, 0);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

.zoomOutDown {
  -webkit-animation-name: zoomOutDown;
  animation-name: zoomOutDown;
}

@-webkit-keyframes zoomOutLeft {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(42px, 0, 0);
    transform: scale3d(.475, .475, .475) translate3d(42px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: scale(.1) translate3d(-2000px, 0, 0);
    transform: scale(.1) translate3d(-2000px, 0, 0);
    -webkit-transform-origin: left center;
    transform-origin: left center;
  }
}

@keyframes zoomOutLeft {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(42px, 0, 0);
    transform: scale3d(.475, .475, .475) translate3d(42px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: scale(.1) translate3d(-2000px, 0, 0);
    transform: scale(.1) translate3d(-2000px, 0, 0);
    -webkit-transform-origin: left center;
    transform-origin: left center;
  }
}

.zoomOutLeft {
  -webkit-animation-name: zoomOutLeft;
  animation-name: zoomOutLeft;
}

@-webkit-keyframes zoomOutRight {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(-42px, 0, 0);
    transform: scale3d(.475, .475, .475) translate3d(-42px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: scale(.1) translate3d(2000px, 0, 0);
    transform: scale(.1) translate3d(2000px, 0, 0);
    -webkit-transform-origin: right center;
    transform-origin: right center;
  }
}

@keyframes zoomOutRight {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(-42px, 0, 0);
    transform: scale3d(.475, .475, .475) translate3d(-42px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: scale(.1) translate3d(2000px, 0, 0);
    transform: scale(.1) translate3d(2000px, 0, 0);
    -webkit-transform-origin: right center;
    transform-origin: right center;
  }
}

.zoomOutRight {
  -webkit-animation-name: zoomOutRight;
  animation-name: zoomOutRight;
}

@-webkit-keyframes zoomOutUp {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(0, 60px, 0);
    transform: scale3d(.475, .475, .475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(0, -2000px, 0);
    transform: scale3d(.1, .1, .1) translate3d(0, -2000px, 0);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

@keyframes zoomOutUp {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(.475, .475, .475) translate3d(0, 60px, 0);
    transform: scale3d(.475, .475, .475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
    animation-timing-function: cubic-bezier(0.550, 0.055, 0.675, 0.190);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(.1, .1, .1) translate3d(0, -2000px, 0);
    transform: scale3d(.1, .1, .1) translate3d(0, -2000px, 0);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.320, 1);
  }
}

.zoomOutUp {
  -webkit-animation-name: zoomOutUp;
  animation-name: zoomOutUp;
}

@-webkit-keyframes slideInDown {
  from {
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes slideInDown {
  from {
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.slideInDown {
  -webkit-animation-name: slideInDown;
  animation-name: slideInDown;
}

@-webkit-keyframes slideInLeft {
  from {
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes slideInLeft {
  from {
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.slideInLeft {
  -webkit-animation-name: slideInLeft;
  animation-name: slideInLeft;
}

@-webkit-keyframes slideInRight {
  from {
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes slideInRight {
  from {
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.slideInRight {
  -webkit-animation-name: slideInRight;
  animation-name: slideInRight;
}

@-webkit-keyframes slideInUp {
  from {
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes slideInUp {
  from {
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.slideInUp {
  -webkit-animation-name: slideInUp;
  animation-name: slideInUp;
}

@-webkit-keyframes slideOutDown {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}

@keyframes slideOutDown {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}

.slideOutDown {
  -webkit-animation-name: slideOutDown;
  animation-name: slideOutDown;
}

@-webkit-keyframes slideOutLeft {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}

@keyframes slideOutLeft {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}

.slideOutLeft {
  -webkit-animation-name: slideOutLeft;
  animation-name: slideOutLeft;
}

@-webkit-keyframes slideOutRight {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}

@keyframes slideOutRight {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}

.slideOutRight {
  -webkit-animation-name: slideOutRight;
  animation-name: slideOutRight;
}

@-webkit-keyframes slideOutUp {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}

@keyframes slideOutUp {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}

.slideOutUp {
  -webkit-animation-name: slideOutUp;
  animation-name: slideOutUp;
}

/* http://meyerweb.com/eric/tools/css/reset/ 
   v2.0 | 20110126
   License: none (public domain)
*/

html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, pozarevac123,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed, 
figure, figcaption, footer, header, hgroup, 
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
	margin: 0;
	padding: 0;
	border: 0;
	font-size: 100%;
	font: inherit;
	vertical-align: baseline;
}
/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure, 
footer, header, hgroup, menu, nav, section {
	display: block;
}
body {
	line-height: 1;
}
ol, ul {
	list-style: none;
}
blockquote, q {
	quotes: none;
}
blockquote:before, blockquote:after,
q:before, q:after {
	content: '';
	content: none;
}
table {
	border-collapse: collapse;
	border-spacing: 0;
}

/**
 * Start Vanilla CSS 1.0.2 
 */ 
body {
	font: 9pt/1.5em sans-serif;
}
pre, code, tt {
	font: 1em/1.5em 'Andale Mono', 'Lucida Console', monospace;
}
h1, h2, h3, h4, h5, h6, b, strong {
	font-weight: bold;
}
em, i, dfn {
	font-style: italic;
}
dfn {
	font-weight:bold;
}
p, code, pre, kbd {
	margin:0 0 1.5em 0;
}
blockquote {
	margin:0 1.5em 1.5em 1.5em;
}
cite {
	font-style: italic;
}
li ul, li ol {
	margin:0 1.5em;
}
ul, ol {
	margin:0 1.5em 1.5em 1.5em;
}
ul {
	list-style-type:disc;
}
ol {
	list-style-type:decimal;
}
ol ol {
	list-style: upper-alpha;
}
ol ol ol {
	list-style: lower-roman;
}
ol ol ol ol {
	list-style: lower-alpha;
}
dl {
	margin:0 0 1.5em 0;
}
dl dt {
	font-weight:bold;
}
dd {
	margin-left:1.5em;
}
table {
	margin-bottom:1.4em;
	width:100%;
}
th {
	font-weight:bold;
}
th, td, caption {
	padding:4px 10px 4px 5px;
}
tfoot {
	font-style:italic;
}
sup, sub {
	line-height:0;
}
abbr, acronym {
	border-bottom: 1px dotted;
}
address {
	margin:0 0 1.5em;
	font-style:italic;
}
del {
	text-decoration: line-through;
}
pre {
	margin:1.5em 0;
	white-space:pre;
}
img.centered, .aligncenter, div.aligncenter {
	display: block;
	margin-left: auto;
	margin-right: auto;
}
img.alignright {
	display: inline;
}
img.alignleft {
	display: inline;
}
.alignright {
	float: right;
	margin-left: 10px;
}
.alignleft {
	float: left;
	margin-right: 10px;
}
img {
	max-width: 100%;
}
* html .clearfix {
    height: 1%;
}
* + html .clearfix {
	display: inline-block;
}
.clearfix:after {
    content: ".";
    display: block;
    height: 0;
    clear: both;
    visibility: hidden;
}
* html .group {
    height: 1%;
}
* + html .group {
	display: inline-block;
}
.group:after {
    content: ".";
    display: block;
    height: 0;
    clear: both;
    visibility: hidden;
}
/**
* End Vanilla CSS
*/
/*!
 * Bootstrap v3.1.1 (http://getbootstrap.com)
 * Copyright 2011-2014 Twitter, Inc.
 * Licensed under MIT (http://github.com/twbs/bootstrap/blob/master/LICENSE)
 */

/*! normalize.css v3.0.0 | MIT License | git.io/normalize */html{font-family:sans-serif;-ms-text-size-adjust:100%;-webkit-text-size-adjust:100%}body{margin:0}article,aside,details,figcaption,figure,footer,header,hgroup,main,nav,section,summary{display:block}audio,canvas,progress,video{display:inline-block;vertical-align:baseline}audio:not([controls]){display:none;height:0}[hidden],template{display:none}a{background:0 0}a:active,a:hover{outline:0}abbr[title]{border-bottom:1px dotted}b,strong{font-weight:700}dfn{font-style:italic}h1{font-size:2em;margin:.67em 0}mark{background:#ff0;color:#000}small{font-size:80%}sub,sup{font-size:75%;line-height:0;position:relative;vertical-align:baseline}sup{top:-.5em}sub{bottom:-.25em}img{border:0}svg:not(:root){overflow:hidden}figure{margin:1em 40px}hr{-moz-box-sizing:content-box;box-sizing:content-box;height:0}pre{overflow:auto}code,kbd,pre,samp{font-family:monospace,monospace;font-size:1em}button,input,optgroup,select,textarea{color:inherit;font:inherit;margin:0}button{overflow:visible}button,select{text-transform:none}button,html input[type=button],input[type=reset],input[type=submit]{-webkit-appearance:button;cursor:pointer}button[disabled],html input[disabled]{cursor:default}button::-moz-focus-inner,input::-moz-focus-inner{border:0;padding:0}input{line-height:normal}input[type=checkbox],input[type=radio]{box-sizing:border-box;padding:0}input[type=number]::-webkit-inner-spin-button,input[type=number]::-webkit-outer-spin-button{height:auto}input[type=search]{-webkit-appearance:textfield;-moz-box-sizing:content-box;-webkit-box-sizing:content-box;box-sizing:content-box}input[type=search]::-webkit-search-cancel-button,input[type=search]::-webkit-search-decoration{-webkit-appearance:none}fieldset{border:1px solid silver;margin:0 2px;padding:.35em .625em .75em}pozarevac123{border:0;padding:0}textarea{overflow:auto}optgroup{font-weight:700}table{border-collapse:collapse;border-spacing:0}td,th{padding:0}@media print{*{text-shadow:none!important;color:#000!important;background:transparent!important;box-shadow:none!important}a,a:visited{text-decoration:underline}a[href]:after{content:" (" attr(href) ")"}abbr[title]:after{content:" (" attr(title) ")"}a[href^="javascript:"]:after,a[href^="#"]:after{content:""}pre,blockquote{border:1px solid #999;page-break-inside:avoid}thead{display:table-header-group}tr,img{page-break-inside:avoid}img{max-width:100%!important}p,h2,h3{orphans:3;widows:3}h2,h3{page-break-after:avoid}select{background:#fff!important}.navbar{display:none}.table td,.table th{background-color:#fff!important}.btn>.caret,.dropup>.btn>.caret{border-top-color:#000!important}.label{border:1px solid #000}.table{border-collapse:collapse!important}.table-bordered th,.table-bordered td{border:1px solid #ddd!important}}*{-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}:before,:after{-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}html{font-size:62.5%;-webkit-tap-highlight-color:rgba(0,0,0,0)}body{font-family:"Helvetica Neue",Helvetica,Arial,sans-serif;font-size:14px;line-height:1.42857143;color:#333;background-color:#fff}input,button,select,textarea{font-family:inherit;font-size:inherit;line-height:inherit}a{color:#428bca;text-decoration:none}a:hover,a:focus{color:#2a6496;text-decoration:underline}a:focus{outline:thin dotted;outline:5px auto -webkit-focus-ring-color;outline-offset:-2px}figure{margin:0}img{vertical-align:middle}.img-responsive,.thumbnail>img,.thumbnail a>img,.carousel-inner>.item>img,.carousel-inner>.item>a>img{display:block;max-width:100%;height:auto}.img-rounded{border-radius:6px}.img-thumbnail{padding:4px;line-height:1.42857143;background-color:#fff;border:1px solid #ddd;border-radius:4px;-webkit-transition:all .2s ease-in-out;transition:all .2s ease-in-out;display:inline-block;max-width:100%;height:auto}.img-circle{border-radius:50%}hr{margin-top:20px;margin-bottom:20px;border:0;border-top:1px solid #eee}.sr-only{position:absolute;width:1px;height:1px;margin:-1px;padding:0;overflow:hidden;clip:rect(0,0,0,0);border:0}h1,h2,h3,h4,h5,h6,.h1,.h2,.h3,.h4,.h5,.h6{font-family:inherit;font-weight:500;line-height:1.1;color:inherit}h1 small,h2 small,h3 small,h4 small,h5 small,h6 small,.h1 small,.h2 small,.h3 small,.h4 small,.h5 small,.h6 small,h1 .small,h2 .small,h3 .small,h4 .small,h5 .small,h6 .small,.h1 .small,.h2 .small,.h3 .small,.h4 .small,.h5 .small,.h6 .small{font-weight:400;line-height:1;color:#999}h1,.h1,h2,.h2,h3,.h3{margin-top:20px;margin-bottom:10px}h1 small,.h1 small,h2 small,.h2 small,h3 small,.h3 small,h1 .small,.h1 .small,h2 .small,.h2 .small,h3 .small,.h3 .small{font-size:65%}h4,.h4,h5,.h5,h6,.h6{margin-top:10px;margin-bottom:10px}h4 small,.h4 small,h5 small,.h5 small,h6 small,.h6 small,h4 .small,.h4 .small,h5 .small,.h5 .small,h6 .small,.h6 .small{font-size:75%}h1,.h1{font-size:36px}h2,.h2{font-size:30px}h3,.h3{font-size:24px}h4,.h4{font-size:18px}h5,.h5{font-size:14px}h6,.h6{font-size:12px}p{margin:0 0 10px}.lead{margin-bottom:20px;font-size:16px;font-weight:200;line-height:1.4}@media (min-width:768px){.lead{font-size:21px}}small,.small{font-size:85%}cite{font-style:normal}.text-left{text-align:left}.text-right{text-align:right}.text-center{text-align:center}.text-justify{text-align:justify}.text-muted{color:#999}.text-primary{color:#428bca}a.text-primary:hover{color:#3071a9}.text-success{color:#3c763d}a.text-success:hover{color:#2b542c}.text-info{color:#31708f}a.text-info:hover{color:#245269}.text-warning{color:#8a6d3b}a.text-warning:hover{color:#66512c}.text-danger{color:#a94442}a.text-danger:hover{color:#843534}.bg-primary{color:#fff;background-color:#428bca}a.bg-primary:hover{background-color:#3071a9}.bg-success{background-color:#dff0d8}a.bg-success:hover{background-color:#c1e2b3}.bg-info{background-color:#d9edf7}a.bg-info:hover{background-color:#afd9ee}.bg-warning{background-color:#fcf8e3}a.bg-warning:hover{background-color:#f7ecb5}.bg-danger{background-color:#f2dede}a.bg-danger:hover{background-color:#e4b9b9}.page-header{padding-bottom:9px;margin:40px 0 20px;border-bottom:1px solid #eee}ul,ol{margin-top:0;margin-bottom:10px}ul ul,ol ul,ul ol,ol ol{margin-bottom:0}.list-unstyled{padding-left:0;list-style:none}.list-inline{padding-left:0;list-style:none;margin-left:-5px}.list-inline>li{display:inline-block;padding-left:5px;padding-right:5px}dl{margin-top:0;margin-bottom:20px}dt,dd{line-height:1.42857143}dt{font-weight:700}dd{margin-left:0}@media (min-width:768px){.dl-horizontal dt{float:left;width:160px;clear:left;text-align:right;overflow:hidden;text-overflow:ellipsis;white-space:nowrap}.dl-horizontal dd{margin-left:180px}}abbr[title],abbr[data-original-title]{cursor:help;border-bottom:1px dotted #999}.initialism{font-size:90%;text-transform:uppercase}blockquote{padding:10px 20px;margin:0 0 20px;font-size:17.5px;border-left:5px solid #eee}blockquote p:last-child,blockquote ul:last-child,blockquote ol:last-child{margin-bottom:0}blockquote footer,blockquote small,blockquote .small{display:block;font-size:80%;line-height:1.42857143;color:#999}blockquote footer:before,blockquote small:before,blockquote .small:before{content:'\2014 \00A0'}.blockquote-reverse,blockquote.pull-right{padding-right:15px;padding-left:0;border-right:5px solid #eee;border-left:0;text-align:right}.blockquote-reverse footer:before,blockquote.pull-right footer:before,.blockquote-reverse small:before,blockquote.pull-right small:before,.blockquote-reverse .small:before,blockquote.pull-right .small:before{content:''}.blockquote-reverse footer:after,blockquote.pull-right footer:after,.blockquote-reverse small:after,blockquote.pull-right small:after,.blockquote-reverse .small:after,blockquote.pull-right .small:after{content:'\00A0 \2014'}blockquote:before,blockquote:after{content:""}address{margin-bottom:20px;font-style:normal;line-height:1.42857143}code,kbd,pre,samp{font-family:Menlo,Monaco,Consolas,"Courier New",monospace}code{padding:2px 4px;font-size:90%;color:#c7254e;background-color:#f9f2f4;white-space:nowrap;border-radius:4px}kbd{padding:2px 4px;font-size:90%;color:#fff;background-color:#333;border-radius:3px;box-shadow:inset 0 -1px 0 rgba(0,0,0,.25)}pre{display:block;padding:9.5px;margin:0 0 10px;font-size:13px;line-height:1.42857143;word-break:break-all;word-wrap:break-word;color:#333;background-color:#f5f5f5;border:1px solid #ccc;border-radius:4px}pre code{padding:0;font-size:inherit;color:inherit;white-space:pre-wrap;background-color:transparent;border-radius:0}.pre-scrollable{max-height:340px;overflow-y:scroll}.container{margin-right:auto;margin-left:auto;padding-left:15px;padding-right:15px}@media (min-width:768px){.container{width:750px}}@media (min-width:992px){.container{width:970px}}@media (min-width:1200px){.container{width:1170px}}.container-fluid{margin-right:auto;margin-left:auto;padding-left:15px;padding-right:15px}.row{margin-left:-15px;margin-right:-15px}.col-xs-1,.col-sm-1,.col-md-1,.col-lg-1,.col-xs-2,.col-sm-2,.col-md-2,.col-lg-2,.col-xs-3,.col-sm-3,.col-md-3,.col-lg-3,.col-xs-4,.col-sm-4,.col-md-4,.col-lg-4,.col-xs-5,.col-sm-5,.col-md-5,.col-lg-5,.col-xs-6,.col-sm-6,.col-md-6,.col-lg-6,.col-xs-7,.col-sm-7,.col-md-7,.col-lg-7,.col-xs-8,.col-sm-8,.col-md-8,.col-lg-8,.col-xs-9,.col-sm-9,.col-md-9,.col-lg-9,.col-xs-10,.col-sm-10,.col-md-10,.col-lg-10,.col-xs-11,.col-sm-11,.col-md-11,.col-lg-11,.col-xs-12,.col-sm-12,.col-md-12,.col-lg-12{position:relative;min-height:1px;padding-left:15px;padding-right:15px}.col-xs-1,.col-xs-2,.col-xs-3,.col-xs-4,.col-xs-5,.col-xs-6,.col-xs-7,.col-xs-8,.col-xs-9,.col-xs-10,.col-xs-11,.col-xs-12{float:left}.col-xs-12{width:100%}.col-xs-11{width:91.66666667%}.col-xs-10{width:83.33333333%}.col-xs-9{width:75%}.col-xs-8{width:66.66666667%}.col-xs-7{width:58.33333333%}.col-xs-6{width:50%}.col-xs-5{width:41.66666667%}.col-xs-4{width:33.33333333%}.col-xs-3{width:25%}.col-xs-2{width:16.66666667%}.col-xs-1{width:8.33333333%}.col-xs-pull-12{right:100%}.col-xs-pull-11{right:91.66666667%}.col-xs-pull-10{right:83.33333333%}.col-xs-pull-9{right:75%}.col-xs-pull-8{right:66.66666667%}.col-xs-pull-7{right:58.33333333%}.col-xs-pull-6{right:50%}.col-xs-pull-5{right:41.66666667%}.col-xs-pull-4{right:33.33333333%}.col-xs-pull-3{right:25%}.col-xs-pull-2{right:16.66666667%}.col-xs-pull-1{right:8.33333333%}.col-xs-pull-0{right:0}.col-xs-push-12{left:100%}.col-xs-push-11{left:91.66666667%}.col-xs-push-10{left:83.33333333%}.col-xs-push-9{left:75%}.col-xs-push-8{left:66.66666667%}.col-xs-push-7{left:58.33333333%}.col-xs-push-6{left:50%}.col-xs-push-5{left:41.66666667%}.col-xs-push-4{left:33.33333333%}.col-xs-push-3{left:25%}.col-xs-push-2{left:16.66666667%}.col-xs-push-1{left:8.33333333%}.col-xs-push-0{left:0}.col-xs-offset-12{margin-left:100%}.col-xs-offset-11{margin-left:91.66666667%}.col-xs-offset-10{margin-left:83.33333333%}.col-xs-offset-9{margin-left:75%}.col-xs-offset-8{margin-left:66.66666667%}.col-xs-offset-7{margin-left:58.33333333%}.col-xs-offset-6{margin-left:50%}.col-xs-offset-5{margin-left:41.66666667%}.col-xs-offset-4{margin-left:33.33333333%}.col-xs-offset-3{margin-left:25%}.col-xs-offset-2{margin-left:16.66666667%}.col-xs-offset-1{margin-left:8.33333333%}.col-xs-offset-0{margin-left:0}@media (min-width:768px){.col-sm-1,.col-sm-2,.col-sm-3,.col-sm-4,.col-sm-5,.col-sm-6,.col-sm-7,.col-sm-8,.col-sm-9,.col-sm-10,.col-sm-11,.col-sm-12{float:left}.col-sm-12{width:100%}.col-sm-11{width:91.66666667%}.col-sm-10{width:83.33333333%}.col-sm-9{width:75%}.col-sm-8{width:66.66666667%}.col-sm-7{width:58.33333333%}.col-sm-6{width:50%}.col-sm-5{width:41.66666667%}.col-sm-4{width:33.33333333%}.col-sm-3{width:25%}.col-sm-2{width:16.66666667%}.col-sm-1{width:8.33333333%}.col-sm-pull-12{right:100%}.col-sm-pull-11{right:91.66666667%}.col-sm-pull-10{right:83.33333333%}.col-sm-pull-9{right:75%}.col-sm-pull-8{right:66.66666667%}.col-sm-pull-7{right:58.33333333%}.col-sm-pull-6{right:50%}.col-sm-pull-5{right:41.66666667%}.col-sm-pull-4{right:33.33333333%}.col-sm-pull-3{right:25%}.col-sm-pull-2{right:16.66666667%}.col-sm-pull-1{right:8.33333333%}.col-sm-pull-0{right:0}.col-sm-push-12{left:100%}.col-sm-push-11{left:91.66666667%}.col-sm-push-10{left:83.33333333%}.col-sm-push-9{left:75%}.col-sm-push-8{left:66.66666667%}.col-sm-push-7{left:58.33333333%}.col-sm-push-6{left:50%}.col-sm-push-5{left:41.66666667%}.col-sm-push-4{left:33.33333333%}.col-sm-push-3{left:25%}.col-sm-push-2{left:16.66666667%}.col-sm-push-1{left:8.33333333%}.col-sm-push-0{left:0}.col-sm-offset-12{margin-left:100%}.col-sm-offset-11{margin-left:91.66666667%}.col-sm-offset-10{margin-left:83.33333333%}.col-sm-offset-9{margin-left:75%}.col-sm-offset-8{margin-left:66.66666667%}.col-sm-offset-7{margin-left:58.33333333%}.col-sm-offset-6{margin-left:50%}.col-sm-offset-5{margin-left:41.66666667%}.col-sm-offset-4{margin-left:33.33333333%}.col-sm-offset-3{margin-left:25%}.col-sm-offset-2{margin-left:16.66666667%}.col-sm-offset-1{margin-left:8.33333333%}.col-sm-offset-0{margin-left:0}}@media (min-width:992px){.col-md-1,.col-md-2,.col-md-3,.col-md-4,.col-md-5,.col-md-6,.col-md-7,.col-md-8,.col-md-9,.col-md-10,.col-md-11,.col-md-12{float:left}.col-md-12{width:100%}.col-md-11{width:91.66666667%}.col-md-10{width:83.33333333%}.col-md-9{width:75%}.col-md-8{width:66.66666667%}.col-md-7{width:58.33333333%}.col-md-6{width:50%}.col-md-5{width:41.66666667%}.col-md-4{width:33.33333333%}.col-md-3{width:25%}.col-md-2{width:16.66666667%}.col-md-1{width:8.33333333%}.col-md-pull-12{right:100%}.col-md-pull-11{right:91.66666667%}.col-md-pull-10{right:83.33333333%}.col-md-pull-9{right:75%}.col-md-pull-8{right:66.66666667%}.col-md-pull-7{right:58.33333333%}.col-md-pull-6{right:50%}.col-md-pull-5{right:41.66666667%}.col-md-pull-4{right:33.33333333%}.col-md-pull-3{right:25%}.col-md-pull-2{right:16.66666667%}.col-md-pull-1{right:8.33333333%}.col-md-pull-0{right:0}.col-md-push-12{left:100%}.col-md-push-11{left:91.66666667%}.col-md-push-10{left:83.33333333%}.col-md-push-9{left:75%}.col-md-push-8{left:66.66666667%}.col-md-push-7{left:58.33333333%}.col-md-push-6{left:50%}.col-md-push-5{left:41.66666667%}.col-md-push-4{left:33.33333333%}.col-md-push-3{left:25%}.col-md-push-2{left:16.66666667%}.col-md-push-1{left:8.33333333%}.col-md-push-0{left:0}.col-md-offset-12{margin-left:100%}.col-md-offset-11{margin-left:91.66666667%}.col-md-offset-10{margin-left:83.33333333%}.col-md-offset-9{margin-left:75%}.col-md-offset-8{margin-left:66.66666667%}.col-md-offset-7{margin-left:58.33333333%}.col-md-offset-6{margin-left:50%}.col-md-offset-5{margin-left:41.66666667%}.col-md-offset-4{margin-left:33.33333333%}.col-md-offset-3{margin-left:25%}.col-md-offset-2{margin-left:16.66666667%}.col-md-offset-1{margin-left:8.33333333%}.col-md-offset-0{margin-left:0}}@media (min-width:1200px){.col-lg-1,.col-lg-2,.col-lg-3,.col-lg-4,.col-lg-5,.col-lg-6,.col-lg-7,.col-lg-8,.col-lg-9,.col-lg-10,.col-lg-11,.col-lg-12{float:left}.col-lg-12{width:100%}.col-lg-11{width:91.66666667%}.col-lg-10{width:83.33333333%}.col-lg-9{width:75%}.col-lg-8{width:66.66666667%}.col-lg-7{width:58.33333333%}.col-lg-6{width:50%}.col-lg-5{width:41.66666667%}.col-lg-4{width:33.33333333%}.col-lg-3{width:25%}.col-lg-2{width:16.66666667%}.col-lg-1{width:8.33333333%}.col-lg-pull-12{right:100%}.col-lg-pull-11{right:91.66666667%}.col-lg-pull-10{right:83.33333333%}.col-lg-pull-9{right:75%}.col-lg-pull-8{right:66.66666667%}.col-lg-pull-7{right:58.33333333%}.col-lg-pull-6{right:50%}.col-lg-pull-5{right:41.66666667%}.col-lg-pull-4{right:33.33333333%}.col-lg-pull-3{right:25%}.col-lg-pull-2{right:16.66666667%}.col-lg-pull-1{right:8.33333333%}.col-lg-pull-0{right:0}.col-lg-push-12{left:100%}.col-lg-push-11{left:91.66666667%}.col-lg-push-10{left:83.33333333%}.col-lg-push-9{left:75%}.col-lg-push-8{left:66.66666667%}.col-lg-push-7{left:58.33333333%}.col-lg-push-6{left:50%}.col-lg-push-5{left:41.66666667%}.col-lg-push-4{left:33.33333333%}.col-lg-push-3{left:25%}.col-lg-push-2{left:16.66666667%}.col-lg-push-1{left:8.33333333%}.col-lg-push-0{left:0}.col-lg-offset-12{margin-left:100%}.col-lg-offset-11{margin-left:91.66666667%}.col-lg-offset-10{margin-left:83.33333333%}.col-lg-offset-9{margin-left:75%}.col-lg-offset-8{margin-left:66.66666667%}.col-lg-offset-7{margin-left:58.33333333%}.col-lg-offset-6{margin-left:50%}.col-lg-offset-5{margin-left:41.66666667%}.col-lg-offset-4{margin-left:33.33333333%}.col-lg-offset-3{margin-left:25%}.col-lg-offset-2{margin-left:16.66666667%}.col-lg-offset-1{margin-left:8.33333333%}.col-lg-offset-0{margin-left:0}}table{max-width:100%;background-color:transparent}th{text-align:left}.table{width:100%;margin-bottom:20px}.table>thead>tr>th,.table>tbody>tr>th,.table>tfoot>tr>th,.table>thead>tr>td,.table>tbody>tr>td,.table>tfoot>tr>td{padding:8px;line-height:1.42857143;vertical-align:top;border-top:1px solid #ddd}.table>thead>tr>th{vertical-align:bottom;border-bottom:2px solid #ddd}.table>caption+thead>tr:first-child>th,.table>colgroup+thead>tr:first-child>th,.table>thead:first-child>tr:first-child>th,.table>caption+thead>tr:first-child>td,.table>colgroup+thead>tr:first-child>td,.table>thead:first-child>tr:first-child>td{border-top:0}.table>tbody+tbody{border-top:2px solid #ddd}.table .table{background-color:#fff}.table-condensed>thead>tr>th,.table-condensed>tbody>tr>th,.table-condensed>tfoot>tr>th,.table-condensed>thead>tr>td,.table-condensed>tbody>tr>td,.table-condensed>tfoot>tr>td{padding:5px}.table-bordered{border:1px solid #ddd}.table-bordered>thead>tr>th,.table-bordered>tbody>tr>th,.table-bordered>tfoot>tr>th,.table-bordered>thead>tr>td,.table-bordered>tbody>tr>td,.table-bordered>tfoot>tr>td{border:1px solid #ddd}.table-bordered>thead>tr>th,.table-bordered>thead>tr>td{border-bottom-width:2px}.table-striped>tbody>tr:nth-child(odd)>td,.table-striped>tbody>tr:nth-child(odd)>th{background-color:#f9f9f9}.table-hover>tbody>tr:hover>td,.table-hover>tbody>tr:hover>th{background-color:#f5f5f5}table col[class*=col-]{position:static;float:none;display:table-column}table td[class*=col-],table th[class*=col-]{position:static;float:none;display:table-cell}.table>thead>tr>td.active,.table>tbody>tr>td.active,.table>tfoot>tr>td.active,.table>thead>tr>th.active,.table>tbody>tr>th.active,.table>tfoot>tr>th.active,.table>thead>tr.active>td,.table>tbody>tr.active>td,.table>tfoot>tr.active>td,.table>thead>tr.active>th,.table>tbody>tr.active>th,.table>tfoot>tr.active>th{background-color:#f5f5f5}.table-hover>tbody>tr>td.active:hover,.table-hover>tbody>tr>th.active:hover,.table-hover>tbody>tr.active:hover>td,.table-hover>tbody>tr.active:hover>th{background-color:#e8e8e8}.table>thead>tr>td.success,.table>tbody>tr>td.success,.table>tfoot>tr>td.success,.table>thead>tr>th.success,.table>tbody>tr>th.success,.table>tfoot>tr>th.success,.table>thead>tr.success>td,.table>tbody>tr.success>td,.table>tfoot>tr.success>td,.table>thead>tr.success>th,.table>tbody>tr.success>th,.table>tfoot>tr.success>th{background-color:#dff0d8}.table-hover>tbody>tr>td.success:hover,.table-hover>tbody>tr>th.success:hover,.table-hover>tbody>tr.success:hover>td,.table-hover>tbody>tr.success:hover>th{background-color:#d0e9c6}.table>thead>tr>td.info,.table>tbody>tr>td.info,.table>tfoot>tr>td.info,.table>thead>tr>th.info,.table>tbody>tr>th.info,.table>tfoot>tr>th.info,.table>thead>tr.info>td,.table>tbody>tr.info>td,.table>tfoot>tr.info>td,.table>thead>tr.info>th,.table>tbody>tr.info>th,.table>tfoot>tr.info>th{background-color:#d9edf7}.table-hover>tbody>tr>td.info:hover,.table-hover>tbody>tr>th.info:hover,.table-hover>tbody>tr.info:hover>td,.table-hover>tbody>tr.info:hover>th{background-color:#c4e3f3}.table>thead>tr>td.warning,.table>tbody>tr>td.warning,.table>tfoot>tr>td.warning,.table>thead>tr>th.warning,.table>tbody>tr>th.warning,.table>tfoot>tr>th.warning,.table>thead>tr.warning>td,.table>tbody>tr.warning>td,.table>tfoot>tr.warning>td,.table>thead>tr.warning>th,.table>tbody>tr.warning>th,.table>tfoot>tr.warning>th{background-color:#fcf8e3}.table-hover>tbody>tr>td.warning:hover,.table-hover>tbody>tr>th.warning:hover,.table-hover>tbody>tr.warning:hover>td,.table-hover>tbody>tr.warning:hover>th{background-color:#faf2cc}.table>thead>tr>td.danger,.table>tbody>tr>td.danger,.table>tfoot>tr>td.danger,.table>thead>tr>th.danger,.table>tbody>tr>th.danger,.table>tfoot>tr>th.danger,.table>thead>tr.danger>td,.table>tbody>tr.danger>td,.table>tfoot>tr.danger>td,.table>thead>tr.danger>th,.table>tbody>tr.danger>th,.table>tfoot>tr.danger>th{background-color:#f2dede}.table-hover>tbody>tr>td.danger:hover,.table-hover>tbody>tr>th.danger:hover,.table-hover>tbody>tr.danger:hover>td,.table-hover>tbody>tr.danger:hover>th{background-color:#ebcccc}@media (max-width:767px){.table-responsive{width:100%;margin-bottom:15px;overflow-y:hidden;overflow-x:scroll;-ms-overflow-style:-ms-autohiding-scrollbar;border:1px solid #ddd;-webkit-overflow-scrolling:touch}.table-responsive>.table{margin-bottom:0}.table-responsive>.table>thead>tr>th,.table-responsive>.table>tbody>tr>th,.table-responsive>.table>tfoot>tr>th,.table-responsive>.table>thead>tr>td,.table-responsive>.table>tbody>tr>td,.table-responsive>.table>tfoot>tr>td{white-space:nowrap}.table-responsive>.table-bordered{border:0}.table-responsive>.table-bordered>thead>tr>th:first-child,.table-responsive>.table-bordered>tbody>tr>th:first-child,.table-responsive>.table-bordered>tfoot>tr>th:first-child,.table-responsive>.table-bordered>thead>tr>td:first-child,.table-responsive>.table-bordered>tbody>tr>td:first-child,.table-responsive>.table-bordered>tfoot>tr>td:first-child{border-left:0}.table-responsive>.table-bordered>thead>tr>th:last-child,.table-responsive>.table-bordered>tbody>tr>th:last-child,.table-responsive>.table-bordered>tfoot>tr>th:last-child,.table-responsive>.table-bordered>thead>tr>td:last-child,.table-responsive>.table-bordered>tbody>tr>td:last-child,.table-responsive>.table-bordered>tfoot>tr>td:last-child{border-right:0}.table-responsive>.table-bordered>tbody>tr:last-child>th,.table-responsive>.table-bordered>tfoot>tr:last-child>th,.table-responsive>.table-bordered>tbody>tr:last-child>td,.table-responsive>.table-bordered>tfoot>tr:last-child>td{border-bottom:0}}fieldset{padding:0;margin:0;border:0;min-width:0}pozarevac123{display:block;width:100%;padding:0;margin-bottom:20px;font-size:21px;line-height:inherit;color:#333;border:0;border-bottom:1px solid #e5e5e5}label{display:inline-block;margin-bottom:5px;font-weight:700}input[type=search]{-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}input[type=radio],input[type=checkbox]{margin:4px 0 0;margin-top:1px \9;line-height:normal}input[type=file]{display:block}input[type=range]{display:block;width:100%}select[multiple],select[size]{height:auto}input[type=file]:focus,input[type=radio]:focus,input[type=checkbox]:focus{outline:thin dotted;outline:5px auto -webkit-focus-ring-color;outline-offset:-2px}output{display:block;padding-top:7px;font-size:14px;line-height:1.42857143;color:#555}.form-control{display:block;width:100%;height:34px;padding:6px 12px;font-size:14px;line-height:1.42857143;color:#555;background-color:#fff;background-image:none;border:1px solid #ccc;border-radius:4px;-webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.075);box-shadow:inset 0 1px 1px rgba(0,0,0,.075);-webkit-transition:border-color ease-in-out .15s,box-shadow ease-in-out .15s;transition:border-color ease-in-out .15s,box-shadow ease-in-out .15s}.form-control:focus{border-color:#66afe9;outline:0;-webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.075),0 0 8px rgba(102,175,233,.6);box-shadow:inset 0 1px 1px rgba(0,0,0,.075),0 0 8px rgba(102,175,233,.6)}.form-control::-moz-placeholder{color:#999;opacity:1}.form-control:-ms-input-placeholder{color:#999}.form-control::-webkit-input-placeholder{color:#999}.form-control[disabled],.form-control[readonly],fieldset[disabled] .form-control{cursor:not-allowed;background-color:#eee;opacity:1}textarea.form-control{height:auto}input[type=search]{-webkit-appearance:none}input[type=date]{line-height:34px}.form-group{margin-bottom:15px}.radio,.checkbox{display:block;min-height:20px;margin-top:10px;margin-bottom:10px;padding-left:20px}.radio label,.checkbox label{display:inline;font-weight:400;cursor:pointer}.radio input[type=radio],.radio-inline input[type=radio],.checkbox input[type=checkbox],.checkbox-inline input[type=checkbox]{float:left;margin-left:-20px}.radio+.radio,.checkbox+.checkbox{margin-top:-5px}.radio-inline,.checkbox-inline{display:inline-block;padding-left:20px;margin-bottom:0;vertical-align:middle;font-weight:400;cursor:pointer}.radio-inline+.radio-inline,.checkbox-inline+.checkbox-inline{margin-top:0;margin-left:10px}input[type=radio][disabled],input[type=checkbox][disabled],.radio[disabled],.radio-inline[disabled],.checkbox[disabled],.checkbox-inline[disabled],fieldset[disabled] input[type=radio],fieldset[disabled] input[type=checkbox],fieldset[disabled] .radio,fieldset[disabled] .radio-inline,fieldset[disabled] .checkbox,fieldset[disabled] .checkbox-inline{cursor:not-allowed}.input-sm{height:30px;padding:5px 10px;font-size:12px;line-height:1.5;border-radius:3px}select.input-sm{height:30px;line-height:30px}textarea.input-sm,select[multiple].input-sm{height:auto}.input-lg{height:46px;padding:10px 16px;font-size:18px;line-height:1.33;border-radius:6px}select.input-lg{height:46px;line-height:46px}textarea.input-lg,select[multiple].input-lg{height:auto}.has-feedback{position:relative}.has-feedback .form-control{padding-right:42.5px}.has-feedback .form-control-feedback{position:absolute;top:25px;right:0;display:block;width:34px;height:34px;line-height:34px;text-align:center}.has-success .help-block,.has-success .control-label,.has-success .radio,.has-success .checkbox,.has-success .radio-inline,.has-success .checkbox-inline{color:#3c763d}.has-success .form-control{border-color:#3c763d;-webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.075);box-shadow:inset 0 1px 1px rgba(0,0,0,.075)}.has-success .form-control:focus{border-color:#2b542c;-webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.075),0 0 6px #67b168;box-shadow:inset 0 1px 1px rgba(0,0,0,.075),0 0 6px #67b168}.has-success .input-group-addon{color:#3c763d;border-color:#3c763d;background-color:#dff0d8}.has-success .form-control-feedback{color:#3c763d}.has-warning .help-block,.has-warning .control-label,.has-warning .radio,.has-warning .checkbox,.has-warning .radio-inline,.has-warning .checkbox-inline{color:#8a6d3b}.has-warning .form-control{border-color:#8a6d3b;-webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.075);box-shadow:inset 0 1px 1px rgba(0,0,0,.075)}.has-warning .form-control:focus{border-color:#66512c;-webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.075),0 0 6px #c0a16b;box-shadow:inset 0 1px 1px rgba(0,0,0,.075),0 0 6px #c0a16b}.has-warning .input-group-addon{color:#8a6d3b;border-color:#8a6d3b;background-color:#fcf8e3}.has-warning .form-control-feedback{color:#8a6d3b}.has-error .help-block,.has-error .control-label,.has-error .radio,.has-error .checkbox,.has-error .radio-inline,.has-error .checkbox-inline{color:#a94442}.has-error .form-control{border-color:#a94442;-webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.075);box-shadow:inset 0 1px 1px rgba(0,0,0,.075)}.has-error .form-control:focus{border-color:#843534;-webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.075),0 0 6px #ce8483;box-shadow:inset 0 1px 1px rgba(0,0,0,.075),0 0 6px #ce8483}.has-error .input-group-addon{color:#a94442;border-color:#a94442;background-color:#f2dede}.has-error .form-control-feedback{color:#a94442}.form-control-static{margin-bottom:0}.help-block{display:block;margin-top:5px;margin-bottom:10px;color:#737373}@media (min-width:768px){.form-inline .form-group{display:inline-block;margin-bottom:0;vertical-align:middle}.form-inline .form-control{display:inline-block;width:auto;vertical-align:middle}.form-inline .input-group>.form-control{width:100%}.form-inline .control-label{margin-bottom:0;vertical-align:middle}.form-inline .radio,.form-inline .checkbox{display:inline-block;margin-top:0;margin-bottom:0;padding-left:0;vertical-align:middle}.form-inline .radio input[type=radio],.form-inline .checkbox input[type=checkbox]{float:none;margin-left:0}.form-inline .has-feedback .form-control-feedback{top:0}}.form-horizontal .control-label,.form-horizontal .radio,.form-horizontal .checkbox,.form-horizontal .radio-inline,.form-horizontal .checkbox-inline{margin-top:0;margin-bottom:0;padding-top:7px}.form-horizontal .radio,.form-horizontal .checkbox{min-height:27px}.form-horizontal .form-group{margin-left:-15px;margin-right:-15px}.form-horizontal .form-control-static{padding-top:7px}@media (min-width:768px){.form-horizontal .control-label{text-align:right}}.form-horizontal .has-feedback .form-control-feedback{top:0;right:15px}.btn{display:inline-block;margin-bottom:0;font-weight:400;text-align:center;vertical-align:middle;cursor:pointer;background-image:none;border:1px solid transparent;white-space:nowrap;padding:6px 12px;font-size:14px;line-height:1.42857143;border-radius:4px;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}.btn:focus,.btn:active:focus,.btn.active:focus{outline:thin dotted;outline:5px auto -webkit-focus-ring-color;outline-offset:-2px}.btn:hover,.btn:focus{color:#333;text-decoration:none}.btn:active,.btn.active{outline:0;background-image:none;-webkit-box-shadow:inset 0 3px 5px rgba(0,0,0,.125);box-shadow:inset 0 3px 5px rgba(0,0,0,.125)}.btn.disabled,.btn[disabled],fieldset[disabled] .btn{cursor:not-allowed;pointer-events:none;opacity:.65;filter:alpha(opacity=65);-webkit-box-shadow:none;box-shadow:none}.btn-default{color:#333;background-color:#fff;border-color:#ccc}.btn-default:hover,.btn-default:focus,.btn-default:active,.btn-default.active,.open .dropdown-toggle.btn-default{color:#333;background-color:#ebebeb;border-color:#adadad}.btn-default:active,.btn-default.active,.open .dropdown-toggle.btn-default{background-image:none}.btn-default.disabled,.btn-default[disabled],fieldset[disabled] .btn-default,.btn-default.disabled:hover,.btn-default[disabled]:hover,fieldset[disabled] .btn-default:hover,.btn-default.disabled:focus,.btn-default[disabled]:focus,fieldset[disabled] .btn-default:focus,.btn-default.disabled:active,.btn-default[disabled]:active,fieldset[disabled] .btn-default:active,.btn-default.disabled.active,.btn-default[disabled].active,fieldset[disabled] .btn-default.active{background-color:#fff;border-color:#ccc}.btn-default .badge{color:#fff;background-color:#333}.btn-primary{color:#fff;background-color:#428bca;border-color:#357ebd}.btn-primary:hover,.btn-primary:focus,.btn-primary:active,.btn-primary.active,.open .dropdown-toggle.btn-primary{color:#fff;background-color:#3276b1;border-color:#285e8e}.btn-primary:active,.btn-primary.active,.open .dropdown-toggle.btn-primary{background-image:none}.btn-primary.disabled,.btn-primary[disabled],fieldset[disabled] .btn-primary,.btn-primary.disabled:hover,.btn-primary[disabled]:hover,fieldset[disabled] .btn-primary:hover,.btn-primary.disabled:focus,.btn-primary[disabled]:focus,fieldset[disabled] .btn-primary:focus,.btn-primary.disabled:active,.btn-primary[disabled]:active,fieldset[disabled] .btn-primary:active,.btn-primary.disabled.active,.btn-primary[disabled].active,fieldset[disabled] .btn-primary.active{background-color:#428bca;border-color:#357ebd}.btn-primary .badge{color:#428bca;background-color:#fff}.btn-success{color:#fff;background-color:#5cb85c;border-color:#4cae4c}.btn-success:hover,.btn-success:focus,.btn-success:active,.btn-success.active,.open .dropdown-toggle.btn-success{color:#fff;background-color:#47a447;border-color:#398439}.btn-success:active,.btn-success.active,.open .dropdown-toggle.btn-success{background-image:none}.btn-success.disabled,.btn-success[disabled],fieldset[disabled] .btn-success,.btn-success.disabled:hover,.btn-success[disabled]:hover,fieldset[disabled] .btn-success:hover,.btn-success.disabled:focus,.btn-success[disabled]:focus,fieldset[disabled] .btn-success:focus,.btn-success.disabled:active,.btn-success[disabled]:active,fieldset[disabled] .btn-success:active,.btn-success.disabled.active,.btn-success[disabled].active,fieldset[disabled] .btn-success.active{background-color:#5cb85c;border-color:#4cae4c}.btn-success .badge{color:#5cb85c;background-color:#fff}.btn-info{color:#fff;background-color:#5bc0de;border-color:#46b8da}.btn-info:hover,.btn-info:focus,.btn-info:active,.btn-info.active,.open .dropdown-toggle.btn-info{color:#fff;background-color:#39b3d7;border-color:#269abc}.btn-info:active,.btn-info.active,.open .dropdown-toggle.btn-info{background-image:none}.btn-info.disabled,.btn-info[disabled],fieldset[disabled] .btn-info,.btn-info.disabled:hover,.btn-info[disabled]:hover,fieldset[disabled] .btn-info:hover,.btn-info.disabled:focus,.btn-info[disabled]:focus,fieldset[disabled] .btn-info:focus,.btn-info.disabled:active,.btn-info[disabled]:active,fieldset[disabled] .btn-info:active,.btn-info.disabled.active,.btn-info[disabled].active,fieldset[disabled] .btn-info.active{background-color:#5bc0de;border-color:#46b8da}.btn-info .badge{color:#5bc0de;background-color:#fff}.btn-warning{color:#fff;background-color:#f0ad4e;border-color:#eea236}.btn-warning:hover,.btn-warning:focus,.btn-warning:active,.btn-warning.active,.open .dropdown-toggle.btn-warning{color:#fff;background-color:#ed9c28;border-color:#d58512}.btn-warning:active,.btn-warning.active,.open .dropdown-toggle.btn-warning{background-image:none}.btn-warning.disabled,.btn-warning[disabled],fieldset[disabled] .btn-warning,.btn-warning.disabled:hover,.btn-warning[disabled]:hover,fieldset[disabled] .btn-warning:hover,.btn-warning.disabled:focus,.btn-warning[disabled]:focus,fieldset[disabled] .btn-warning:focus,.btn-warning.disabled:active,.btn-warning[disabled]:active,fieldset[disabled] .btn-warning:active,.btn-warning.disabled.active,.btn-warning[disabled].active,fieldset[disabled] .btn-warning.active{background-color:#f0ad4e;border-color:#eea236}.btn-warning .badge{color:#f0ad4e;background-color:#fff}.btn-danger{color:#fff;background-color:#d9534f;border-color:#d43f3a}.btn-danger:hover,.btn-danger:focus,.btn-danger:active,.btn-danger.active,.open .dropdown-toggle.btn-danger{color:#fff;background-color:#d2322d;border-color:#ac2925}.btn-danger:active,.btn-danger.active,.open .dropdown-toggle.btn-danger{background-image:none}.btn-danger.disabled,.btn-danger[disabled],fieldset[disabled] .btn-danger,.btn-danger.disabled:hover,.btn-danger[disabled]:hover,fieldset[disabled] .btn-danger:hover,.btn-danger.disabled:focus,.btn-danger[disabled]:focus,fieldset[disabled] .btn-danger:focus,.btn-danger.disabled:active,.btn-danger[disabled]:active,fieldset[disabled] .btn-danger:active,.btn-danger.disabled.active,.btn-danger[disabled].active,fieldset[disabled] .btn-danger.active{background-color:#d9534f;border-color:#d43f3a}.btn-danger .badge{color:#d9534f;background-color:#fff}.btn-link{color:#428bca;font-weight:400;cursor:pointer;border-radius:0}.btn-link,.btn-link:active,.btn-link[disabled],fieldset[disabled] .btn-link{background-color:transparent;-webkit-box-shadow:none;box-shadow:none}.btn-link,.btn-link:hover,.btn-link:focus,.btn-link:active{border-color:transparent}.btn-link:hover,.btn-link:focus{color:#2a6496;text-decoration:underline;background-color:transparent}.btn-link[disabled]:hover,fieldset[disabled] .btn-link:hover,.btn-link[disabled]:focus,fieldset[disabled] .btn-link:focus{color:#999;text-decoration:none}.btn-lg,.btn-group-lg>.btn{padding:10px 16px;font-size:18px;line-height:1.33;border-radius:6px}.btn-sm,.btn-group-sm>.btn{padding:5px 10px;font-size:12px;line-height:1.5;border-radius:3px}.btn-xs,.btn-group-xs>.btn{padding:1px 5px;font-size:12px;line-height:1.5;border-radius:3px}.btn-block{display:block;width:100%;padding-left:0;padding-right:0}.btn-block+.btn-block{margin-top:5px}input[type=submit].btn-block,input[type=reset].btn-block,input[type=button].btn-block{width:100%}.fade{opacity:0;-webkit-transition:opacity .15s linear;transition:opacity .15s linear}.fade.in{opacity:1}.collapse{display:none}.collapse.in{display:block}.collapsing{position:relative;height:0;overflow:hidden;-webkit-transition:height .35s ease;transition:height .35s ease}@font-face{font-family:'Glyphicons Halflings';src:url(../fonts/glyphicons-halflings-regular.eot);src:url(../fonts/glyphicons-halflings-regular.eot?#iefix) format('embedded-opentype'),url(../fonts/glyphicons-halflings-regular.woff) format('woff'),url(../fonts/glyphicons-halflings-regular.ttf) format('truetype'),url(../fonts/glyphicons-halflings-regular.svg#glyphicons_halflingsregular) format('svg')}.glyphicon{position:relative;top:1px;display:inline-block;font-family:'Glyphicons Halflings';font-style:normal;font-weight:400;line-height:1;-webkit-font-smoothing:antialiased;-moz-osx-font-smoothing:grayscale}.glyphicon-asterisk:before{content:"\2a"}.glyphicon-plus:before{content:"\2b"}.glyphicon-euro:before{content:"\20ac"}.glyphicon-minus:before{content:"\2212"}.glyphicon-cloud:before{content:"\2601"}.glyphicon-envelope:before{content:"\2709"}.glyphicon-pencil:before{content:"\270f"}.glyphicon-glass:before{content:"\e001"}.glyphicon-music:before{content:"\e002"}.glyphicon-search:before{content:"\e003"}.glyphicon-heart:before{content:"\e005"}.glyphicon-star:before{content:"\e006"}.glyphicon-star-empty:before{content:"\e007"}.glyphicon-user:before{content:"\e008"}.glyphicon-film:before{content:"\e009"}.glyphicon-th-large:before{content:"\e010"}.glyphicon-th:before{content:"\e011"}.glyphicon-th-list:before{content:"\e012"}.glyphicon-ok:before{content:"\e013"}.glyphicon-remove:before{content:"\e014"}.glyphicon-zoom-in:before{content:"\e015"}.glyphicon-zoom-out:before{content:"\e016"}.glyphicon-off:before{content:"\e017"}.glyphicon-signal:before{content:"\e018"}.glyphicon-cog:before{content:"\e019"}.glyphicon-trash:before{content:"\e020"}.glyphicon-home:before{content:"\e021"}.glyphicon-file:before{content:"\e022"}.glyphicon-time:before{content:"\e023"}.glyphicon-road:before{content:"\e024"}.glyphicon-download-alt:before{content:"\e025"}.glyphicon-download:before{content:"\e026"}.glyphicon-upload:before{content:"\e027"}.glyphicon-inbox:before{content:"\e028"}.glyphicon-play-circle:before{content:"\e029"}.glyphicon-repeat:before{content:"\e030"}.glyphicon-refresh:before{content:"\e031"}.glyphicon-list-alt:before{content:"\e032"}.glyphicon-lock:before{content:"\e033"}.glyphicon-flag:before{content:"\e034"}.glyphicon-headphones:before{content:"\e035"}.glyphicon-volume-off:before{content:"\e036"}.glyphicon-volume-down:before{content:"\e037"}.glyphicon-volume-up:before{content:"\e038"}.glyphicon-qrcode:before{content:"\e039"}.glyphicon-barcode:before{content:"\e040"}.glyphicon-tag:before{content:"\e041"}.glyphicon-tags:before{content:"\e042"}.glyphicon-book:before{content:"\e043"}.glyphicon-bookmark:before{content:"\e044"}.glyphicon-print:before{content:"\e045"}.glyphicon-camera:before{content:"\e046"}.glyphicon-font:before{content:"\e047"}.glyphicon-bold:before{content:"\e048"}.glyphicon-italic:before{content:"\e049"}.glyphicon-text-height:before{content:"\e050"}.glyphicon-text-width:before{content:"\e051"}.glyphicon-align-left:before{content:"\e052"}.glyphicon-align-center:before{content:"\e053"}.glyphicon-align-right:before{content:"\e054"}.glyphicon-align-justify:before{content:"\e055"}.glyphicon-list:before{content:"\e056"}.glyphicon-indent-left:before{content:"\e057"}.glyphicon-indent-right:before{content:"\e058"}.glyphicon-facetime-video:before{content:"\e059"}.glyphicon-picture:before{content:"\e060"}.glyphicon-map-marker:before{content:"\e062"}.glyphicon-adjust:before{content:"\e063"}.glyphicon-tint:before{content:"\e064"}.glyphicon-edit:before{content:"\e065"}.glyphicon-share:before{content:"\e066"}.glyphicon-check:before{content:"\e067"}.glyphicon-move:before{content:"\e068"}.glyphicon-step-backward:before{content:"\e069"}.glyphicon-fast-backward:before{content:"\e070"}.glyphicon-backward:before{content:"\e071"}.glyphicon-play:before{content:"\e072"}.glyphicon-pause:before{content:"\e073"}.glyphicon-stop:before{content:"\e074"}.glyphicon-forward:before{content:"\e075"}.glyphicon-fast-forward:before{content:"\e076"}.glyphicon-step-forward:before{content:"\e077"}.glyphicon-eject:before{content:"\e078"}.glyphicon-chevron-left:before{content:"\e079"}.glyphicon-chevron-right:before{content:"\e080"}.glyphicon-plus-sign:before{content:"\e081"}.glyphicon-minus-sign:before{content:"\e082"}.glyphicon-remove-sign:before{content:"\e083"}.glyphicon-ok-sign:before{content:"\e084"}.glyphicon-question-sign:before{content:"\e085"}.glyphicon-info-sign:before{content:"\e086"}.glyphicon-screenshot:before{content:"\e087"}.glyphicon-remove-circle:before{content:"\e088"}.glyphicon-ok-circle:before{content:"\e089"}.glyphicon-ban-circle:before{content:"\e090"}.glyphicon-arrow-left:before{content:"\e091"}.glyphicon-arrow-right:before{content:"\e092"}.glyphicon-arrow-up:before{content:"\e093"}.glyphicon-arrow-down:before{content:"\e094"}.glyphicon-share-alt:before{content:"\e095"}.glyphicon-resize-full:before{content:"\e096"}.glyphicon-resize-small:before{content:"\e097"}.glyphicon-exclamation-sign:before{content:"\e101"}.glyphicon-gift:before{content:"\e102"}.glyphicon-leaf:before{content:"\e103"}.glyphicon-fire:before{content:"\e104"}.glyphicon-eye-open:before{content:"\e105"}.glyphicon-eye-close:before{content:"\e106"}.glyphicon-warning-sign:before{content:"\e107"}.glyphicon-plane:before{content:"\e108"}.glyphicon-calendar:before{content:"\e109"}.glyphicon-random:before{content:"\e110"}.glyphicon-comment:before{content:"\e111"}.glyphicon-magnet:before{content:"\e112"}.glyphicon-chevron-up:before{content:"\e113"}.glyphicon-chevron-down:before{content:"\e114"}.glyphicon-retweet:before{content:"\e115"}.glyphicon-shopping-cart:before{content:"\e116"}.glyphicon-folder-close:before{content:"\e117"}.glyphicon-folder-open:before{content:"\e118"}.glyphicon-resize-vertical:before{content:"\e119"}.glyphicon-resize-horizontal:before{content:"\e120"}.glyphicon-hdd:before{content:"\e121"}.glyphicon-bullhorn:before{content:"\e122"}.glyphicon-bell:before{content:"\e123"}.glyphicon-certificate:before{content:"\e124"}.glyphicon-thumbs-up:before{content:"\e125"}.glyphicon-thumbs-down:before{content:"\e126"}.glyphicon-hand-right:before{content:"\e127"}.glyphicon-hand-left:before{content:"\e128"}.glyphicon-hand-up:before{content:"\e129"}.glyphicon-hand-down:before{content:"\e130"}.glyphicon-circle-arrow-right:before{content:"\e131"}.glyphicon-circle-arrow-left:before{content:"\e132"}.glyphicon-circle-arrow-up:before{content:"\e133"}.glyphicon-circle-arrow-down:before{content:"\e134"}.glyphicon-globe:before{content:"\e135"}.glyphicon-wrench:before{content:"\e136"}.glyphicon-tasks:before{content:"\e137"}.glyphicon-filter:before{content:"\e138"}.glyphicon-briefcase:before{content:"\e139"}.glyphicon-fullscreen:before{content:"\e140"}.glyphicon-dashboard:before{content:"\e141"}.glyphicon-paperclip:before{content:"\e142"}.glyphicon-heart-empty:before{content:"\e143"}.glyphicon-link:before{content:"\e144"}.glyphicon-phone:before{content:"\e145"}.glyphicon-pushpin:before{content:"\e146"}.glyphicon-usd:before{content:"\e148"}.glyphicon-gbp:before{content:"\e149"}.glyphicon-sort:before{content:"\e150"}.glyphicon-sort-by-alphabet:before{content:"\e151"}.glyphicon-sort-by-alphabet-alt:before{content:"\e152"}.glyphicon-sort-by-order:before{content:"\e153"}.glyphicon-sort-by-order-alt:before{content:"\e154"}.glyphicon-sort-by-attributes:before{content:"\e155"}.glyphicon-sort-by-attributes-alt:before{content:"\e156"}.glyphicon-unchecked:before{content:"\e157"}.glyphicon-expand:before{content:"\e158"}.glyphicon-collapse-down:before{content:"\e159"}.glyphicon-collapse-up:before{content:"\e160"}.glyphicon-log-in:before{content:"\e161"}.glyphicon-flash:before{content:"\e162"}.glyphicon-log-out:before{content:"\e163"}.glyphicon-new-window:before{content:"\e164"}.glyphicon-record:before{content:"\e165"}.glyphicon-save:before{content:"\e166"}.glyphicon-open:before{content:"\e167"}.glyphicon-saved:before{content:"\e168"}.glyphicon-import:before{content:"\e169"}.glyphicon-export:before{content:"\e170"}.glyphicon-send:before{content:"\e171"}.glyphicon-floppy-disk:before{content:"\e172"}.glyphicon-floppy-saved:before{content:"\e173"}.glyphicon-floppy-remove:before{content:"\e174"}.glyphicon-floppy-save:before{content:"\e175"}.glyphicon-floppy-open:before{content:"\e176"}.glyphicon-credit-card:before{content:"\e177"}.glyphicon-transfer:before{content:"\e178"}.glyphicon-cutlery:before{content:"\e179"}.glyphicon-header:before{content:"\e180"}.glyphicon-compressed:before{content:"\e181"}.glyphicon-earphone:before{content:"\e182"}.glyphicon-phone-alt:before{content:"\e183"}.glyphicon-tower:before{content:"\e184"}.glyphicon-stats:before{content:"\e185"}.glyphicon-sd-video:before{content:"\e186"}.glyphicon-hd-video:before{content:"\e187"}.glyphicon-subtitles:before{content:"\e188"}.glyphicon-sound-stereo:before{content:"\e189"}.glyphicon-sound-dolby:before{content:"\e190"}.glyphicon-sound-5-1:before{content:"\e191"}.glyphicon-sound-6-1:before{content:"\e192"}.glyphicon-sound-7-1:before{content:"\e193"}.glyphicon-copyright-mark:before{content:"\e194"}.glyphicon-registration-mark:before{content:"\e195"}.glyphicon-cloud-download:before{content:"\e197"}.glyphicon-cloud-upload:before{content:"\e198"}.glyphicon-tree-conifer:before{content:"\e199"}.glyphicon-tree-deciduous:before{content:"\e200"}.caret{display:inline-block;width:0;height:0;margin-left:2px;vertical-align:middle;border-top:4px solid;border-right:4px solid transparent;border-left:4px solid transparent}.dropdown{position:relative}.dropdown-toggle:focus{outline:0}.dropdown-menu{position:absolute;top:100%;left:0;z-index:1000;display:none;float:left;min-width:160px;padding:5px 0;margin:2px 0 0;list-style:none;font-size:14px;background-color:#fff;border:1px solid #ccc;border:1px solid rgba(0,0,0,.15);border-radius:4px;-webkit-box-shadow:0 6px 12px rgba(0,0,0,.175);box-shadow:0 6px 12px rgba(0,0,0,.175);background-clip:padding-box}.dropdown-menu.pull-right{right:0;left:auto}.dropdown-menu .divider{height:1px;margin:9px 0;overflow:hidden;background-color:#e5e5e5}.dropdown-menu>li>a{display:block;padding:3px 20px;clear:both;font-weight:400;line-height:1.42857143;color:#333;white-space:nowrap}.dropdown-menu>li>a:hover,.dropdown-menu>li>a:focus{text-decoration:none;color:#262626;background-color:#f5f5f5}.dropdown-menu>.active>a,.dropdown-menu>.active>a:hover,.dropdown-menu>.active>a:focus{color:#fff;text-decoration:none;outline:0;background-color:#428bca}.dropdown-menu>.disabled>a,.dropdown-menu>.disabled>a:hover,.dropdown-menu>.disabled>a:focus{color:#999}.dropdown-menu>.disabled>a:hover,.dropdown-menu>.disabled>a:focus{text-decoration:none;background-color:transparent;background-image:none;filter:progid:DXImageTransform.Microsoft.gradient(enabled=false);cursor:not-allowed}.open>.dropdown-menu{display:block}.open>a{outline:0}.dropdown-menu-right{left:auto;right:0}.dropdown-menu-left{left:0;right:auto}.dropdown-header{display:block;padding:3px 20px;font-size:12px;line-height:1.42857143;color:#999}.dropdown-backdrop{position:fixed;left:0;right:0;bottom:0;top:0;z-index:990}.pull-right>.dropdown-menu{right:0;left:auto}.dropup .caret,.navbar-fixed-bottom .dropdown .caret{border-top:0;border-bottom:4px solid;content:""}.dropup .dropdown-menu,.navbar-fixed-bottom .dropdown .dropdown-menu{top:auto;bottom:100%;margin-bottom:1px}@media (min-width:768px){.navbar-right .dropdown-menu{left:auto;right:0}.navbar-right .dropdown-menu-left{left:0;right:auto}}.btn-group,.btn-group-vertical{position:relative;display:inline-block;vertical-align:middle}.btn-group>.btn,.btn-group-vertical>.btn{position:relative;float:left}.btn-group>.btn:hover,.btn-group-vertical>.btn:hover,.btn-group>.btn:focus,.btn-group-vertical>.btn:focus,.btn-group>.btn:active,.btn-group-vertical>.btn:active,.btn-group>.btn.active,.btn-group-vertical>.btn.active{z-index:2}.btn-group>.btn:focus,.btn-group-vertical>.btn:focus{outline:0}.btn-group .btn+.btn,.btn-group .btn+.btn-group,.btn-group .btn-group+.btn,.btn-group .btn-group+.btn-group{margin-left:-1px}.btn-toolbar{margin-left:-5px}.btn-toolbar .btn-group,.btn-toolbar .input-group{float:left}.btn-toolbar>.btn,.btn-toolbar>.btn-group,.btn-toolbar>.input-group{margin-left:5px}.btn-group>.btn:not(:first-child):not(:last-child):not(.dropdown-toggle){border-radius:0}.btn-group>.btn:first-child{margin-left:0}.btn-group>.btn:first-child:not(:last-child):not(.dropdown-toggle){border-bottom-right-radius:0;border-top-right-radius:0}.btn-group>.btn:last-child:not(:first-child),.btn-group>.dropdown-toggle:not(:first-child){border-bottom-left-radius:0;border-top-left-radius:0}.btn-group>.btn-group{float:left}.btn-group>.btn-group:not(:first-child):not(:last-child)>.btn{border-radius:0}.btn-group>.btn-group:first-child>.btn:last-child,.btn-group>.btn-group:first-child>.dropdown-toggle{border-bottom-right-radius:0;border-top-right-radius:0}.btn-group>.btn-group:last-child>.btn:first-child{border-bottom-left-radius:0;border-top-left-radius:0}.btn-group .dropdown-toggle:active,.btn-group.open .dropdown-toggle{outline:0}.btn-group>.btn+.dropdown-toggle{padding-left:8px;padding-right:8px}.btn-group>.btn-lg+.dropdown-toggle{padding-left:12px;padding-right:12px}.btn-group.open .dropdown-toggle{-webkit-box-shadow:inset 0 3px 5px rgba(0,0,0,.125);box-shadow:inset 0 3px 5px rgba(0,0,0,.125)}.btn-group.open .dropdown-toggle.btn-link{-webkit-box-shadow:none;box-shadow:none}.btn .caret{margin-left:0}.btn-lg .caret{border-width:5px 5px 0;border-bottom-width:0}.dropup .btn-lg .caret{border-width:0 5px 5px}.btn-group-vertical>.btn,.btn-group-vertical>.btn-group,.btn-group-vertical>.btn-group>.btn{display:block;float:none;width:100%;max-width:100%}.btn-group-vertical>.btn-group>.btn{float:none}.btn-group-vertical>.btn+.btn,.btn-group-vertical>.btn+.btn-group,.btn-group-vertical>.btn-group+.btn,.btn-group-vertical>.btn-group+.btn-group{margin-top:-1px;margin-left:0}.btn-group-vertical>.btn:not(:first-child):not(:last-child){border-radius:0}.btn-group-vertical>.btn:first-child:not(:last-child){border-top-right-radius:4px;border-bottom-right-radius:0;border-bottom-left-radius:0}.btn-group-vertical>.btn:last-child:not(:first-child){border-bottom-left-radius:4px;border-top-right-radius:0;border-top-left-radius:0}.btn-group-vertical>.btn-group:not(:first-child):not(:last-child)>.btn{border-radius:0}.btn-group-vertical>.btn-group:first-child:not(:last-child)>.btn:last-child,.btn-group-vertical>.btn-group:first-child:not(:last-child)>.dropdown-toggle{border-bottom-right-radius:0;border-bottom-left-radius:0}.btn-group-vertical>.btn-group:last-child:not(:first-child)>.btn:first-child{border-top-right-radius:0;border-top-left-radius:0}.btn-group-justified{display:table;width:100%;table-layout:fixed;border-collapse:separate}.btn-group-justified>.btn,.btn-group-justified>.btn-group{float:none;display:table-cell;width:1%}.btn-group-justified>.btn-group .btn{width:100%}[data-toggle=buttons]>.btn>input[type=radio],[data-toggle=buttons]>.btn>input[type=checkbox]{display:none}.input-group{position:relative;display:table;border-collapse:separate}.input-group[class*=col-]{float:none;padding-left:0;padding-right:0}.input-group .form-control{position:relative;z-index:2;float:left;width:100%;margin-bottom:0}.input-group-lg>.form-control,.input-group-lg>.input-group-addon,.input-group-lg>.input-group-btn>.btn{height:46px;padding:10px 16px;font-size:18px;line-height:1.33;border-radius:6px}select.input-group-lg>.form-control,select.input-group-lg>.input-group-addon,select.input-group-lg>.input-group-btn>.btn{height:46px;line-height:46px}textarea.input-group-lg>.form-control,textarea.input-group-lg>.input-group-addon,textarea.input-group-lg>.input-group-btn>.btn,select[multiple].input-group-lg>.form-control,select[multiple].input-group-lg>.input-group-addon,select[multiple].input-group-lg>.input-group-btn>.btn{height:auto}.input-group-sm>.form-control,.input-group-sm>.input-group-addon,.input-group-sm>.input-group-btn>.btn{height:30px;padding:5px 10px;font-size:12px;line-height:1.5;border-radius:3px}select.input-group-sm>.form-control,select.input-group-sm>.input-group-addon,select.input-group-sm>.input-group-btn>.btn{height:30px;line-height:30px}textarea.input-group-sm>.form-control,textarea.input-group-sm>.input-group-addon,textarea.input-group-sm>.input-group-btn>.btn,select[multiple].input-group-sm>.form-control,select[multiple].input-group-sm>.input-group-addon,select[multiple].input-group-sm>.input-group-btn>.btn{height:auto}.input-group-addon,.input-group-btn,.input-group .form-control{display:table-cell}.input-group-addon:not(:first-child):not(:last-child),.input-group-btn:not(:first-child):not(:last-child),.input-group .form-control:not(:first-child):not(:last-child){border-radius:0}.input-group-addon,.input-group-btn{width:1%;white-space:nowrap;vertical-align:middle}.input-group-addon{padding:6px 12px;font-size:14px;font-weight:400;line-height:1;color:#555;text-align:center;background-color:#eee;border:1px solid #ccc;border-radius:4px}.input-group-addon.input-sm{padding:5px 10px;font-size:12px;border-radius:3px}.input-group-addon.input-lg{padding:10px 16px;font-size:18px;border-radius:6px}.input-group-addon input[type=radio],.input-group-addon input[type=checkbox]{margin-top:0}.input-group .form-control:first-child,.input-group-addon:first-child,.input-group-btn:first-child>.btn,.input-group-btn:first-child>.btn-group>.btn,.input-group-btn:first-child>.dropdown-toggle,.input-group-btn:last-child>.btn:not(:last-child):not(.dropdown-toggle),.input-group-btn:last-child>.btn-group:not(:last-child)>.btn{border-bottom-right-radius:0;border-top-right-radius:0}.input-group-addon:first-child{border-right:0}.input-group .form-control:last-child,.input-group-addon:last-child,.input-group-btn:last-child>.btn,.input-group-btn:last-child>.btn-group>.btn,.input-group-btn:last-child>.dropdown-toggle,.input-group-btn:first-child>.btn:not(:first-child),.input-group-btn:first-child>.btn-group:not(:first-child)>.btn{border-bottom-left-radius:0;border-top-left-radius:0}.input-group-addon:last-child{border-left:0}.input-group-btn{position:relative;font-size:0;white-space:nowrap}.input-group-btn>.btn{position:relative}.input-group-btn>.btn+.btn{margin-left:-1px}.input-group-btn>.btn:hover,.input-group-btn>.btn:focus,.input-group-btn>.btn:active{z-index:2}.input-group-btn:first-child>.btn,.input-group-btn:first-child>.btn-group{margin-right:-1px}.input-group-btn:last-child>.btn,.input-group-btn:last-child>.btn-group{margin-left:-1px}.nav{margin-bottom:0;padding-left:0;list-style:none}.nav>li{position:relative;display:block}.nav>li>a{position:relative;display:block;padding:10px 15px}.nav>li>a:hover,.nav>li>a:focus{text-decoration:none;background-color:#eee}.nav>li.disabled>a{color:#999}.nav>li.disabled>a:hover,.nav>li.disabled>a:focus{color:#999;text-decoration:none;background-color:transparent;cursor:not-allowed}.nav .open>a,.nav .open>a:hover,.nav .open>a:focus{background-color:#eee;border-color:#428bca}.nav .nav-divider{height:1px;margin:9px 0;overflow:hidden;background-color:#e5e5e5}.nav>li>a>img{max-width:none}.nav-tabs{border-bottom:1px solid #ddd}.nav-tabs>li{float:left;margin-bottom:-1px}.nav-tabs>li>a{margin-right:2px;line-height:1.42857143;border:1px solid transparent;border-radius:4px 4px 0 0}.nav-tabs>li>a:hover{border-color:#eee #eee #ddd}.nav-tabs>li.active>a,.nav-tabs>li.active>a:hover,.nav-tabs>li.active>a:focus{color:#555;background-color:#fff;border:1px solid #ddd;border-bottom-color:transparent;cursor:default}.nav-tabs.nav-justified{width:100%;border-bottom:0}.nav-tabs.nav-justified>li{float:none}.nav-tabs.nav-justified>li>a{text-align:center;margin-bottom:5px}.nav-tabs.nav-justified>.dropdown .dropdown-menu{top:auto;left:auto}@media (min-width:768px){.nav-tabs.nav-justified>li{display:table-cell;width:1%}.nav-tabs.nav-justified>li>a{margin-bottom:0}}.nav-tabs.nav-justified>li>a{margin-right:0;border-radius:4px}.nav-tabs.nav-justified>.active>a,.nav-tabs.nav-justified>.active>a:hover,.nav-tabs.nav-justified>.active>a:focus{border:1px solid #ddd}@media (min-width:768px){.nav-tabs.nav-justified>li>a{border-bottom:1px solid #ddd;border-radius:4px 4px 0 0}.nav-tabs.nav-justified>.active>a,.nav-tabs.nav-justified>.active>a:hover,.nav-tabs.nav-justified>.active>a:focus{border-bottom-color:#fff}}.nav-pills>li{float:left}.nav-pills>li>a{border-radius:4px}.nav-pills>li+li{margin-left:2px}.nav-pills>li.active>a,.nav-pills>li.active>a:hover,.nav-pills>li.active>a:focus{color:#fff;background-color:#428bca}.nav-stacked>li{float:none}.nav-stacked>li+li{margin-top:2px;margin-left:0}.nav-justified{width:100%}.nav-justified>li{float:none}.nav-justified>li>a{text-align:center;margin-bottom:5px}.nav-justified>.dropdown .dropdown-menu{top:auto;left:auto}@media (min-width:768px){.nav-justified>li{display:table-cell;width:1%}.nav-justified>li>a{margin-bottom:0}}.nav-tabs-justified{border-bottom:0}.nav-tabs-justified>li>a{margin-right:0;border-radius:4px}.nav-tabs-justified>.active>a,.nav-tabs-justified>.active>a:hover,.nav-tabs-justified>.active>a:focus{border:1px solid #ddd}@media (min-width:768px){.nav-tabs-justified>li>a{border-bottom:1px solid #ddd;border-radius:4px 4px 0 0}.nav-tabs-justified>.active>a,.nav-tabs-justified>.active>a:hover,.nav-tabs-justified>.active>a:focus{border-bottom-color:#fff}}.tab-content>.tab-pane{display:none}.tab-content>.active{display:block}.nav-tabs .dropdown-menu{margin-top:-1px;border-top-right-radius:0;border-top-left-radius:0}.navbar{position:relative;min-height:50px;margin-bottom:20px;border:1px solid transparent}@media (min-width:768px){.navbar{border-radius:4px}}@media (min-width:768px){.navbar-header{float:left}}.navbar-collapse{max-height:340px;overflow-x:visible;padding-right:15px;padding-left:15px;border-top:1px solid transparent;box-shadow:inset 0 1px 0 rgba(255,255,255,.1);-webkit-overflow-scrolling:touch}.navbar-collapse.in{overflow-y:auto}@media (min-width:768px){.navbar-collapse{width:auto;border-top:0;box-shadow:none}.navbar-collapse.collapse{display:block!important;height:auto!important;padding-bottom:0;overflow:visible!important}.navbar-collapse.in{overflow-y:visible}.navbar-fixed-top .navbar-collapse,.navbar-static-top .navbar-collapse,.navbar-fixed-bottom .navbar-collapse{padding-left:0;padding-right:0}}.container>.navbar-header,.container-fluid>.navbar-header,.container>.navbar-collapse,.container-fluid>.navbar-collapse{margin-right:-15px;margin-left:-15px}@media (min-width:768px){.container>.navbar-header,.container-fluid>.navbar-header,.container>.navbar-collapse,.container-fluid>.navbar-collapse{margin-right:0;margin-left:0}}.navbar-static-top{z-index:1000;border-width:0 0 1px}@media (min-width:768px){.navbar-static-top{border-radius:0}}.navbar-fixed-top,.navbar-fixed-bottom{position:fixed;right:0;left:0;z-index:1030}@media (min-width:768px){.navbar-fixed-top,.navbar-fixed-bottom{border-radius:0}}.navbar-fixed-top{top:0;border-width:0 0 1px}.navbar-fixed-bottom{bottom:0;margin-bottom:0;border-width:1px 0 0}.navbar-brand{float:left;padding:15px;font-size:18px;line-height:20px;height:50px}.navbar-brand:hover,.navbar-brand:focus{text-decoration:none}@media (min-width:768px){.navbar>.container .navbar-brand,.navbar>.container-fluid .navbar-brand{margin-left:-15px}}.navbar-toggle{position:relative;float:right;margin-right:15px;padding:9px 10px;margin-top:8px;margin-bottom:8px;background-color:transparent;background-image:none;border:1px solid transparent;border-radius:4px}.navbar-toggle:focus{outline:0}.navbar-toggle .icon-bar{display:block;width:22px;height:2px;border-radius:1px}.navbar-toggle .icon-bar+.icon-bar{margin-top:4px}@media (min-width:768px){.navbar-toggle{display:none}}.navbar-nav{margin:7.5px -15px}.navbar-nav>li>a{padding-top:10px;padding-bottom:10px;line-height:20px}@media (max-width:767px){.navbar-nav .open .dropdown-menu{position:static;float:none;width:auto;margin-top:0;background-color:transparent;border:0;box-shadow:none}.navbar-nav .open .dropdown-menu>li>a,.navbar-nav .open .dropdown-menu .dropdown-header{padding:5px 15px 5px 25px}.navbar-nav .open .dropdown-menu>li>a{line-height:20px}.navbar-nav .open .dropdown-menu>li>a:hover,.navbar-nav .open .dropdown-menu>li>a:focus{background-image:none}}@media (min-width:768px){.navbar-nav{float:left;margin:0}.navbar-nav>li{float:left}.navbar-nav>li>a{padding-top:15px;padding-bottom:15px}.navbar-nav.navbar-right:last-child{margin-right:-15px}}@media (min-width:768px){.navbar-left{float:left!important}.navbar-right{float:right!important}}.navbar-form{margin-left:-15px;margin-right:-15px;padding:10px 15px;border-top:1px solid transparent;border-bottom:1px solid transparent;-webkit-box-shadow:inset 0 1px 0 rgba(255,255,255,.1),0 1px 0 rgba(255,255,255,.1);box-shadow:inset 0 1px 0 rgba(255,255,255,.1),0 1px 0 rgba(255,255,255,.1);margin-top:8px;margin-bottom:8px}@media (min-width:768px){.navbar-form .form-group{display:inline-block;margin-bottom:0;vertical-align:middle}.navbar-form .form-control{display:inline-block;width:auto;vertical-align:middle}.navbar-form .input-group>.form-control{width:100%}.navbar-form .control-label{margin-bottom:0;vertical-align:middle}.navbar-form .radio,.navbar-form .checkbox{display:inline-block;margin-top:0;margin-bottom:0;padding-left:0;vertical-align:middle}.navbar-form .radio input[type=radio],.navbar-form .checkbox input[type=checkbox]{float:none;margin-left:0}.navbar-form .has-feedback .form-control-feedback{top:0}}@media (max-width:767px){.navbar-form .form-group{margin-bottom:5px}}@media (min-width:768px){.navbar-form{width:auto;border:0;margin-left:0;margin-right:0;padding-top:0;padding-bottom:0;-webkit-box-shadow:none;box-shadow:none}.navbar-form.navbar-right:last-child{margin-right:-15px}}.navbar-nav>li>.dropdown-menu{margin-top:0;border-top-right-radius:0;border-top-left-radius:0}.navbar-fixed-bottom .navbar-nav>li>.dropdown-menu{border-bottom-right-radius:0;border-bottom-left-radius:0}.navbar-btn{margin-top:8px;margin-bottom:8px}.navbar-btn.btn-sm{margin-top:10px;margin-bottom:10px}.navbar-btn.btn-xs{margin-top:14px;margin-bottom:14px}.navbar-text{margin-top:15px;margin-bottom:15px}@media (min-width:768px){.navbar-text{float:left;margin-left:15px;margin-right:15px}.navbar-text.navbar-right:last-child{margin-right:0}}.navbar-default{background-color:#f8f8f8;border-color:#e7e7e7}.navbar-default .navbar-brand{color:#777}.navbar-default .navbar-brand:hover,.navbar-default .navbar-brand:focus{color:#5e5e5e;background-color:transparent}.navbar-default .navbar-text{color:#777}.navbar-default .navbar-nav>li>a{color:#777}.navbar-default .navbar-nav>li>a:hover,.navbar-default .navbar-nav>li>a:focus{color:#333;background-color:transparent}.navbar-default .navbar-nav>.active>a,.navbar-default .navbar-nav>.active>a:hover,.navbar-default .navbar-nav>.active>a:focus{color:#555;background-color:#e7e7e7}.navbar-default .navbar-nav>.disabled>a,.navbar-default .navbar-nav>.disabled>a:hover,.navbar-default .navbar-nav>.disabled>a:focus{color:#ccc;background-color:transparent}.navbar-default .navbar-toggle{border-color:#ddd}.navbar-default .navbar-toggle:hover,.navbar-default .navbar-toggle:focus{background-color:#ddd}.navbar-default .navbar-toggle .icon-bar{background-color:#888}.navbar-default .navbar-collapse,.navbar-default .navbar-form{border-color:#e7e7e7}.navbar-default .navbar-nav>.open>a,.navbar-default .navbar-nav>.open>a:hover,.navbar-default .navbar-nav>.open>a:focus{background-color:#e7e7e7;color:#555}@media (max-width:767px){.navbar-default .navbar-nav .open .dropdown-menu>li>a{color:#777}.navbar-default .navbar-nav .open .dropdown-menu>li>a:hover,.navbar-default .navbar-nav .open .dropdown-menu>li>a:focus{color:#333;background-color:transparent}.navbar-default .navbar-nav .open .dropdown-menu>.active>a,.navbar-default .navbar-nav .open .dropdown-menu>.active>a:hover,.navbar-default .navbar-nav .open .dropdown-menu>.active>a:focus{color:#555;background-color:#e7e7e7}.navbar-default .navbar-nav .open .dropdown-menu>.disabled>a,.navbar-default .navbar-nav .open .dropdown-menu>.disabled>a:hover,.navbar-default .navbar-nav .open .dropdown-menu>.disabled>a:focus{color:#ccc;background-color:transparent}}.navbar-default .navbar-link{color:#777}.navbar-default .navbar-link:hover{color:#333}.navbar-inverse{background-color:#222;border-color:#080808}.navbar-inverse .navbar-brand{color:#999}.navbar-inverse .navbar-brand:hover,.navbar-inverse .navbar-brand:focus{color:#fff;background-color:transparent}.navbar-inverse .navbar-text{color:#999}.navbar-inverse .navbar-nav>li>a{color:#999}.navbar-inverse .navbar-nav>li>a:hover,.navbar-inverse .navbar-nav>li>a:focus{color:#fff;background-color:transparent}.navbar-inverse .navbar-nav>.active>a,.navbar-inverse .navbar-nav>.active>a:hover,.navbar-inverse .navbar-nav>.active>a:focus{color:#fff;background-color:#080808}.navbar-inverse .navbar-nav>.disabled>a,.navbar-inverse .navbar-nav>.disabled>a:hover,.navbar-inverse .navbar-nav>.disabled>a:focus{color:#444;background-color:transparent}.navbar-inverse .navbar-toggle{border-color:#333}.navbar-inverse .navbar-toggle:hover,.navbar-inverse .navbar-toggle:focus{background-color:#333}.navbar-inverse .navbar-toggle .icon-bar{background-color:#fff}.navbar-inverse .navbar-collapse,.navbar-inverse .navbar-form{border-color:#101010}.navbar-inverse .navbar-nav>.open>a,.navbar-inverse .navbar-nav>.open>a:hover,.navbar-inverse .navbar-nav>.open>a:focus{background-color:#080808;color:#fff}@media (max-width:767px){.navbar-inverse .navbar-nav .open .dropdown-menu>.dropdown-header{border-color:#080808}.navbar-inverse .navbar-nav .open .dropdown-menu .divider{background-color:#080808}.navbar-inverse .navbar-nav .open .dropdown-menu>li>a{color:#999}.navbar-inverse .navbar-nav .open .dropdown-menu>li>a:hover,.navbar-inverse .navbar-nav .open .dropdown-menu>li>a:focus{color:#fff;background-color:transparent}.navbar-inverse .navbar-nav .open .dropdown-menu>.active>a,.navbar-inverse .navbar-nav .open .dropdown-menu>.active>a:hover,.navbar-inverse .navbar-nav .open .dropdown-menu>.active>a:focus{color:#fff;background-color:#080808}.navbar-inverse .navbar-nav .open .dropdown-menu>.disabled>a,.navbar-inverse .navbar-nav .open .dropdown-menu>.disabled>a:hover,.navbar-inverse .navbar-nav .open .dropdown-menu>.disabled>a:focus{color:#444;background-color:transparent}}.navbar-inverse .navbar-link{color:#999}.navbar-inverse .navbar-link:hover{color:#fff}.breadcrumb{padding:8px 15px;margin-bottom:20px;list-style:none;background-color:#f5f5f5;border-radius:4px}.breadcrumb>li{display:inline-block}.breadcrumb>li+li:before{content:"/\00a0";padding:0 5px;color:#ccc}.breadcrumb>.active{color:#999}.pagination{display:inline-block;padding-left:0;margin:20px 0;border-radius:4px}.pagination>li{display:inline}.pagination>li>a,.pagination>li>span{position:relative;float:left;padding:6px 12px;line-height:1.42857143;text-decoration:none;color:#428bca;background-color:#fff;border:1px solid #ddd;margin-left:-1px}.pagination>li:first-child>a,.pagination>li:first-child>span{margin-left:0;border-bottom-left-radius:4px;border-top-left-radius:4px}.pagination>li:last-child>a,.pagination>li:last-child>span{border-bottom-right-radius:4px;border-top-right-radius:4px}.pagination>li>a:hover,.pagination>li>span:hover,.pagination>li>a:focus,.pagination>li>span:focus{color:#2a6496;background-color:#eee;border-color:#ddd}.pagination>.active>a,.pagination>.active>span,.pagination>.active>a:hover,.pagination>.active>span:hover,.pagination>.active>a:focus,.pagination>.active>span:focus{z-index:2;color:#fff;background-color:#428bca;border-color:#428bca;cursor:default}.pagination>.disabled>span,.pagination>.disabled>span:hover,.pagination>.disabled>span:focus,.pagination>.disabled>a,.pagination>.disabled>a:hover,.pagination>.disabled>a:focus{color:#999;background-color:#fff;border-color:#ddd;cursor:not-allowed}.pagination-lg>li>a,.pagination-lg>li>span{padding:10px 16px;font-size:18px}.pagination-lg>li:first-child>a,.pagination-lg>li:first-child>span{border-bottom-left-radius:6px;border-top-left-radius:6px}.pagination-lg>li:last-child>a,.pagination-lg>li:last-child>span{border-bottom-right-radius:6px;border-top-right-radius:6px}.pagination-sm>li>a,.pagination-sm>li>span{padding:5px 10px;font-size:12px}.pagination-sm>li:first-child>a,.pagination-sm>li:first-child>span{border-bottom-left-radius:3px;border-top-left-radius:3px}.pagination-sm>li:last-child>a,.pagination-sm>li:last-child>span{border-bottom-right-radius:3px;border-top-right-radius:3px}.pager{padding-left:0;margin:20px 0;list-style:none;text-align:center}.pager li{display:inline}.pager li>a,.pager li>span{display:inline-block;padding:5px 14px;background-color:#fff;border:1px solid #ddd;border-radius:15px}.pager li>a:hover,.pager li>a:focus{text-decoration:none;background-color:#eee}.pager .next>a,.pager .next>span{float:right}.pager .previous>a,.pager .previous>span{float:left}.pager .disabled>a,.pager .disabled>a:hover,.pager .disabled>a:focus,.pager .disabled>span{color:#999;background-color:#fff;cursor:not-allowed}.label{display:inline;padding:.2em .6em .3em;font-size:75%;font-weight:700;line-height:1;color:#fff;text-align:center;white-space:nowrap;vertical-align:baseline;border-radius:.25em}.label[href]:hover,.label[href]:focus{color:#fff;text-decoration:none;cursor:pointer}.label:empty{display:none}.btn .label{position:relative;top:-1px}.label-default{background-color:#999}.label-default[href]:hover,.label-default[href]:focus{background-color:gray}.label-primary{background-color:#428bca}.label-primary[href]:hover,.label-primary[href]:focus{background-color:#3071a9}.label-success{background-color:#5cb85c}.label-success[href]:hover,.label-success[href]:focus{background-color:#449d44}.label-info{background-color:#5bc0de}.label-info[href]:hover,.label-info[href]:focus{background-color:#31b0d5}.label-warning{background-color:#f0ad4e}.label-warning[href]:hover,.label-warning[href]:focus{background-color:#ec971f}.label-danger{background-color:#d9534f}.label-danger[href]:hover,.label-danger[href]:focus{background-color:#c9302c}.badge{display:inline-block;min-width:10px;padding:3px 7px;font-size:12px;font-weight:700;color:#fff;line-height:1;vertical-align:baseline;white-space:nowrap;text-align:center;background-color:#999;border-radius:10px}.badge:empty{display:none}.btn .badge{position:relative;top:-1px}.btn-xs .badge{top:0;padding:1px 5px}a.badge:hover,a.badge:focus{color:#fff;text-decoration:none;cursor:pointer}a.list-group-item.active>.badge,.nav-pills>.active>a>.badge{color:#428bca;background-color:#fff}.nav-pills>li>a>.badge{margin-left:3px}.jumbotron{padding:30px;margin-bottom:30px;color:inherit;background-color:#eee}.jumbotron h1,.jumbotron .h1{color:inherit}.jumbotron p{margin-bottom:15px;font-size:21px;font-weight:200}.container .jumbotron{border-radius:6px}.jumbotron .container{max-width:100%}@media screen and (min-width:768px){.jumbotron{padding-top:48px;padding-bottom:48px}.container .jumbotron{padding-left:60px;padding-right:60px}.jumbotron h1,.jumbotron .h1{font-size:63px}}.thumbnail{display:block;padding:4px;margin-bottom:20px;line-height:1.42857143;background-color:#fff;border:1px solid #ddd;border-radius:4px;-webkit-transition:all .2s ease-in-out;transition:all .2s ease-in-out}.thumbnail>img,.thumbnail a>img{margin-left:auto;margin-right:auto}a.thumbnail:hover,a.thumbnail:focus,a.thumbnail.active{border-color:#428bca}.thumbnail .caption{padding:9px;color:#333}.alert{padding:15px;margin-bottom:20px;border:1px solid transparent;border-radius:4px}.alert h4{margin-top:0;color:inherit}.alert .alert-link{font-weight:700}.alert>p,.alert>ul{margin-bottom:0}.alert>p+p{margin-top:5px}.alert-dismissable{padding-right:35px}.alert-dismissable .close{position:relative;top:-2px;right:-21px;color:inherit}.alert-success{background-color:#dff0d8;border-color:#d6e9c6;color:#3c763d}.alert-success hr{border-top-color:#c9e2b3}.alert-success .alert-link{color:#2b542c}.alert-info{background-color:#d9edf7;border-color:#bce8f1;color:#31708f}.alert-info hr{border-top-color:#a6e1ec}.alert-info .alert-link{color:#245269}.alert-warning{background-color:#fcf8e3;border-color:#faebcc;color:#8a6d3b}.alert-warning hr{border-top-color:#f7e1b5}.alert-warning .alert-link{color:#66512c}.alert-danger{background-color:#f2dede;border-color:#ebccd1;color:#a94442}.alert-danger hr{border-top-color:#e4b9c0}.alert-danger .alert-link{color:#843534}@-webkit-keyframes progress-bar-stripes{from{background-position:40px 0}to{background-position:0 0}}@keyframes progress-bar-stripes{from{background-position:40px 0}to{background-position:0 0}}.progress{overflow:hidden;height:20px;margin-bottom:20px;background-color:#f5f5f5;border-radius:4px;-webkit-box-shadow:inset 0 1px 2px rgba(0,0,0,.1);box-shadow:inset 0 1px 2px rgba(0,0,0,.1)}.progress-bar{float:left;width:0;height:100%;font-size:12px;line-height:20px;color:#fff;text-align:center;background-color:#428bca;-webkit-box-shadow:inset 0 -1px 0 rgba(0,0,0,.15);box-shadow:inset 0 -1px 0 rgba(0,0,0,.15);-webkit-transition:width .6s ease;transition:width .6s ease}.progress-striped .progress-bar{background-image:-webkit-linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent);background-image:linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent);background-size:40px 40px}.progress.active .progress-bar{-webkit-animation:progress-bar-stripes 2s linear infinite;animation:progress-bar-stripes 2s linear infinite}.progress-bar-success{background-color:#5cb85c}.progress-striped .progress-bar-success{background-image:-webkit-linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent);background-image:linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent)}.progress-bar-info{background-color:#5bc0de}.progress-striped .progress-bar-info{background-image:-webkit-linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent);background-image:linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent)}.progress-bar-warning{background-color:#f0ad4e}.progress-striped .progress-bar-warning{background-image:-webkit-linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent);background-image:linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent)}.progress-bar-danger{background-color:#d9534f}.progress-striped .progress-bar-danger{background-image:-webkit-linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent);background-image:linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent)}.media,.media-body{overflow:hidden;zoom:1}.media,.media .media{margin-top:15px}.media:first-child{margin-top:0}.media-object{display:block}.media-heading{margin:0 0 5px}.media>.pull-left{margin-right:10px}.media>.pull-right{margin-left:10px}.media-list{padding-left:0;list-style:none}.list-group{margin-bottom:20px;padding-left:0}.list-group-item{position:relative;display:block;padding:10px 15px;margin-bottom:-1px;background-color:#fff;border:1px solid #ddd}.list-group-item:first-child{border-top-right-radius:4px;border-top-left-radius:4px}.list-group-item:last-child{margin-bottom:0;border-bottom-right-radius:4px;border-bottom-left-radius:4px}.list-group-item>.badge{float:right}.list-group-item>.badge+.badge{margin-right:5px}a.list-group-item{color:#555}a.list-group-item .list-group-item-heading{color:#333}a.list-group-item:hover,a.list-group-item:focus{text-decoration:none;background-color:#f5f5f5}a.list-group-item.active,a.list-group-item.active:hover,a.list-group-item.active:focus{z-index:2;color:#fff;background-color:#428bca;border-color:#428bca}a.list-group-item.active .list-group-item-heading,a.list-group-item.active:hover .list-group-item-heading,a.list-group-item.active:focus .list-group-item-heading{color:inherit}a.list-group-item.active .list-group-item-text,a.list-group-item.active:hover .list-group-item-text,a.list-group-item.active:focus .list-group-item-text{color:#e1edf7}.list-group-item-success{color:#3c763d;background-color:#dff0d8}a.list-group-item-success{color:#3c763d}a.list-group-item-success .list-group-item-heading{color:inherit}a.list-group-item-success:hover,a.list-group-item-success:focus{color:#3c763d;background-color:#d0e9c6}a.list-group-item-success.active,a.list-group-item-success.active:hover,a.list-group-item-success.active:focus{color:#fff;background-color:#3c763d;border-color:#3c763d}.list-group-item-info{color:#31708f;background-color:#d9edf7}a.list-group-item-info{color:#31708f}a.list-group-item-info .list-group-item-heading{color:inherit}a.list-group-item-info:hover,a.list-group-item-info:focus{color:#31708f;background-color:#c4e3f3}a.list-group-item-info.active,a.list-group-item-info.active:hover,a.list-group-item-info.active:focus{color:#fff;background-color:#31708f;border-color:#31708f}.list-group-item-warning{color:#8a6d3b;background-color:#fcf8e3}a.list-group-item-warning{color:#8a6d3b}a.list-group-item-warning .list-group-item-heading{color:inherit}a.list-group-item-warning:hover,a.list-group-item-warning:focus{color:#8a6d3b;background-color:#faf2cc}a.list-group-item-warning.active,a.list-group-item-warning.active:hover,a.list-group-item-warning.active:focus{color:#fff;background-color:#8a6d3b;border-color:#8a6d3b}.list-group-item-danger{color:#a94442;background-color:#f2dede}a.list-group-item-danger{color:#a94442}a.list-group-item-danger .list-group-item-heading{color:inherit}a.list-group-item-danger:hover,a.list-group-item-danger:focus{color:#a94442;background-color:#ebcccc}a.list-group-item-danger.active,a.list-group-item-danger.active:hover,a.list-group-item-danger.active:focus{color:#fff;background-color:#a94442;border-color:#a94442}.list-group-item-heading{margin-top:0;margin-bottom:5px}.list-group-item-text{margin-bottom:0;line-height:1.3}.panel{margin-bottom:20px;background-color:#fff;border:1px solid transparent;border-radius:4px;-webkit-box-shadow:0 1px 1px rgba(0,0,0,.05);box-shadow:0 1px 1px rgba(0,0,0,.05)}.panel-body{padding:15px}.panel-heading{padding:10px 15px;border-bottom:1px solid transparent;border-top-right-radius:3px;border-top-left-radius:3px}.panel-heading>.dropdown .dropdown-toggle{color:inherit}.panel-title{margin-top:0;margin-bottom:0;font-size:16px;color:inherit}.panel-title>a{color:inherit}.panel-footer{padding:10px 15px;background-color:#f5f5f5;border-top:1px solid #ddd;border-bottom-right-radius:3px;border-bottom-left-radius:3px}.panel>.list-group{margin-bottom:0}.panel>.list-group .list-group-item{border-width:1px 0;border-radius:0}.panel>.list-group:first-child .list-group-item:first-child{border-top:0;border-top-right-radius:3px;border-top-left-radius:3px}.panel>.list-group:last-child .list-group-item:last-child{border-bottom:0;border-bottom-right-radius:3px;border-bottom-left-radius:3px}.panel-heading+.list-group .list-group-item:first-child{border-top-width:0}.panel>.table,.panel>.table-responsive>.table{margin-bottom:0}.panel>.table:first-child,.panel>.table-responsive:first-child>.table:first-child{border-top-right-radius:3px;border-top-left-radius:3px}.panel>.table:first-child>thead:first-child>tr:first-child td:first-child,.panel>.table-responsive:first-child>.table:first-child>thead:first-child>tr:first-child td:first-child,.panel>.table:first-child>tbody:first-child>tr:first-child td:first-child,.panel>.table-responsive:first-child>.table:first-child>tbody:first-child>tr:first-child td:first-child,.panel>.table:first-child>thead:first-child>tr:first-child th:first-child,.panel>.table-responsive:first-child>.table:first-child>thead:first-child>tr:first-child th:first-child,.panel>.table:first-child>tbody:first-child>tr:first-child th:first-child,.panel>.table-responsive:first-child>.table:first-child>tbody:first-child>tr:first-child th:first-child{border-top-left-radius:3px}.panel>.table:first-child>thead:first-child>tr:first-child td:last-child,.panel>.table-responsive:first-child>.table:first-child>thead:first-child>tr:first-child td:last-child,.panel>.table:first-child>tbody:first-child>tr:first-child td:last-child,.panel>.table-responsive:first-child>.table:first-child>tbody:first-child>tr:first-child td:last-child,.panel>.table:first-child>thead:first-child>tr:first-child th:last-child,.panel>.table-responsive:first-child>.table:first-child>thead:first-child>tr:first-child th:last-child,.panel>.table:first-child>tbody:first-child>tr:first-child th:last-child,.panel>.table-responsive:first-child>.table:first-child>tbody:first-child>tr:first-child th:last-child{border-top-right-radius:3px}.panel>.table:last-child,.panel>.table-responsive:last-child>.table:last-child{border-bottom-right-radius:3px;border-bottom-left-radius:3px}.panel>.table:last-child>tbody:last-child>tr:last-child td:first-child,.panel>.table-responsive:last-child>.table:last-child>tbody:last-child>tr:last-child td:first-child,.panel>.table:last-child>tfoot:last-child>tr:last-child td:first-child,.panel>.table-responsive:last-child>.table:last-child>tfoot:last-child>tr:last-child td:first-child,.panel>.table:last-child>tbody:last-child>tr:last-child th:first-child,.panel>.table-responsive:last-child>.table:last-child>tbody:last-child>tr:last-child th:first-child,.panel>.table:last-child>tfoot:last-child>tr:last-child th:first-child,.panel>.table-responsive:last-child>.table:last-child>tfoot:last-child>tr:last-child th:first-child{border-bottom-left-radius:3px}.panel>.table:last-child>tbody:last-child>tr:last-child td:last-child,.panel>.table-responsive:last-child>.table:last-child>tbody:last-child>tr:last-child td:last-child,.panel>.table:last-child>tfoot:last-child>tr:last-child td:last-child,.panel>.table-responsive:last-child>.table:last-child>tfoot:last-child>tr:last-child td:last-child,.panel>.table:last-child>tbody:last-child>tr:last-child th:last-child,.panel>.table-responsive:last-child>.table:last-child>tbody:last-child>tr:last-child th:last-child,.panel>.table:last-child>tfoot:last-child>tr:last-child th:last-child,.panel>.table-responsive:last-child>.table:last-child>tfoot:last-child>tr:last-child th:last-child{border-bottom-right-radius:3px}.panel>.panel-body+.table,.panel>.panel-body+.table-responsive{border-top:1px solid #ddd}.panel>.table>tbody:first-child>tr:first-child th,.panel>.table>tbody:first-child>tr:first-child td{border-top:0}.panel>.table-bordered,.panel>.table-responsive>.table-bordered{border:0}.panel>.table-bordered>thead>tr>th:first-child,.panel>.table-responsive>.table-bordered>thead>tr>th:first-child,.panel>.table-bordered>tbody>tr>th:first-child,.panel>.table-responsive>.table-bordered>tbody>tr>th:first-child,.panel>.table-bordered>tfoot>tr>th:first-child,.panel>.table-responsive>.table-bordered>tfoot>tr>th:first-child,.panel>.table-bordered>thead>tr>td:first-child,.panel>.table-responsive>.table-bordered>thead>tr>td:first-child,.panel>.table-bordered>tbody>tr>td:first-child,.panel>.table-responsive>.table-bordered>tbody>tr>td:first-child,.panel>.table-bordered>tfoot>tr>td:first-child,.panel>.table-responsive>.table-bordered>tfoot>tr>td:first-child{border-left:0}.panel>.table-bordered>thead>tr>th:last-child,.panel>.table-responsive>.table-bordered>thead>tr>th:last-child,.panel>.table-bordered>tbody>tr>th:last-child,.panel>.table-responsive>.table-bordered>tbody>tr>th:last-child,.panel>.table-bordered>tfoot>tr>th:last-child,.panel>.table-responsive>.table-bordered>tfoot>tr>th:last-child,.panel>.table-bordered>thead>tr>td:last-child,.panel>.table-responsive>.table-bordered>thead>tr>td:last-child,.panel>.table-bordered>tbody>tr>td:last-child,.panel>.table-responsive>.table-bordered>tbody>tr>td:last-child,.panel>.table-bordered>tfoot>tr>td:last-child,.panel>.table-responsive>.table-bordered>tfoot>tr>td:last-child{border-right:0}.panel>.table-bordered>thead>tr:first-child>td,.panel>.table-responsive>.table-bordered>thead>tr:first-child>td,.panel>.table-bordered>tbody>tr:first-child>td,.panel>.table-responsive>.table-bordered>tbody>tr:first-child>td,.panel>.table-bordered>thead>tr:first-child>th,.panel>.table-responsive>.table-bordered>thead>tr:first-child>th,.panel>.table-bordered>tbody>tr:first-child>th,.panel>.table-responsive>.table-bordered>tbody>tr:first-child>th{border-bottom:0}.panel>.table-bordered>tbody>tr:last-child>td,.panel>.table-responsive>.table-bordered>tbody>tr:last-child>td,.panel>.table-bordered>tfoot>tr:last-child>td,.panel>.table-responsive>.table-bordered>tfoot>tr:last-child>td,.panel>.table-bordered>tbody>tr:last-child>th,.panel>.table-responsive>.table-bordered>tbody>tr:last-child>th,.panel>.table-bordered>tfoot>tr:last-child>th,.panel>.table-responsive>.table-bordered>tfoot>tr:last-child>th{border-bottom:0}.panel>.table-responsive{border:0;margin-bottom:0}.panel-group{margin-bottom:20px}.panel-group .panel{margin-bottom:0;border-radius:4px;overflow:hidden}.panel-group .panel+.panel{margin-top:5px}.panel-group .panel-heading{border-bottom:0}.panel-group .panel-heading+.panel-collapse .panel-body{border-top:1px solid #ddd}.panel-group .panel-footer{border-top:0}.panel-group .panel-footer+.panel-collapse .panel-body{border-bottom:1px solid #ddd}.panel-default{border-color:#ddd}.panel-default>.panel-heading{color:#333;background-color:#f5f5f5;border-color:#ddd}.panel-default>.panel-heading+.panel-collapse .panel-body{border-top-color:#ddd}.panel-default>.panel-footer+.panel-collapse .panel-body{border-bottom-color:#ddd}.panel-primary{border-color:#428bca}.panel-primary>.panel-heading{color:#fff;background-color:#428bca;border-color:#428bca}.panel-primary>.panel-heading+.panel-collapse .panel-body{border-top-color:#428bca}.panel-primary>.panel-footer+.panel-collapse .panel-body{border-bottom-color:#428bca}.panel-success{border-color:#d6e9c6}.panel-success>.panel-heading{color:#3c763d;background-color:#dff0d8;border-color:#d6e9c6}.panel-success>.panel-heading+.panel-collapse .panel-body{border-top-color:#d6e9c6}.panel-success>.panel-footer+.panel-collapse .panel-body{border-bottom-color:#d6e9c6}.panel-info{border-color:#bce8f1}.panel-info>.panel-heading{color:#31708f;background-color:#d9edf7;border-color:#bce8f1}.panel-info>.panel-heading+.panel-collapse .panel-body{border-top-color:#bce8f1}.panel-info>.panel-footer+.panel-collapse .panel-body{border-bottom-color:#bce8f1}.panel-warning{border-color:#faebcc}.panel-warning>.panel-heading{color:#8a6d3b;background-color:#fcf8e3;border-color:#faebcc}.panel-warning>.panel-heading+.panel-collapse .panel-body{border-top-color:#faebcc}.panel-warning>.panel-footer+.panel-collapse .panel-body{border-bottom-color:#faebcc}.panel-danger{border-color:#ebccd1}.panel-danger>.panel-heading{color:#a94442;background-color:#f2dede;border-color:#ebccd1}.panel-danger>.panel-heading+.panel-collapse .panel-body{border-top-color:#ebccd1}.panel-danger>.panel-footer+.panel-collapse .panel-body{border-bottom-color:#ebccd1}.well{min-height:20px;padding:19px;margin-bottom:20px;background-color:#f5f5f5;border:1px solid #e3e3e3;border-radius:4px;-webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.05);box-shadow:inset 0 1px 1px rgba(0,0,0,.05)}.well blockquote{border-color:#ddd;border-color:rgba(0,0,0,.15)}.well-lg{padding:24px;border-radius:6px}.well-sm{padding:9px;border-radius:3px}.close{float:right;font-size:21px;font-weight:700;line-height:1;color:#000;text-shadow:0 1px 0 #fff;opacity:.2;filter:alpha(opacity=20)}.close:hover,.close:focus{color:#000;text-decoration:none;cursor:pointer;opacity:.5;filter:alpha(opacity=50)}button.close{padding:0;cursor:pointer;background:0 0;border:0;-webkit-appearance:none}.modal-open{overflow:hidden}.modal{display:none;overflow:auto;overflow-y:scroll;position:fixed;top:0;right:0;bottom:0;left:0;z-index:1050;-webkit-overflow-scrolling:touch;outline:0}.modal.fade .modal-dialog{-webkit-transform:translate(0,-25%);-ms-transform:translate(0,-25%);transform:translate(0,-25%);-webkit-transition:-webkit-transform .3s ease-out;-moz-transition:-moz-transform .3s ease-out;-o-transition:-o-transform .3s ease-out;transition:transform .3s ease-out}.modal.in .modal-dialog{-webkit-transform:translate(0,0);-ms-transform:translate(0,0);transform:translate(0,0)}.modal-dialog{position:relative;width:auto;margin:10px}.modal-content{position:relative;background-color:#fff;border:1px solid #999;border:1px solid rgba(0,0,0,.2);border-radius:6px;-webkit-box-shadow:0 3px 9px rgba(0,0,0,.5);box-shadow:0 3px 9px rgba(0,0,0,.5);background-clip:padding-box;outline:0}.modal-backdrop{position:fixed;top:0;right:0;bottom:0;left:0;z-index:1040;background-color:#000}.modal-backdrop.fade{opacity:0;filter:alpha(opacity=0)}.modal-backdrop.in{opacity:.5;filter:alpha(opacity=50)}.modal-header{padding:15px;border-bottom:1px solid #e5e5e5;min-height:16.42857143px}.modal-header .close{margin-top:-2px}.modal-title{margin:0;line-height:1.42857143}.modal-body{position:relative;padding:20px}.modal-footer{margin-top:15px;padding:19px 20px 20px;text-align:right;border-top:1px solid #e5e5e5}.modal-footer .btn+.btn{margin-left:5px;margin-bottom:0}.modal-footer .btn-group .btn+.btn{margin-left:-1px}.modal-footer .btn-block+.btn-block{margin-left:0}@media (min-width:768px){.modal-dialog{width:600px;margin:30px auto}.modal-content{-webkit-box-shadow:0 5px 15px rgba(0,0,0,.5);box-shadow:0 5px 15px rgba(0,0,0,.5)}.modal-sm{width:300px}}@media (min-width:992px){.modal-lg{width:900px}}.tooltip{position:absolute;z-index:1030;display:block;visibility:visible;font-size:12px;line-height:1.4;opacity:0;filter:alpha(opacity=0)}.tooltip.in{opacity:.9;filter:alpha(opacity=90)}.tooltip.top{margin-top:-3px;padding:5px 0}.tooltip.right{margin-left:3px;padding:0 5px}.tooltip.bottom{margin-top:3px;padding:5px 0}.tooltip.left{margin-left:-3px;padding:0 5px}.tooltip-inner{max-width:200px;padding:3px 8px;color:#fff;text-align:center;text-decoration:none;background-color:#000;border-radius:4px}.tooltip-arrow{position:absolute;width:0;height:0;border-color:transparent;border-style:solid}.tooltip.top .tooltip-arrow{bottom:0;left:50%;margin-left:-5px;border-width:5px 5px 0;border-top-color:#000}.tooltip.top-left .tooltip-arrow{bottom:0;left:5px;border-width:5px 5px 0;border-top-color:#000}.tooltip.top-right .tooltip-arrow{bottom:0;right:5px;border-width:5px 5px 0;border-top-color:#000}.tooltip.right .tooltip-arrow{top:50%;left:0;margin-top:-5px;border-width:5px 5px 5px 0;border-right-color:#000}.tooltip.left .tooltip-arrow{top:50%;right:0;margin-top:-5px;border-width:5px 0 5px 5px;border-left-color:#000}.tooltip.bottom .tooltip-arrow{top:0;left:50%;margin-left:-5px;border-width:0 5px 5px;border-bottom-color:#000}.tooltip.bottom-left .tooltip-arrow{top:0;left:5px;border-width:0 5px 5px;border-bottom-color:#000}.tooltip.bottom-right .tooltip-arrow{top:0;right:5px;border-width:0 5px 5px;border-bottom-color:#000}.popover{position:absolute;top:0;left:0;z-index:1010;display:none;max-width:276px;padding:1px;text-align:left;background-color:#fff;background-clip:padding-box;border:1px solid #ccc;border:1px solid rgba(0,0,0,.2);border-radius:6px;-webkit-box-shadow:0 5px 10px rgba(0,0,0,.2);box-shadow:0 5px 10px rgba(0,0,0,.2);white-space:normal}.popover.top{margin-top:-10px}.popover.right{margin-left:10px}.popover.bottom{margin-top:10px}.popover.left{margin-left:-10px}.popover-title{margin:0;padding:8px 14px;font-size:14px;font-weight:400;line-height:18px;background-color:#f7f7f7;border-bottom:1px solid #ebebeb;border-radius:5px 5px 0 0}.popover-content{padding:9px 14px}.popover>.arrow,.popover>.arrow:after{position:absolute;display:block;width:0;height:0;border-color:transparent;border-style:solid}.popover>.arrow{border-width:11px}.popover>.arrow:after{border-width:10px;content:""}.popover.top>.arrow{left:50%;margin-left:-11px;border-bottom-width:0;border-top-color:#999;border-top-color:rgba(0,0,0,.25);bottom:-11px}.popover.top>.arrow:after{content:" ";bottom:1px;margin-left:-10px;border-bottom-width:0;border-top-color:#fff}.popover.right>.arrow{top:50%;left:-11px;margin-top:-11px;border-left-width:0;border-right-color:#999;border-right-color:rgba(0,0,0,.25)}.popover.right>.arrow:after{content:" ";left:1px;bottom:-10px;border-left-width:0;border-right-color:#fff}.popover.bottom>.arrow{left:50%;margin-left:-11px;border-top-width:0;border-bottom-color:#999;border-bottom-color:rgba(0,0,0,.25);top:-11px}.popover.bottom>.arrow:after{content:" ";top:1px;margin-left:-10px;border-top-width:0;border-bottom-color:#fff}.popover.left>.arrow{top:50%;right:-11px;margin-top:-11px;border-right-width:0;border-left-color:#999;border-left-color:rgba(0,0,0,.25)}.popover.left>.arrow:after{content:" ";right:1px;border-right-width:0;border-left-color:#fff;bottom:-10px}.carousel{position:relative}.carousel-inner{position:relative;overflow:hidden;width:100%}.carousel-inner>.item{display:none;position:relative;-webkit-transition:.6s ease-in-out left;transition:.6s ease-in-out left}.carousel-inner>.item>img,.carousel-inner>.item>a>img{line-height:1}.carousel-inner>.active,.carousel-inner>.next,.carousel-inner>.prev{display:block}.carousel-inner>.active{left:0}.carousel-inner>.next,.carousel-inner>.prev{position:absolute;top:0;width:100%}.carousel-inner>.next{left:100%}.carousel-inner>.prev{left:-100%}.carousel-inner>.next.left,.carousel-inner>.prev.right{left:0}.carousel-inner>.active.left{left:-100%}.carousel-inner>.active.right{left:100%}.carousel-control{position:absolute;top:0;left:0;bottom:0;width:15%;opacity:.5;filter:alpha(opacity=50);font-size:20px;color:#fff;text-align:center;text-shadow:0 1px 2px rgba(0,0,0,.6)}.carousel-control.left{background-image:-webkit-linear-gradient(left,color-stop(rgba(0,0,0,.5) 0),color-stop(rgba(0,0,0,.0001) 100%));background-image:linear-gradient(to right,rgba(0,0,0,.5) 0,rgba(0,0,0,.0001) 100%);background-repeat:repeat-x;filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#80000000', endColorstr='#00000000', GradientType=1)}.carousel-control.right{left:auto;right:0;background-image:-webkit-linear-gradient(left,color-stop(rgba(0,0,0,.0001) 0),color-stop(rgba(0,0,0,.5) 100%));background-image:linear-gradient(to right,rgba(0,0,0,.0001) 0,rgba(0,0,0,.5) 100%);background-repeat:repeat-x;filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#00000000', endColorstr='#80000000', GradientType=1)}.carousel-control:hover,.carousel-control:focus{outline:0;color:#fff;text-decoration:none;opacity:.9;filter:alpha(opacity=90)}.carousel-control .icon-prev,.carousel-control .icon-next,.carousel-control .glyphicon-chevron-left,.carousel-control .glyphicon-chevron-right{position:absolute;top:50%;z-index:5;display:inline-block}.carousel-control .icon-prev,.carousel-control .glyphicon-chevron-left{left:50%}.carousel-control .icon-next,.carousel-control .glyphicon-chevron-right{right:50%}.carousel-control .icon-prev,.carousel-control .icon-next{width:20px;height:20px;margin-top:-10px;margin-left:-10px;font-family:serif}.carousel-control .icon-prev:before{content:'\2039'}.carousel-control .icon-next:before{content:'\203a'}.carousel-indicators{position:absolute;bottom:10px;left:50%;z-index:15;width:60%;margin-left:-30%;padding-left:0;list-style:none;text-align:center}.carousel-indicators li{display:inline-block;width:10px;height:10px;margin:1px;text-indent:-999px;border:1px solid #fff;border-radius:10px;cursor:pointer;background-color:#000 \9;background-color:rgba(0,0,0,0)}.carousel-indicators .active{margin:0;width:12px;height:12px;background-color:#fff}.carousel-caption{position:absolute;left:15%;right:15%;bottom:20px;z-index:10;padding-top:20px;padding-bottom:20px;color:#fff;text-align:center;text-shadow:0 1px 2px rgba(0,0,0,.6)}.carousel-caption .btn{text-shadow:none}@media screen and (min-width:768px){.carousel-control .glyphicon-chevron-left,.carousel-control .glyphicon-chevron-right,.carousel-control .icon-prev,.carousel-control .icon-next{width:30px;height:30px;margin-top:-15px;margin-left:-15px;font-size:30px}.carousel-caption{left:20%;right:20%;padding-bottom:30px}.carousel-indicators{bottom:20px}}.clearfix:before,.clearfix:after,.container:before,.container:after,.container-fluid:before,.container-fluid:after,.row:before,.row:after,.form-horizontal .form-group:before,.form-horizontal .form-group:after,.btn-toolbar:before,.btn-toolbar:after,.btn-group-vertical>.btn-group:before,.btn-group-vertical>.btn-group:after,.nav:before,.nav:after,.navbar:before,.navbar:after,.navbar-header:before,.navbar-header:after,.navbar-collapse:before,.navbar-collapse:after,.pager:before,.pager:after,.panel-body:before,.panel-body:after,.modal-footer:before,.modal-footer:after{content:" ";display:table}.clearfix:after,.container:after,.container-fluid:after,.row:after,.form-horizontal .form-group:after,.btn-toolbar:after,.btn-group-vertical>.btn-group:after,.nav:after,.navbar:after,.navbar-header:after,.navbar-collapse:after,.pager:after,.panel-body:after,.modal-footer:after{clear:both}.center-block{display:block;margin-left:auto;margin-right:auto}.pull-right{float:right!important}.pull-left{float:left!important}.hide{display:none!important}.show{display:block!important}.invisible{visibility:hidden}.text-hide{font:0/0 a;color:transparent;text-shadow:none;background-color:transparent;border:0}.hidden{display:none!important;visibility:hidden!important}.affix{position:fixed}@-ms-viewport{width:device-width}.visible-xs,.visible-sm,.visible-md,.visible-lg{display:none!important}@media (max-width:767px){.visible-xs{display:block!important}table.visible-xs{display:table}tr.visible-xs{display:table-row!important}th.visible-xs,td.visible-xs{display:table-cell!important}}@media (min-width:768px) and (max-width:991px){.visible-sm{display:block!important}table.visible-sm{display:table}tr.visible-sm{display:table-row!important}th.visible-sm,td.visible-sm{display:table-cell!important}}@media (min-width:992px) and (max-width:1199px){.visible-md{display:block!important}table.visible-md{display:table}tr.visible-md{display:table-row!important}th.visible-md,td.visible-md{display:table-cell!important}}@media (min-width:1200px){.visible-lg{display:block!important}table.visible-lg{display:table}tr.visible-lg{display:table-row!important}th.visible-lg,td.visible-lg{display:table-cell!important}}@media (max-width:767px){.hidden-xs{display:none!important}}@media (min-width:768px) and (max-width:991px){.hidden-sm{display:none!important}}@media (min-width:992px) and (max-width:1199px){.hidden-md{display:none!important}}@media (min-width:1200px){.hidden-lg{display:none!important}}.visible-print{display:none!important}@media print{.visible-print{display:block!important}table.visible-print{display:table}tr.visible-print{display:table-row!important}th.visible-print,td.visible-print{display:table-cell!important}}@media print{.hidden-print{display:none!important}}
/*!
 * Hover.css (http://ianlunn.github.io/Hover/)
 * Version: 2.0.2
 * Author: Ian Lunn @IanLunn
 * Author URL: http://ianlunn.co.uk/
 * Github: http://github.com/IanLunn/Hover

 * Made available under a MIT License:
 * http://www.opensource.org/licenses/mit-license.php

 * Hover.css Copyright Ian Lunn 2014. Generated with Sass.
 */
/* 2D TRANSITIONS */
/* Grow */
.hvr-grow {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-grow:hover, .hvr-grow:focus, .hvr-grow:active {
  -webkit-transform: scale(1.1);
  transform: scale(1.1);
}

/* Shrink */
.hvr-shrink {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-shrink:hover, .hvr-shrink:focus, .hvr-shrink:active {
  -webkit-transform: scale(0.9);
  transform: scale(0.9);
}

/* Pulse */
@-webkit-keyframes hvr-pulse {
  25% {
    -webkit-transform: scale(1.1);
    transform: scale(1.1);
  }

  75% {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
}

@keyframes hvr-pulse {
  25% {
    -webkit-transform: scale(1.1);
    transform: scale(1.1);
  }

  75% {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
}

.hvr-pulse {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-pulse:hover, .hvr-pulse:focus, .hvr-pulse:active {
  -webkit-animation-name: hvr-pulse;
  animation-name: hvr-pulse;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
}

/* Pulse Grow */
@-webkit-keyframes hvr-pulse-grow {
  to {
    -webkit-transform: scale(1.1);
    transform: scale(1.1);
  }
}

@keyframes hvr-pulse-grow {
  to {
    -webkit-transform: scale(1.1);
    transform: scale(1.1);
  }
}

.hvr-pulse-grow {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-pulse-grow:hover, .hvr-pulse-grow:focus, .hvr-pulse-grow:active {
  -webkit-animation-name: hvr-pulse-grow;
  animation-name: hvr-pulse-grow;
  -webkit-animation-duration: 0.3s;
  animation-duration: 0.3s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
  -webkit-animation-direction: alternate;
  animation-direction: alternate;
}

/* Pulse Shrink */
@-webkit-keyframes hvr-pulse-shrink {
  to {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
}

@keyframes hvr-pulse-shrink {
  to {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
}

.hvr-pulse-shrink {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-pulse-shrink:hover, .hvr-pulse-shrink:focus, .hvr-pulse-shrink:active {
  -webkit-animation-name: hvr-pulse-shrink;
  animation-name: hvr-pulse-shrink;
  -webkit-animation-duration: 0.3s;
  animation-duration: 0.3s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
  -webkit-animation-direction: alternate;
  animation-direction: alternate;
}

/* Push */
@-webkit-keyframes hvr-push {
  50% {
    -webkit-transform: scale(0.8);
    transform: scale(0.8);
  }

  100% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}

@keyframes hvr-push {
  50% {
    -webkit-transform: scale(0.8);
    transform: scale(0.8);
  }

  100% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}

.hvr-push {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-push:hover, .hvr-push:focus, .hvr-push:active {
  -webkit-animation-name: hvr-push;
  animation-name: hvr-push;
  -webkit-animation-duration: 0.3s;
  animation-duration: 0.3s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Pop */
@-webkit-keyframes hvr-pop {
  50% {
    -webkit-transform: scale(1.2);
    transform: scale(1.2);
  }
}

@keyframes hvr-pop {
  50% {
    -webkit-transform: scale(1.2);
    transform: scale(1.2);
  }
}

.hvr-pop {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-pop:hover, .hvr-pop:focus, .hvr-pop:active {
  -webkit-animation-name: hvr-pop;
  animation-name: hvr-pop;
  -webkit-animation-duration: 0.3s;
  animation-duration: 0.3s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Bounce In */
.hvr-bounce-in {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
}
.hvr-bounce-in:hover, .hvr-bounce-in:focus, .hvr-bounce-in:active {
  -webkit-transform: scale(1.2);
  transform: scale(1.2);
  -webkit-transition-timing-function: cubic-bezier(0.47, 2.02, 0.31, -0.36);
  transition-timing-function: cubic-bezier(0.47, 2.02, 0.31, -0.36);
}

/* Bounce Out */
.hvr-bounce-out {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
}
.hvr-bounce-out:hover, .hvr-bounce-out:focus, .hvr-bounce-out:active {
  -webkit-transform: scale(0.8);
  transform: scale(0.8);
  -webkit-transition-timing-function: cubic-bezier(0.47, 2.02, 0.31, -0.36);
  transition-timing-function: cubic-bezier(0.47, 2.02, 0.31, -0.36);
}

/* Rotate */
.hvr-rotate {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-rotate:hover, .hvr-rotate:focus, .hvr-rotate:active {
  -webkit-transform: rotate(4deg);
  transform: rotate(4deg);
}

/* Grow Rotate */
.hvr-grow-rotate {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-grow-rotate:hover, .hvr-grow-rotate:focus, .hvr-grow-rotate:active {
  -webkit-transform: scale(1.1) rotate(4deg);
  transform: scale(1.1) rotate(4deg);
}

/* Float */
.hvr-float {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-float:hover, .hvr-float:focus, .hvr-float:active {
  -webkit-transform: translateY(-8px);
  transform: translateY(-8px);
}

/* Sink */
.hvr-sink {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-sink:hover, .hvr-sink:focus, .hvr-sink:active {
  -webkit-transform: translateY(8px);
  transform: translateY(8px);
}

/* Bob */
@-webkit-keyframes hvr-bob {
  0% {
    -webkit-transform: translateY(-8px);
    transform: translateY(-8px);
  }

  50% {
    -webkit-transform: translateY(-4px);
    transform: translateY(-4px);
  }

  100% {
    -webkit-transform: translateY(-8px);
    transform: translateY(-8px);
  }
}

@keyframes hvr-bob {
  0% {
    -webkit-transform: translateY(-8px);
    transform: translateY(-8px);
  }

  50% {
    -webkit-transform: translateY(-4px);
    transform: translateY(-4px);
  }

  100% {
    -webkit-transform: translateY(-8px);
    transform: translateY(-8px);
  }
}

@-webkit-keyframes hvr-bob-float {
  100% {
    -webkit-transform: translateY(-8px);
    transform: translateY(-8px);
  }
}

@keyframes hvr-bob-float {
  100% {
    -webkit-transform: translateY(-8px);
    transform: translateY(-8px);
  }
}

.hvr-bob {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-bob:hover, .hvr-bob:focus, .hvr-bob:active {
  -webkit-animation-name: hvr-bob-float, hvr-bob;
  animation-name: hvr-bob-float, hvr-bob;
  -webkit-animation-duration: .3s, 1.5s;
  animation-duration: .3s, 1.5s;
  -webkit-animation-delay: 0s, .3s;
  animation-delay: 0s, .3s;
  -webkit-animation-timing-function: ease-out, ease-in-out;
  animation-timing-function: ease-out, ease-in-out;
  -webkit-animation-iteration-count: 1, infinite;
  animation-iteration-count: 1, infinite;
  -webkit-animation-fill-mode: forwards;
  animation-fill-mode: forwards;
  -webkit-animation-direction: normal, alternate;
  animation-direction: normal, alternate;
}

/* Hang */
@-webkit-keyframes hvr-hang {
  0% {
    -webkit-transform: translateY(8px);
    transform: translateY(8px);
  }

  50% {
    -webkit-transform: translateY(4px);
    transform: translateY(4px);
  }

  100% {
    -webkit-transform: translateY(8px);
    transform: translateY(8px);
  }
}

@keyframes hvr-hang {
  0% {
    -webkit-transform: translateY(8px);
    transform: translateY(8px);
  }

  50% {
    -webkit-transform: translateY(4px);
    transform: translateY(4px);
  }

  100% {
    -webkit-transform: translateY(8px);
    transform: translateY(8px);
  }
}

@-webkit-keyframes hvr-hang-sink {
  100% {
    -webkit-transform: translateY(8px);
    transform: translateY(8px);
  }
}

@keyframes hvr-hang-sink {
  100% {
    -webkit-transform: translateY(8px);
    transform: translateY(8px);
  }
}

.hvr-hang {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-hang:hover, .hvr-hang:focus, .hvr-hang:active {
  -webkit-animation-name: hvr-hang-sink, hvr-hang;
  animation-name: hvr-hang-sink, hvr-hang;
  -webkit-animation-duration: .3s, 1.5s;
  animation-duration: .3s, 1.5s;
  -webkit-animation-delay: 0s, .3s;
  animation-delay: 0s, .3s;
  -webkit-animation-timing-function: ease-out, ease-in-out;
  animation-timing-function: ease-out, ease-in-out;
  -webkit-animation-iteration-count: 1, infinite;
  animation-iteration-count: 1, infinite;
  -webkit-animation-fill-mode: forwards;
  animation-fill-mode: forwards;
  -webkit-animation-direction: normal, alternate;
  animation-direction: normal, alternate;
}

/* Skew */
.hvr-skew {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-skew:hover, .hvr-skew:focus, .hvr-skew:active {
  -webkit-transform: skew(-10deg);
  transform: skew(-10deg);
}

/* Skew Forward */
.hvr-skew-forward {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transform-origin: 0 100%;
  transform-origin: 0 100%;
}
.hvr-skew-forward:hover, .hvr-skew-forward:focus, .hvr-skew-forward:active {
  -webkit-transform: skew(-10deg);
  transform: skew(-10deg);
}

/* Skew Backward */
.hvr-skew-backward {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transform-origin: 0 100%;
  transform-origin: 0 100%;
}
.hvr-skew-backward:hover, .hvr-skew-backward:focus, .hvr-skew-backward:active {
  -webkit-transform: skew(10deg);
  transform: skew(10deg);
}

/* Wobble Vertical */
@-webkit-keyframes hvr-wobble-vertical {
  16.65% {
    -webkit-transform: translateY(8px);
    transform: translateY(8px);
  }

  33.3% {
    -webkit-transform: translateY(-6px);
    transform: translateY(-6px);
  }

  49.95% {
    -webkit-transform: translateY(4px);
    transform: translateY(4px);
  }

  66.6% {
    -webkit-transform: translateY(-2px);
    transform: translateY(-2px);
  }

  83.25% {
    -webkit-transform: translateY(1px);
    transform: translateY(1px);
  }

  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

@keyframes hvr-wobble-vertical {
  16.65% {
    -webkit-transform: translateY(8px);
    transform: translateY(8px);
  }

  33.3% {
    -webkit-transform: translateY(-6px);
    transform: translateY(-6px);
  }

  49.95% {
    -webkit-transform: translateY(4px);
    transform: translateY(4px);
  }

  66.6% {
    -webkit-transform: translateY(-2px);
    transform: translateY(-2px);
  }

  83.25% {
    -webkit-transform: translateY(1px);
    transform: translateY(1px);
  }

  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

.hvr-wobble-vertical {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-wobble-vertical:hover, .hvr-wobble-vertical:focus, .hvr-wobble-vertical:active {
  -webkit-animation-name: hvr-wobble-vertical;
  animation-name: hvr-wobble-vertical;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Wobble Horizontal */
@-webkit-keyframes hvr-wobble-horizontal {
  16.65% {
    -webkit-transform: translateX(8px);
    transform: translateX(8px);
  }

  33.3% {
    -webkit-transform: translateX(-6px);
    transform: translateX(-6px);
  }

  49.95% {
    -webkit-transform: translateX(4px);
    transform: translateX(4px);
  }

  66.6% {
    -webkit-transform: translateX(-2px);
    transform: translateX(-2px);
  }

  83.25% {
    -webkit-transform: translateX(1px);
    transform: translateX(1px);
  }

  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes hvr-wobble-horizontal {
  16.65% {
    -webkit-transform: translateX(8px);
    transform: translateX(8px);
  }

  33.3% {
    -webkit-transform: translateX(-6px);
    transform: translateX(-6px);
  }

  49.95% {
    -webkit-transform: translateX(4px);
    transform: translateX(4px);
  }

  66.6% {
    -webkit-transform: translateX(-2px);
    transform: translateX(-2px);
  }

  83.25% {
    -webkit-transform: translateX(1px);
    transform: translateX(1px);
  }

  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

.hvr-wobble-horizontal {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-wobble-horizontal:hover, .hvr-wobble-horizontal:focus, .hvr-wobble-horizontal:active {
  -webkit-animation-name: hvr-wobble-horizontal;
  animation-name: hvr-wobble-horizontal;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Wobble To Bottom Right */
@-webkit-keyframes hvr-wobble-to-bottom-right {
  16.65% {
    -webkit-transform: translate(8px, 8px);
    transform: translate(8px, 8px);
  }

  33.3% {
    -webkit-transform: translate(-6px, -6px);
    transform: translate(-6px, -6px);
  }

  49.95% {
    -webkit-transform: translate(4px, 4px);
    transform: translate(4px, 4px);
  }

  66.6% {
    -webkit-transform: translate(-2px, -2px);
    transform: translate(-2px, -2px);
  }

  83.25% {
    -webkit-transform: translate(1px, 1px);
    transform: translate(1px, 1px);
  }

  100% {
    -webkit-transform: translate(0, 0);
    transform: translate(0, 0);
  }
}

@keyframes hvr-wobble-to-bottom-right {
  16.65% {
    -webkit-transform: translate(8px, 8px);
    transform: translate(8px, 8px);
  }

  33.3% {
    -webkit-transform: translate(-6px, -6px);
    transform: translate(-6px, -6px);
  }

  49.95% {
    -webkit-transform: translate(4px, 4px);
    transform: translate(4px, 4px);
  }

  66.6% {
    -webkit-transform: translate(-2px, -2px);
    transform: translate(-2px, -2px);
  }

  83.25% {
    -webkit-transform: translate(1px, 1px);
    transform: translate(1px, 1px);
  }

  100% {
    -webkit-transform: translate(0, 0);
    transform: translate(0, 0);
  }
}

.hvr-wobble-to-bottom-right {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-wobble-to-bottom-right:hover, .hvr-wobble-to-bottom-right:focus, .hvr-wobble-to-bottom-right:active {
  -webkit-animation-name: hvr-wobble-to-bottom-right;
  animation-name: hvr-wobble-to-bottom-right;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Wobble To Top Right */
@-webkit-keyframes hvr-wobble-to-top-right {
  16.65% {
    -webkit-transform: translate(8px, -8px);
    transform: translate(8px, -8px);
  }

  33.3% {
    -webkit-transform: translate(-6px, 6px);
    transform: translate(-6px, 6px);
  }

  49.95% {
    -webkit-transform: translate(4px, -4px);
    transform: translate(4px, -4px);
  }

  66.6% {
    -webkit-transform: translate(-2px, 2px);
    transform: translate(-2px, 2px);
  }

  83.25% {
    -webkit-transform: translate(1px, -1px);
    transform: translate(1px, -1px);
  }

  100% {
    -webkit-transform: translate(0, 0);
    transform: translate(0, 0);
  }
}

@keyframes hvr-wobble-to-top-right {
  16.65% {
    -webkit-transform: translate(8px, -8px);
    transform: translate(8px, -8px);
  }

  33.3% {
    -webkit-transform: translate(-6px, 6px);
    transform: translate(-6px, 6px);
  }

  49.95% {
    -webkit-transform: translate(4px, -4px);
    transform: translate(4px, -4px);
  }

  66.6% {
    -webkit-transform: translate(-2px, 2px);
    transform: translate(-2px, 2px);
  }

  83.25% {
    -webkit-transform: translate(1px, -1px);
    transform: translate(1px, -1px);
  }

  100% {
    -webkit-transform: translate(0, 0);
    transform: translate(0, 0);
  }
}

.hvr-wobble-to-top-right {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-wobble-to-top-right:hover, .hvr-wobble-to-top-right:focus, .hvr-wobble-to-top-right:active {
  -webkit-animation-name: hvr-wobble-to-top-right;
  animation-name: hvr-wobble-to-top-right;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Wobble Top */
@-webkit-keyframes hvr-wobble-top {
  16.65% {
    -webkit-transform: skew(-12deg);
    transform: skew(-12deg);
  }

  33.3% {
    -webkit-transform: skew(10deg);
    transform: skew(10deg);
  }

  49.95% {
    -webkit-transform: skew(-6deg);
    transform: skew(-6deg);
  }

  66.6% {
    -webkit-transform: skew(4deg);
    transform: skew(4deg);
  }

  83.25% {
    -webkit-transform: skew(-2deg);
    transform: skew(-2deg);
  }

  100% {
    -webkit-transform: skew(0);
    transform: skew(0);
  }
}

@keyframes hvr-wobble-top {
  16.65% {
    -webkit-transform: skew(-12deg);
    transform: skew(-12deg);
  }

  33.3% {
    -webkit-transform: skew(10deg);
    transform: skew(10deg);
  }

  49.95% {
    -webkit-transform: skew(-6deg);
    transform: skew(-6deg);
  }

  66.6% {
    -webkit-transform: skew(4deg);
    transform: skew(4deg);
  }

  83.25% {
    -webkit-transform: skew(-2deg);
    transform: skew(-2deg);
  }

  100% {
    -webkit-transform: skew(0);
    transform: skew(0);
  }
}

.hvr-wobble-top {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transform-origin: 0 100%;
  transform-origin: 0 100%;
}
.hvr-wobble-top:hover, .hvr-wobble-top:focus, .hvr-wobble-top:active {
  -webkit-animation-name: hvr-wobble-top;
  animation-name: hvr-wobble-top;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Wobble Bottom */
@-webkit-keyframes hvr-wobble-bottom {
  16.65% {
    -webkit-transform: skew(-12deg);
    transform: skew(-12deg);
  }

  33.3% {
    -webkit-transform: skew(10deg);
    transform: skew(10deg);
  }

  49.95% {
    -webkit-transform: skew(-6deg);
    transform: skew(-6deg);
  }

  66.6% {
    -webkit-transform: skew(4deg);
    transform: skew(4deg);
  }

  83.25% {
    -webkit-transform: skew(-2deg);
    transform: skew(-2deg);
  }

  100% {
    -webkit-transform: skew(0);
    transform: skew(0);
  }
}

@keyframes hvr-wobble-bottom {
  16.65% {
    -webkit-transform: skew(-12deg);
    transform: skew(-12deg);
  }

  33.3% {
    -webkit-transform: skew(10deg);
    transform: skew(10deg);
  }

  49.95% {
    -webkit-transform: skew(-6deg);
    transform: skew(-6deg);
  }

  66.6% {
    -webkit-transform: skew(4deg);
    transform: skew(4deg);
  }

  83.25% {
    -webkit-transform: skew(-2deg);
    transform: skew(-2deg);
  }

  100% {
    -webkit-transform: skew(0);
    transform: skew(0);
  }
}

.hvr-wobble-bottom {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transform-origin: 100% 0;
  transform-origin: 100% 0;
}
.hvr-wobble-bottom:hover, .hvr-wobble-bottom:focus, .hvr-wobble-bottom:active {
  -webkit-animation-name: hvr-wobble-bottom;
  animation-name: hvr-wobble-bottom;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Wobble Skew */
@-webkit-keyframes hvr-wobble-skew {
  16.65% {
    -webkit-transform: skew(-12deg);
    transform: skew(-12deg);
  }

  33.3% {
    -webkit-transform: skew(10deg);
    transform: skew(10deg);
  }

  49.95% {
    -webkit-transform: skew(-6deg);
    transform: skew(-6deg);
  }

  66.6% {
    -webkit-transform: skew(4deg);
    transform: skew(4deg);
  }

  83.25% {
    -webkit-transform: skew(-2deg);
    transform: skew(-2deg);
  }

  100% {
    -webkit-transform: skew(0);
    transform: skew(0);
  }
}

@keyframes hvr-wobble-skew {
  16.65% {
    -webkit-transform: skew(-12deg);
    transform: skew(-12deg);
  }

  33.3% {
    -webkit-transform: skew(10deg);
    transform: skew(10deg);
  }

  49.95% {
    -webkit-transform: skew(-6deg);
    transform: skew(-6deg);
  }

  66.6% {
    -webkit-transform: skew(4deg);
    transform: skew(4deg);
  }

  83.25% {
    -webkit-transform: skew(-2deg);
    transform: skew(-2deg);
  }

  100% {
    -webkit-transform: skew(0);
    transform: skew(0);
  }
}

.hvr-wobble-skew {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-wobble-skew:hover, .hvr-wobble-skew:focus, .hvr-wobble-skew:active {
  -webkit-animation-name: hvr-wobble-skew;
  animation-name: hvr-wobble-skew;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Buzz */
@-webkit-keyframes hvr-buzz {
  50% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  100% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }
}

@keyframes hvr-buzz {
  50% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  100% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }
}

.hvr-buzz {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-buzz:hover, .hvr-buzz:focus, .hvr-buzz:active {
  -webkit-animation-name: hvr-buzz;
  animation-name: hvr-buzz;
  -webkit-animation-duration: 0.15s;
  animation-duration: 0.15s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
}

/* Buzz Out */
@-webkit-keyframes hvr-buzz-out {
  10% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  20% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }

  30% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  40% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }

  50% {
    -webkit-transform: translateX(2px) rotate(1deg);
    transform: translateX(2px) rotate(1deg);
  }

  60% {
    -webkit-transform: translateX(-2px) rotate(-1deg);
    transform: translateX(-2px) rotate(-1deg);
  }

  70% {
    -webkit-transform: translateX(2px) rotate(1deg);
    transform: translateX(2px) rotate(1deg);
  }

  80% {
    -webkit-transform: translateX(-2px) rotate(-1deg);
    transform: translateX(-2px) rotate(-1deg);
  }

  90% {
    -webkit-transform: translateX(1px) rotate(0);
    transform: translateX(1px) rotate(0);
  }

  100% {
    -webkit-transform: translateX(-1px) rotate(0);
    transform: translateX(-1px) rotate(0);
  }
}

@keyframes hvr-buzz-out {
  10% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  20% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }

  30% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  40% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }

  50% {
    -webkit-transform: translateX(2px) rotate(1deg);
    transform: translateX(2px) rotate(1deg);
  }

  60% {
    -webkit-transform: translateX(-2px) rotate(-1deg);
    transform: translateX(-2px) rotate(-1deg);
  }

  70% {
    -webkit-transform: translateX(2px) rotate(1deg);
    transform: translateX(2px) rotate(1deg);
  }

  80% {
    -webkit-transform: translateX(-2px) rotate(-1deg);
    transform: translateX(-2px) rotate(-1deg);
  }

  90% {
    -webkit-transform: translateX(1px) rotate(0);
    transform: translateX(1px) rotate(0);
  }

  100% {
    -webkit-transform: translateX(-1px) rotate(0);
    transform: translateX(-1px) rotate(0);
  }
}

.hvr-buzz-out {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
}
.hvr-buzz-out:hover, .hvr-buzz-out:focus, .hvr-buzz-out:active {
  -webkit-animation-name: hvr-buzz-out;
  animation-name: hvr-buzz-out;
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* BACKGROUND TRANSITIONS */
/* Fade */
.hvr-fade {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  overflow: hidden;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: color, background-color;
  transition-property: color, background-color;
}
.hvr-fade:hover, .hvr-fade:focus, .hvr-fade:active {
  background-color: #2098d1;
  color: white;
}

/* Back Pulse */
@-webkit-keyframes hvr-back-pulse {
  50% {
    background-color: rgba(32, 152, 209, 0.75);
  }
}

@keyframes hvr-back-pulse {
  50% {
    background-color: rgba(32, 152, 209, 0.75);
  }
}

.hvr-back-pulse {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  overflow: hidden;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
  -webkit-transition-property: color, background-color;
  transition-property: color, background-color;
}
.hvr-back-pulse:hover, .hvr-back-pulse:focus, .hvr-back-pulse:active {
  -webkit-animation-name: hvr-back-pulse;
  animation-name: hvr-back-pulse;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-delay: 0.5s;
  animation-delay: 0.5s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
  background-color: #2098d1;
  background-color: #2098d1;
  color: white;
}

/* Sweep To Right */
.hvr-sweep-to-right {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-sweep-to-right:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  -webkit-transform: scaleX(0);
  transform: scaleX(0);
  -webkit-transform-origin: 0 50%;
  transform-origin: 0 50%;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-sweep-to-right:hover, .hvr-sweep-to-right:focus, .hvr-sweep-to-right:active {
  color: white;
}
.hvr-sweep-to-right:hover:before, .hvr-sweep-to-right:focus:before, .hvr-sweep-to-right:active:before {
  -webkit-transform: scaleX(1);
  transform: scaleX(1);
}

/* Sweep To Left */
.hvr-sweep-to-left {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-sweep-to-left:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  -webkit-transform: scaleX(0);
  transform: scaleX(0);
  -webkit-transform-origin: 100% 50%;
  transform-origin: 100% 50%;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-sweep-to-left:hover, .hvr-sweep-to-left:focus, .hvr-sweep-to-left:active {
  color: white;
}
.hvr-sweep-to-left:hover:before, .hvr-sweep-to-left:focus:before, .hvr-sweep-to-left:active:before {
  -webkit-transform: scaleX(1);
  transform: scaleX(1);
}

/* Sweep To Bottom */
.hvr-sweep-to-bottom {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-sweep-to-bottom:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  -webkit-transform: scaleY(0);
  transform: scaleY(0);
  -webkit-transform-origin: 50% 0;
  transform-origin: 50% 0;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-sweep-to-bottom:hover, .hvr-sweep-to-bottom:focus, .hvr-sweep-to-bottom:active {
  color: white;
}
.hvr-sweep-to-bottom:hover:before, .hvr-sweep-to-bottom:focus:before, .hvr-sweep-to-bottom:active:before {
  -webkit-transform: scaleY(1);
  transform: scaleY(1);
}

/* Sweep To Top */
.hvr-sweep-to-top {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-sweep-to-top:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  -webkit-transform: scaleY(0);
  transform: scaleY(0);
  -webkit-transform-origin: 50% 100%;
  transform-origin: 50% 100%;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-sweep-to-top:hover, .hvr-sweep-to-top:focus, .hvr-sweep-to-top:active {
  color: white;
}
.hvr-sweep-to-top:hover:before, .hvr-sweep-to-top:focus:before, .hvr-sweep-to-top:active:before {
  -webkit-transform: scaleY(1);
  transform: scaleY(1);
}

/* Bounce To Right */
.hvr-bounce-to-right {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
}
.hvr-bounce-to-right:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  -webkit-transform: scaleX(0);
  transform: scaleX(0);
  -webkit-transform-origin: 0 50%;
  transform-origin: 0 50%;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-bounce-to-right:hover, .hvr-bounce-to-right:focus, .hvr-bounce-to-right:active {
  color: white;
}
.hvr-bounce-to-right:hover:before, .hvr-bounce-to-right:focus:before, .hvr-bounce-to-right:active:before {
  -webkit-transform: scaleX(1);
  transform: scaleX(1);
  -webkit-transition-timing-function: cubic-bezier(0.52, 1.64, 0.37, 0.66);
  transition-timing-function: cubic-bezier(0.52, 1.64, 0.37, 0.66);
}

/* Bounce To Left */
.hvr-bounce-to-left {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
}
.hvr-bounce-to-left:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  -webkit-transform: scaleX(0);
  transform: scaleX(0);
  -webkit-transform-origin: 100% 50%;
  transform-origin: 100% 50%;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-bounce-to-left:hover, .hvr-bounce-to-left:focus, .hvr-bounce-to-left:active {
  color: white;
}
.hvr-bounce-to-left:hover:before, .hvr-bounce-to-left:focus:before, .hvr-bounce-to-left:active:before {
  -webkit-transform: scaleX(1);
  transform: scaleX(1);
  -webkit-transition-timing-function: cubic-bezier(0.52, 1.64, 0.37, 0.66);
  transition-timing-function: cubic-bezier(0.52, 1.64, 0.37, 0.66);
}

/* Bounce To Bottom */
.hvr-bounce-to-bottom {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
}
.hvr-bounce-to-bottom:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  -webkit-transform: scaleY(0);
  transform: scaleY(0);
  -webkit-transform-origin: 50% 0;
  transform-origin: 50% 0;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-bounce-to-bottom:hover, .hvr-bounce-to-bottom:focus, .hvr-bounce-to-bottom:active {
  color: white;
}
.hvr-bounce-to-bottom:hover:before, .hvr-bounce-to-bottom:focus:before, .hvr-bounce-to-bottom:active:before {
  -webkit-transform: scaleY(1);
  transform: scaleY(1);
  -webkit-transition-timing-function: cubic-bezier(0.52, 1.64, 0.37, 0.66);
  transition-timing-function: cubic-bezier(0.52, 1.64, 0.37, 0.66);
}

/* Bounce To Top */
.hvr-bounce-to-top {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
}
.hvr-bounce-to-top:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  -webkit-transform: scaleY(0);
  transform: scaleY(0);
  -webkit-transform-origin: 50% 100%;
  transform-origin: 50% 100%;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-bounce-to-top:hover, .hvr-bounce-to-top:focus, .hvr-bounce-to-top:active {
  color: white;
}
.hvr-bounce-to-top:hover:before, .hvr-bounce-to-top:focus:before, .hvr-bounce-to-top:active:before {
  -webkit-transform: scaleY(1);
  transform: scaleY(1);
  -webkit-transition-timing-function: cubic-bezier(0.52, 1.64, 0.37, 0.66);
  transition-timing-function: cubic-bezier(0.52, 1.64, 0.37, 0.66);
}

/* Radial Out */
.hvr-radial-out {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
  background: #e1e1e1;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-radial-out:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  border-radius: 100%;
  -webkit-transform: scale(0);
  transform: scale(0);
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-radial-out:hover, .hvr-radial-out:focus, .hvr-radial-out:active {
  color: white;
}
.hvr-radial-out:hover:before, .hvr-radial-out:focus:before, .hvr-radial-out:active:before {
  -webkit-transform: scale(2);
  transform: scale(2);
}

/* Radial In */
.hvr-radial-in {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
  background: #2098d1;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-radial-in:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #e1e1e1;
  border-radius: 100%;
  -webkit-transform: scale(2);
  transform: scale(2);
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-radial-in:hover, .hvr-radial-in:focus, .hvr-radial-in:active {
  color: white;
}
.hvr-radial-in:hover:before, .hvr-radial-in:focus:before, .hvr-radial-in:active:before {
  -webkit-transform: scale(0);
  transform: scale(0);
}

/* Rectangle In */
.hvr-rectangle-in {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  background: #2098d1;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-rectangle-in:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #e1e1e1;
  -webkit-transform: scale(1);
  transform: scale(1);
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-rectangle-in:hover, .hvr-rectangle-in:focus, .hvr-rectangle-in:active {
  color: white;
}
.hvr-rectangle-in:hover:before, .hvr-rectangle-in:focus:before, .hvr-rectangle-in:active:before {
  -webkit-transform: scale(0);
  transform: scale(0);
}

/* Rectangle Out */
.hvr-rectangle-out {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  background: #e1e1e1;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-rectangle-out:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  -webkit-transform: scale(0);
  transform: scale(0);
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-rectangle-out:hover, .hvr-rectangle-out:focus, .hvr-rectangle-out:active {
  color: white;
}
.hvr-rectangle-out:hover:before, .hvr-rectangle-out:focus:before, .hvr-rectangle-out:active:before {
  -webkit-transform: scale(1);
  transform: scale(1);
}

/* Shutter In Horizontal */
.hvr-shutter-in-horizontal {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  background: #2098d1;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-shutter-in-horizontal:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background: #e1e1e1;
  -webkit-transform: scaleX(1);
  transform: scaleX(1);
  -webkit-transform-origin: 50%;
  transform-origin: 50%;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-shutter-in-horizontal:hover, .hvr-shutter-in-horizontal:focus, .hvr-shutter-in-horizontal:active {
  color: white;
}
.hvr-shutter-in-horizontal:hover:before, .hvr-shutter-in-horizontal:focus:before, .hvr-shutter-in-horizontal:active:before {
  -webkit-transform: scaleX(0);
  transform: scaleX(0);
}

/* Shutter Out Horizontal */
.hvr-shutter-out-horizontal {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  background: #e1e1e1;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-shutter-out-horizontal:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background: #2098d1;
  -webkit-transform: scaleX(0);
  transform: scaleX(0);
  -webkit-transform-origin: 50%;
  transform-origin: 50%;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-shutter-out-horizontal:hover, .hvr-shutter-out-horizontal:focus, .hvr-shutter-out-horizontal:active {
  color: white;
}
.hvr-shutter-out-horizontal:hover:before, .hvr-shutter-out-horizontal:focus:before, .hvr-shutter-out-horizontal:active:before {
  -webkit-transform: scaleX(1);
  transform: scaleX(1);
}

/* Shutter In Vertical */
.hvr-shutter-in-vertical {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  background: #2098d1;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-shutter-in-vertical:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background: #e1e1e1;
  -webkit-transform: scaleY(1);
  transform: scaleY(1);
  -webkit-transform-origin: 50%;
  transform-origin: 50%;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-shutter-in-vertical:hover, .hvr-shutter-in-vertical:focus, .hvr-shutter-in-vertical:active {
  color: white;
}
.hvr-shutter-in-vertical:hover:before, .hvr-shutter-in-vertical:focus:before, .hvr-shutter-in-vertical:active:before {
  -webkit-transform: scaleY(0);
  transform: scaleY(0);
}

/* Shutter Out Vertical */
.hvr-shutter-out-vertical {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  background: #e1e1e1;
  -webkit-transition-property: color;
  transition-property: color;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-shutter-out-vertical:before {
  content: "";
  position: absolute;
  z-index: -1;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background: #2098d1;
  -webkit-transform: scaleY(0);
  transform: scaleY(0);
  -webkit-transform-origin: 50%;
  transform-origin: 50%;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-shutter-out-vertical:hover, .hvr-shutter-out-vertical:focus, .hvr-shutter-out-vertical:active {
  color: white;
}
.hvr-shutter-out-vertical:hover:before, .hvr-shutter-out-vertical:focus:before, .hvr-shutter-out-vertical:active:before {
  -webkit-transform: scaleY(1);
  transform: scaleY(1);
}

/* BORDER TRANSITIONS */
/* Border Fade */
.hvr-border-fade {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: box-shadow;
  transition-property: box-shadow;
  box-shadow: inset 0 0 0 4px #e1e1e1, 0 0 1px rgba(0, 0, 0, 0);
  /* Hack to improve aliasing on mobile/tablet devices */
}
.hvr-border-fade:hover, .hvr-border-fade:focus, .hvr-border-fade:active {
  box-shadow: inset 0 0 0 4px #2098d1, 0 0 1px rgba(0, 0, 0, 0);
  /* Hack to improve aliasing on mobile/tablet devices */
}

/* Hollow */
.hvr-hollow {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: background;
  transition-property: background;
  box-shadow: inset 0 0 0 4px #e1e1e1, 0 0 1px rgba(0, 0, 0, 0);
  /* Hack to improve aliasing on mobile/tablet devices */
}
.hvr-hollow:hover, .hvr-hollow:focus, .hvr-hollow:active {
  background: none;
}

/* Trim */
.hvr-trim {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-trim:before {
  content: '';
  position: absolute;
  border: white solid 4px;
  top: 4px;
  left: 4px;
  right: 4px;
  bottom: 4px;
  opacity: 0;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: opacity;
  transition-property: opacity;
}
.hvr-trim:hover:before, .hvr-trim:focus:before, .hvr-trim:active:before {
  opacity: 1;
}

/* Ripple Out */
@-webkit-keyframes hvr-ripple-out {
  100% {
    top: -12px;
    right: -12px;
    bottom: -12px;
    left: -12px;
    opacity: 0;
  }
}

@keyframes hvr-ripple-out {
  100% {
    top: -12px;
    right: -12px;
    bottom: -12px;
    left: -12px;
    opacity: 0;
  }
}

.hvr-ripple-out {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-ripple-out:before {
  content: '';
  position: absolute;
  border: #e1e1e1 solid 6px;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
}
.hvr-ripple-out:hover:before, .hvr-ripple-out:focus:before, .hvr-ripple-out:active:before {
  -webkit-animation-name: hvr-ripple-out;
  animation-name: hvr-ripple-out;
}

/* Ripple In */
@-webkit-keyframes hvr-ripple-in {
  100% {
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    opacity: 1;
  }
}

@keyframes hvr-ripple-in {
  100% {
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    opacity: 1;
  }
}

.hvr-ripple-in {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-ripple-in:before {
  content: '';
  position: absolute;
  border: #e1e1e1 solid 4px;
  top: -12px;
  right: -12px;
  bottom: -12px;
  left: -12px;
  opacity: 0;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
}
.hvr-ripple-in:hover:before, .hvr-ripple-in:focus:before, .hvr-ripple-in:active:before {
  -webkit-animation-name: hvr-ripple-in;
  animation-name: hvr-ripple-in;
}

/* Outline Out */
.hvr-outline-out {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-outline-out:before {
  content: '';
  position: absolute;
  border: #e1e1e1 solid 4px;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: top, right, bottom, left;
  transition-property: top, right, bottom, left;
}
.hvr-outline-out:hover:before, .hvr-outline-out:focus:before, .hvr-outline-out:active:before {
  top: -8px;
  right: -8px;
  bottom: -8px;
  left: -8px;
}

/* Outline In */
.hvr-outline-in {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-outline-in:before {
  pointer-events: none;
  content: '';
  position: absolute;
  border: #e1e1e1 solid 4px;
  top: -16px;
  right: -16px;
  bottom: -16px;
  left: -16px;
  opacity: 0;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: top, right, bottom, left;
  transition-property: top, right, bottom, left;
}
.hvr-outline-in:hover:before, .hvr-outline-in:focus:before, .hvr-outline-in:active:before {
  top: -8px;
  right: -8px;
  bottom: -8px;
  left: -8px;
  opacity: 1;
}

/* Round Corners */
.hvr-round-corners {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: border-radius;
  transition-property: border-radius;
}
.hvr-round-corners:hover, .hvr-round-corners:focus, .hvr-round-corners:active {
  border-radius: 1em;
}

/* Underline From Left */
.hvr-underline-from-left {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
}
.hvr-underline-from-left:before {
  content: "";
  position: absolute;
  z-index: -1;
  left: 0;
  right: 100%;
  bottom: 0;
  background: #2098d1;
  height: 4px;
  -webkit-transition-property: right;
  transition-property: right;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-underline-from-left:hover:before, .hvr-underline-from-left:focus:before, .hvr-underline-from-left:active:before {
  right: 0;
}

/* Underline From Center */
.hvr-underline-from-center {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
}
.hvr-underline-from-center:before {
  content: "";
  position: absolute;
  z-index: -1;
  left: 50%;
  right: 50%;
  bottom: 0;
  background: #2098d1;
  height: 4px;
  -webkit-transition-property: left, right;
  transition-property: left, right;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-underline-from-center:hover:before, .hvr-underline-from-center:focus:before, .hvr-underline-from-center:active:before {
  left: 0;
  right: 0;
}

/* Underline From Right */
.hvr-underline-from-right {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
}
.hvr-underline-from-right:before {
  content: "";
  position: absolute;
  z-index: -1;
  left: 100%;
  right: 0;
  bottom: 0;
  background: #2098d1;
  height: 4px;
  -webkit-transition-property: left;
  transition-property: left;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-underline-from-right:hover:before, .hvr-underline-from-right:focus:before, .hvr-underline-from-right:active:before {
  left: 0;
}

/* Overline From Left */
.hvr-overline-from-left {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
}
.hvr-overline-from-left:before {
  content: "";
  position: absolute;
  z-index: -1;
  left: 0;
  right: 100%;
  top: 0;
  background: #2098d1;
  height: 4px;
  -webkit-transition-property: right;
  transition-property: right;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-overline-from-left:hover:before, .hvr-overline-from-left:focus:before, .hvr-overline-from-left:active:before {
  right: 0;
}

/* Overline From Center */
.hvr-overline-from-center {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
}
.hvr-overline-from-center:before {
  content: "";
  position: absolute;
  z-index: -1;
  left: 50%;
  right: 50%;
  top: 0;
  background: #2098d1;
  height: 4px;
  -webkit-transition-property: left, right;
  transition-property: left, right;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-overline-from-center:hover:before, .hvr-overline-from-center:focus:before, .hvr-overline-from-center:active:before {
  left: 0;
  right: 0;
}

/* Overline From Right */
.hvr-overline-from-right {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
}
.hvr-overline-from-right:before {
  content: "";
  position: absolute;
  z-index: -1;
  left: 100%;
  right: 0;
  top: 0;
  background: #2098d1;
  height: 4px;
  -webkit-transition-property: left;
  transition-property: left;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-overline-from-right:hover:before, .hvr-overline-from-right:focus:before, .hvr-overline-from-right:active:before {
  left: 0;
}

/* Reveal */
.hvr-reveal {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
}
.hvr-reveal:before {
  content: "";
  position: absolute;
  z-index: -1;
  left: 0;
  right: 0;
  top: 0;
  bottom: 0;
  border-color: #2098d1;
  border-style: solid;
  border-width: 0;
  -webkit-transition-property: border-width;
  transition-property: border-width;
  -webkit-transition-duration: 0.1s;
  transition-duration: 0.1s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-reveal:hover:before, .hvr-reveal:focus:before, .hvr-reveal:active:before {
  -webkit-transform: translateY(0);
  transform: translateY(0);
  border-width: 4px;
}

/* Underline Reveal */
.hvr-underline-reveal {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
}
.hvr-underline-reveal:before {
  content: "";
  position: absolute;
  z-index: -1;
  left: 0;
  right: 0;
  bottom: 0;
  background: #2098d1;
  height: 4px;
  -webkit-transform: translateY(4px);
  transform: translateY(4px);
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-underline-reveal:hover:before, .hvr-underline-reveal:focus:before, .hvr-underline-reveal:active:before {
  -webkit-transform: translateY(0);
  transform: translateY(0);
}

/* Overline Reveal */
.hvr-overline-reveal {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  overflow: hidden;
}
.hvr-overline-reveal:before {
  content: "";
  position: absolute;
  z-index: -1;
  left: 0;
  right: 0;
  top: 0;
  background: #2098d1;
  height: 4px;
  -webkit-transform: translateY(-4px);
  transform: translateY(-4px);
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-overline-reveal:hover:before, .hvr-overline-reveal:focus:before, .hvr-overline-reveal:active:before {
  -webkit-transform: translateY(0);
  transform: translateY(0);
}

/* SHADOW/GLOW TRANSITIONS */
/* Glow */
.hvr-glow {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: box-shadow;
  transition-property: box-shadow;
}
.hvr-glow:hover, .hvr-glow:focus, .hvr-glow:active {
  box-shadow: 0 0 8px rgba(0, 0, 0, 0.6);
}

/* Shadow */
.hvr-shadow {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: box-shadow;
  transition-property: box-shadow;
}
.hvr-shadow:hover, .hvr-shadow:focus, .hvr-shadow:active {
  box-shadow: 0 10px 10px -10px rgba(0, 0, 0, 0.5);
}

/* Grow Shadow */
.hvr-grow-shadow {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: box-shadow, transform;
  transition-property: box-shadow, transform;
}
.hvr-grow-shadow:hover, .hvr-grow-shadow:focus, .hvr-grow-shadow:active {
  box-shadow: 0 10px 10px -10px rgba(0, 0, 0, 0.5);
  -webkit-transform: scale(1.1);
  transform: scale(1.1);
}

/* Box Shadow Outset */
.hvr-box-shadow-outset {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: box-shadow;
  transition-property: box-shadow;
}
.hvr-box-shadow-outset:hover, .hvr-box-shadow-outset:focus, .hvr-box-shadow-outset:active {
  box-shadow: 2px 2px 2px rgba(0, 0, 0, 0.6);
}

/* Box Shadow Inset */
.hvr-box-shadow-inset {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: box-shadow;
  transition-property: box-shadow;
  box-shadow: inset 0 0 0 rgba(0, 0, 0, 0.6), 0 0 1px rgba(0, 0, 0, 0);
  /* Hack to improve aliasing on mobile/tablet devices */
}
.hvr-box-shadow-inset:hover, .hvr-box-shadow-inset:focus, .hvr-box-shadow-inset:active {
  box-shadow: inset 2px 2px 2px rgba(0, 0, 0, 0.6), 0 0 1px rgba(0, 0, 0, 0);
  /* Hack to improve aliasing on mobile/tablet devices */
}

/* Float Shadow */
.hvr-float-shadow {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}

.hvr-float-shadow:before {
  pointer-events: none;
  position: absolute;
  z-index: -1;
  content: '';
  top: 100%;
  left: 5%;
  height: 10px;
  width: 90%;
  opacity: 0;
  background: -webkit-radial-gradient(center, ellipse, rgba(0, 0, 0, 0.35) 0%, rgba(0, 0, 0, 0) 80%);
  background: radial-gradient(ellipse at center, rgba(0, 0, 0, 0.35) 0%, rgba(0, 0, 0, 0) 80%);
  /* W3C */
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform, opacity;
  transition-property: transform, opacity;
}
.hvr-float-shadow:hover, .hvr-float-shadow:focus, .hvr-float-shadow:active {
  -webkit-transform: translateY(-5px);
  transform: translateY(-5px);
  /* move the element up by 5px */
}
.hvr-float-shadow:hover:before, .hvr-float-shadow:focus:before, .hvr-float-shadow:active:before {
  opacity: 1;
  -webkit-transform: translateY(5px);
  transform: translateY(5px);
  /* move the element down by 5px (it will stay in place because it's attached to the element that also moves up 5px) */
}

/* Shadow Radial */
.hvr-shadow-radial {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-shadow-radial:before, .hvr-shadow-radial:after {
  pointer-events: none;
  position: absolute;
  content: '';
  left: 0;
  width: 100%;
  box-sizing: border-box;
  background-repeat: no-repeat;
  height: 5px;
  opacity: 0;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: opacity;
  transition-property: opacity;
}
.hvr-shadow-radial:before {
  bottom: 100%;
  background: -webkit-radial-gradient(50% 150%, ellipse, rgba(0, 0, 0, 0.6) 0%, rgba(0, 0, 0, 0) 80%);
  background: radial-gradient(ellipse at 50% 150%, rgba(0, 0, 0, 0.6) 0%, rgba(0, 0, 0, 0) 80%);
}
.hvr-shadow-radial:after {
  top: 100%;
  background: -webkit-radial-gradient(50% -50%, ellipse, rgba(0, 0, 0, 0.6) 0%, rgba(0, 0, 0, 0) 80%);
  background: radial-gradient(ellipse at 50% -50%, rgba(0, 0, 0, 0.6) 0%, rgba(0, 0, 0, 0) 80%);
}
.hvr-shadow-radial:hover:before, .hvr-shadow-radial:focus:before, .hvr-shadow-radial:active:before, .hvr-shadow-radial:hover:after, .hvr-shadow-radial:focus:after, .hvr-shadow-radial:active:after {
  opacity: 1;
}

/* SPEECH BUBBLES */
/* Bubble Top */
.hvr-bubble-top {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-bubble-top:before {
  pointer-events: none;
  position: absolute;
  z-index: -1;
  content: '';
  border-style: solid;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  left: calc(50% - 10px);
  top: 0;
  border-width: 0 10px 10px 10px;
  border-color: transparent transparent #e1e1e1 transparent;
}
.hvr-bubble-top:hover:before, .hvr-bubble-top:focus:before, .hvr-bubble-top:active:before {
  -webkit-transform: translateY(-10px);
  transform: translateY(-10px);
}

/* Bubble Right */
.hvr-bubble-right {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-bubble-right:before {
  pointer-events: none;
  position: absolute;
  z-index: -1;
  content: '';
  border-style: solid;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  top: calc(50% - 10px);
  right: 0;
  border-width: 10px 0 10px 10px;
  border-color: transparent transparent transparent #e1e1e1;
}
.hvr-bubble-right:hover:before, .hvr-bubble-right:focus:before, .hvr-bubble-right:active:before {
  -webkit-transform: translateX(10px);
  transform: translateX(10px);
}

/* Bubble Bottom */
.hvr-bubble-bottom {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-bubble-bottom:before {
  pointer-events: none;
  position: absolute;
  z-index: -1;
  content: '';
  border-style: solid;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  left: calc(50% - 10px);
  bottom: 0;
  border-width: 10px 10px 0 10px;
  border-color: #e1e1e1 transparent transparent transparent;
}
.hvr-bubble-bottom:hover:before, .hvr-bubble-bottom:focus:before, .hvr-bubble-bottom:active:before {
  -webkit-transform: translateY(10px);
  transform: translateY(10px);
}

/* Bubble Left */
.hvr-bubble-left {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-bubble-left:before {
  pointer-events: none;
  position: absolute;
  z-index: -1;
  content: '';
  border-style: solid;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  top: calc(50% - 10px);
  left: 0;
  border-width: 10px 10px 10px 0;
  border-color: transparent #e1e1e1 transparent transparent;
}
.hvr-bubble-left:hover:before, .hvr-bubble-left:focus:before, .hvr-bubble-left:active:before {
  -webkit-transform: translateX(-10px);
  transform: translateX(-10px);
}

/* Bubble Float Top */
.hvr-bubble-float-top {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-bubble-float-top:before {
  position: absolute;
  z-index: -1;
  content: '';
  left: calc(50% - 10px);
  top: 0;
  border-style: solid;
  border-width: 0 10px 10px 10px;
  border-color: transparent transparent #e1e1e1 transparent;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-bubble-float-top:hover, .hvr-bubble-float-top:focus, .hvr-bubble-float-top:active {
  -webkit-transform: translateY(10px);
  transform: translateY(10px);
}
.hvr-bubble-float-top:hover:before, .hvr-bubble-float-top:focus:before, .hvr-bubble-float-top:active:before {
  -webkit-transform: translateY(-10px);
  transform: translateY(-10px);
}

/* Bubble Float Right */
.hvr-bubble-float-right {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-bubble-float-right:before {
  position: absolute;
  z-index: -1;
  top: calc(50% - 10px);
  right: 0;
  content: '';
  border-style: solid;
  border-width: 10px 0 10px 10px;
  border-color: transparent transparent transparent #e1e1e1;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-bubble-float-right:hover, .hvr-bubble-float-right:focus, .hvr-bubble-float-right:active {
  -webkit-transform: translateX(-10px);
  transform: translateX(-10px);
}
.hvr-bubble-float-right:hover:before, .hvr-bubble-float-right:focus:before, .hvr-bubble-float-right:active:before {
  -webkit-transform: translateX(10px);
  transform: translateX(10px);
}

/* Bubble Float Bottom */
.hvr-bubble-float-bottom {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-bubble-float-bottom:before {
  position: absolute;
  z-index: -1;
  content: '';
  left: calc(50% - 10px);
  bottom: 0;
  border-style: solid;
  border-width: 10px 10px 0 10px;
  border-color: #e1e1e1 transparent transparent transparent;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-bubble-float-bottom:hover, .hvr-bubble-float-bottom:focus, .hvr-bubble-float-bottom:active {
  -webkit-transform: translateY(-10px);
  transform: translateY(-10px);
}
.hvr-bubble-float-bottom:hover:before, .hvr-bubble-float-bottom:focus:before, .hvr-bubble-float-bottom:active:before {
  -webkit-transform: translateY(10px);
  transform: translateY(10px);
}

/* Bubble Float Left */
.hvr-bubble-float-left {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-bubble-float-left:before {
  position: absolute;
  z-index: -1;
  content: '';
  top: calc(50% - 10px);
  left: 0;
  border-style: solid;
  border-width: 10px 10px 10px 0;
  border-color: transparent #e1e1e1 transparent transparent;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
}
.hvr-bubble-float-left:hover, .hvr-bubble-float-left:focus, .hvr-bubble-float-left:active {
  -webkit-transform: translateX(10px);
  transform: translateX(10px);
}
.hvr-bubble-float-left:hover:before, .hvr-bubble-float-left:focus:before, .hvr-bubble-float-left:active:before {
  -webkit-transform: translateX(-10px);
  transform: translateX(-10px);
}

/* ICONS */
/* Icon Back */
.hvr-icon-back {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-left: 2.2em;
  -webkit-transition-duration: 0.1s;
  transition-duration: 0.1s;
}
.hvr-icon-back:before {
  content: "\f137";
  position: absolute;
  left: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.1s;
  transition-duration: 0.1s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-back:hover:before, .hvr-icon-back:focus:before, .hvr-icon-back:active:before {
  -webkit-transform: translateX(-4px);
  transform: translateX(-4px);
}

/* Icon Forward */
.hvr-icon-forward {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.1s;
  transition-duration: 0.1s;
}
.hvr-icon-forward:before {
  content: "\f138";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.1s;
  transition-duration: 0.1s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-forward:hover:before, .hvr-icon-forward:focus:before, .hvr-icon-forward:active:before {
  -webkit-transform: translateX(4px);
  transform: translateX(4px);
}

/* Icon Down */
@-webkit-keyframes hvr-icon-down {
  0%,
  50%,
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }

  25%,
  75% {
    -webkit-transform: translateY(6px);
    transform: translateY(6px);
  }
}

@keyframes hvr-icon-down {
  0%,
  50%,
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }

  25%,
  75% {
    -webkit-transform: translateY(6px);
    transform: translateY(6px);
  }
}

/* Icon Down */
.hvr-icon-down {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
}
.hvr-icon-down:before {
  content: "\f01a";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}
.hvr-icon-down:hover:before, .hvr-icon-down:focus:before, .hvr-icon-down:active:before {
  -webkit-animation-name: hvr-icon-down;
  animation-name: hvr-icon-down;
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-timing-function: ease-out;
  animation-timing-function: ease-out;
}

/* Icon Up */
@-webkit-keyframes hvr-icon-up {
  0%,
  50%,
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }

  25%,
  75% {
    -webkit-transform: translateY(-6px);
    transform: translateY(-6px);
  }
}

@keyframes hvr-icon-up {
  0%,
  50%,
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }

  25%,
  75% {
    -webkit-transform: translateY(-6px);
    transform: translateY(-6px);
  }
}

/* Icon Up */
.hvr-icon-up {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
}
.hvr-icon-up:before {
  content: "\f01b";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}
.hvr-icon-up:hover:before, .hvr-icon-up:focus:before, .hvr-icon-up:active:before {
  -webkit-animation-name: hvr-icon-up;
  animation-name: hvr-icon-up;
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-timing-function: ease-out;
  animation-timing-function: ease-out;
}

/* Icon Spin */
.hvr-icon-spin {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
}
.hvr-icon-spin:before {
  content: "\f021";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transition-duration: 1s;
  transition-duration: 1s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-in-out;
  transition-timing-function: ease-in-out;
}
.hvr-icon-spin:hover:before, .hvr-icon-spin:focus:before, .hvr-icon-spin:active:before {
  -webkit-transform: rotate(360deg);
  transform: rotate(360deg);
}

/* Icon Drop */
@-webkit-keyframes hvr-icon-drop {
  0% {
    opacity: 0;
  }

  50% {
    opacity: 0;
    -webkit-transform: translateY(-100%);
    transform: translateY(-100%);
  }

  51%,
  100% {
    opacity: 1;
  }
}

@keyframes hvr-icon-drop {
  0% {
    opacity: 0;
  }

  50% {
    opacity: 0;
    -webkit-transform: translateY(-100%);
    transform: translateY(-100%);
  }

  51%,
  100% {
    opacity: 1;
  }
}

/* Icon Drop */
.hvr-icon-drop {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
}
.hvr-icon-drop:before {
  content: "\f041";
  position: absolute;
  right: 1em;
  opacity: 1;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}
.hvr-icon-drop:hover:before, .hvr-icon-drop:focus:before, .hvr-icon-drop:active:before {
  opacity: 0;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-animation-name: hvr-icon-drop;
  animation-name: hvr-icon-drop;
  -webkit-animation-duration: 0.5s;
  animation-duration: 0.5s;
  -webkit-animation-delay: 0.3s;
  animation-delay: 0.3s;
  -webkit-animation-fill-mode: forwards;
  animation-fill-mode: forwards;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-timing-function: cubic-bezier(0.52, 1.64, 0.37, 0.66);
  animation-timing-function: cubic-bezier(0.52, 1.64, 0.37, 0.66);
}

/* Icon Fade */
.hvr-icon-fade {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
}
.hvr-icon-fade:before {
  content: "\f00c";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.5s;
  transition-duration: 0.5s;
  -webkit-transition-property: color;
  transition-property: color;
}
.hvr-icon-fade:hover:before, .hvr-icon-fade:focus:before, .hvr-icon-fade:active:before {
  color: #0F9E5E;
}

/* Icon Float Away */
@-webkit-keyframes hvr-icon-float-away {
  0% {
    opacity: 1;
  }

  100% {
    opacity: 0;
    -webkit-transform: translateY(-1em);
    transform: translateY(-1em);
  }
}

@keyframes hvr-icon-float-away {
  0% {
    opacity: 1;
  }

  100% {
    opacity: 0;
    -webkit-transform: translateY(-1em);
    transform: translateY(-1em);
  }
}

/* Icon Float Away */
.hvr-icon-float-away {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
}
.hvr-icon-float-away:before, .hvr-icon-float-away:after {
  content: "\f055";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
}
.hvr-icon-float-away:after {
  opacity: 0;
  -webkit-animation-duration: 0.5s;
  animation-duration: 0.5s;
  -webkit-animation-fill-mode: forwards;
  animation-fill-mode: forwards;
}
.hvr-icon-float-away:hover:after, .hvr-icon-float-away:focus:after, .hvr-icon-float-away:active:after {
  -webkit-animation-name: hvr-icon-float-away;
  animation-name: hvr-icon-float-away;
  -webkit-animation-timing-function: ease-out;
  animation-timing-function: ease-out;
}

/* Icon Sink Away */
@-webkit-keyframes hvr-icon-sink-away {
  0% {
    opacity: 1;
  }

  100% {
    opacity: 0;
    -webkit-transform: translateY(1em);
    transform: translateY(1em);
  }
}

@keyframes hvr-icon-sink-away {
  0% {
    opacity: 1;
  }

  100% {
    opacity: 0;
    -webkit-transform: translateY(1em);
    transform: translateY(1em);
  }
}

/* Icon Sink Away */
.hvr-icon-sink-away {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
}
.hvr-icon-sink-away:before, .hvr-icon-sink-away:after {
  content: "\f056";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}
.hvr-icon-sink-away:after {
  opacity: 0;
  -webkit-animation-duration: 0.5s;
  animation-duration: 0.5s;
  -webkit-animation-fill-mode: forwards;
  animation-fill-mode: forwards;
}
.hvr-icon-sink-away:hover:after, .hvr-icon-sink-away:focus:after, .hvr-icon-sink-away:active:after {
  -webkit-animation-name: hvr-icon-sink-away;
  animation-name: hvr-icon-sink-away;
  -webkit-animation-timing-function: ease-out;
  animation-timing-function: ease-out;
}

/* Icon Grow */
.hvr-icon-grow {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-grow:before {
  content: "\f118";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-grow:hover:before, .hvr-icon-grow:focus:before, .hvr-icon-grow:active:before {
  -webkit-transform: scale(1.3) translateZ(0);
  transform: scale(1.3) translateZ(0);
}

/* Icon Shrink */
.hvr-icon-shrink {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-shrink:before {
  content: "\f119";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-shrink:hover:before, .hvr-icon-shrink:focus:before, .hvr-icon-shrink:active:before {
  -webkit-transform: scale(0.8);
  transform: scale(0.8);
}

/* Icon Pulse */
@-webkit-keyframes hvr-icon-pulse {
  25% {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }

  75% {
    -webkit-transform: scale(0.8);
    transform: scale(0.8);
  }
}

@keyframes hvr-icon-pulse {
  25% {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }

  75% {
    -webkit-transform: scale(0.8);
    transform: scale(0.8);
  }
}

.hvr-icon-pulse {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
}
.hvr-icon-pulse:before {
  content: "\f015";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-pulse:hover:before, .hvr-icon-pulse:focus:before, .hvr-icon-pulse:active:before {
  -webkit-animation-name: hvr-icon-pulse;
  animation-name: hvr-icon-pulse;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
}

/* Icon Pulse Grow */
@-webkit-keyframes hvr-icon-pulse-grow {
  to {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }
}

@keyframes hvr-icon-pulse-grow {
  to {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }
}

.hvr-icon-pulse-grow {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
}
.hvr-icon-pulse-grow:before {
  content: "\f015";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-pulse-grow:hover:before, .hvr-icon-pulse-grow:focus:before, .hvr-icon-pulse-grow:active:before {
  -webkit-animation-name: hvr-icon-pulse-grow;
  animation-name: hvr-icon-pulse-grow;
  -webkit-animation-duration: 0.3s;
  animation-duration: 0.3s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
  -webkit-animation-direction: alternate;
  animation-direction: alternate;
}

/* Icon Pulse Shrink */
@-webkit-keyframes hvr-icon-pulse-shrink {
  to {
    -webkit-transform: scale(0.8);
    transform: scale(0.8);
  }
}

@keyframes hvr-icon-pulse-shrink {
  to {
    -webkit-transform: scale(0.8);
    transform: scale(0.8);
  }
}

.hvr-icon-pulse-shrink {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
}
.hvr-icon-pulse-shrink:before {
  content: "\f015";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-pulse-shrink:hover:before, .hvr-icon-pulse-shrink:focus:before, .hvr-icon-pulse-shrink:active:before {
  -webkit-animation-name: hvr-icon-pulse-shrink;
  animation-name: hvr-icon-pulse-shrink;
  -webkit-animation-duration: 0.3s;
  animation-duration: 0.3s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
  -webkit-animation-direction: alternate;
  animation-direction: alternate;
}

/* Icon Push */
@-webkit-keyframes hvr-icon-push {
  50% {
    -webkit-transform: scale(0.5);
    transform: scale(0.5);
  }
}

@keyframes hvr-icon-push {
  50% {
    -webkit-transform: scale(0.5);
    transform: scale(0.5);
  }
}

.hvr-icon-push {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-push:before {
  content: "\f006";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-push:hover:before, .hvr-icon-push:focus:before, .hvr-icon-push:active:before {
  -webkit-animation-name: hvr-icon-push;
  animation-name: hvr-icon-push;
  -webkit-animation-duration: 0.3s;
  animation-duration: 0.3s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Icon Pop */
@-webkit-keyframes hvr-icon-pop {
  50% {
    -webkit-transform: scale(1.5);
    transform: scale(1.5);
  }
}

@keyframes hvr-icon-pop {
  50% {
    -webkit-transform: scale(1.5);
    transform: scale(1.5);
  }
}

.hvr-icon-pop {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-pop:before {
  content: "\f005";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-pop:hover:before, .hvr-icon-pop:focus:before, .hvr-icon-pop:active:before {
  -webkit-animation-name: hvr-icon-pop;
  animation-name: hvr-icon-pop;
  -webkit-animation-duration: 0.3s;
  animation-duration: 0.3s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Icon Bounce */
.hvr-icon-bounce {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-bounce:before {
  content: "\f087";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-bounce:hover:before, .hvr-icon-bounce:focus:before, .hvr-icon-bounce:active:before {
  -webkit-transform: scale(1.5);
  transform: scale(1.5);
  -webkit-transition-timing-function: cubic-bezier(0.47, 2.02, 0.31, -0.36);
  transition-timing-function: cubic-bezier(0.47, 2.02, 0.31, -0.36);
}

/* Icon Rotate */
.hvr-icon-rotate {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-rotate:before {
  content: "\f0c6";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-rotate:hover:before, .hvr-icon-rotate:focus:before, .hvr-icon-rotate:active:before {
  -webkit-transform: rotate(20deg);
  transform: rotate(20deg);
}

/* Icon Grow Rotate */
.hvr-icon-grow-rotate {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-grow-rotate:before {
  content: "\f095";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-grow-rotate:hover:before, .hvr-icon-grow-rotate:focus:before, .hvr-icon-grow-rotate:active:before {
  -webkit-transform: scale(1.5) rotate(12deg);
  transform: scale(1.5) rotate(12deg);
}

/* Icon Float */
.hvr-icon-float {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-float:before {
  content: "\f01b";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-float:hover:before, .hvr-icon-float:focus:before, .hvr-icon-float:active:before {
  -webkit-transform: translateY(-4px);
  transform: translateY(-4px);
}

/* Icon Sink */
.hvr-icon-sink {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-sink:before {
  content: "\f01a";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: transform;
  transition-property: transform;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}
.hvr-icon-sink:hover:before, .hvr-icon-sink:focus:before, .hvr-icon-sink:active:before {
  -webkit-transform: translateY(4px);
  transform: translateY(4px);
}

/* Icon Bob */
@-webkit-keyframes hvr-icon-bob {
  0% {
    -webkit-transform: translateY(-6px);
    transform: translateY(-6px);
  }

  50% {
    -webkit-transform: translateY(-2px);
    transform: translateY(-2px);
  }

  100% {
    -webkit-transform: translateY(-6px);
    transform: translateY(-6px);
  }
}

@keyframes hvr-icon-bob {
  0% {
    -webkit-transform: translateY(-6px);
    transform: translateY(-6px);
  }

  50% {
    -webkit-transform: translateY(-2px);
    transform: translateY(-2px);
  }

  100% {
    -webkit-transform: translateY(-6px);
    transform: translateY(-6px);
  }
}

@-webkit-keyframes hvr-icon-bob-float {
  100% {
    -webkit-transform: translateY(-6px);
    transform: translateY(-6px);
  }
}

@keyframes hvr-icon-bob-float {
  100% {
    -webkit-transform: translateY(-6px);
    transform: translateY(-6px);
  }
}

.hvr-icon-bob {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-bob:before {
  content: "\f077";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}
.hvr-icon-bob:hover:before, .hvr-icon-bob:focus:before, .hvr-icon-bob:active:before {
  -webkit-animation-name: hvr-icon-bob-float, hvr-icon-bob;
  animation-name: hvr-icon-bob-float, hvr-icon-bob;
  -webkit-animation-duration: .3s, 1.5s;
  animation-duration: .3s, 1.5s;
  -webkit-animation-delay: 0s, .3s;
  animation-delay: 0s, .3s;
  -webkit-animation-timing-function: ease-out, ease-in-out;
  animation-timing-function: ease-out, ease-in-out;
  -webkit-animation-iteration-count: 1, infinite;
  animation-iteration-count: 1, infinite;
  -webkit-animation-fill-mode: forwards;
  animation-fill-mode: forwards;
  -webkit-animation-direction: normal, alternate;
  animation-direction: normal, alternate;
}

/* Icon Hang */
@-webkit-keyframes hvr-icon-hang {
  0% {
    -webkit-transform: translateY(6px);
    transform: translateY(6px);
  }

  50% {
    -webkit-transform: translateY(2px);
    transform: translateY(2px);
  }

  100% {
    -webkit-transform: translateY(6px);
    transform: translateY(6px);
  }
}

@keyframes hvr-icon-hang {
  0% {
    -webkit-transform: translateY(6px);
    transform: translateY(6px);
  }

  50% {
    -webkit-transform: translateY(2px);
    transform: translateY(2px);
  }

  100% {
    -webkit-transform: translateY(6px);
    transform: translateY(6px);
  }
}

@-webkit-keyframes hvr-icon-hang-sink {
  100% {
    -webkit-transform: translateY(6px);
    transform: translateY(6px);
  }
}

@keyframes hvr-icon-hang-sink {
  100% {
    -webkit-transform: translateY(6px);
    transform: translateY(6px);
  }
}

.hvr-icon-hang {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-hang:before {
  content: "\f078";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}
.hvr-icon-hang:hover:before, .hvr-icon-hang:focus:before, .hvr-icon-hang:active:before {
  -webkit-animation-name: hvr-icon-hang-sink, hvr-icon-hang;
  animation-name: hvr-icon-hang-sink, hvr-icon-hang;
  -webkit-animation-duration: .3s, 1.5s;
  animation-duration: .3s, 1.5s;
  -webkit-animation-delay: 0s, .3s;
  animation-delay: 0s, .3s;
  -webkit-animation-timing-function: ease-out, ease-in-out;
  animation-timing-function: ease-out, ease-in-out;
  -webkit-animation-iteration-count: 1, infinite;
  animation-iteration-count: 1, infinite;
  -webkit-animation-fill-mode: forwards;
  animation-fill-mode: forwards;
  -webkit-animation-direction: normal, alternate;
  animation-direction: normal, alternate;
}

/* Icon Wobble Horizontal */
@-webkit-keyframes hvr-icon-wobble-horizontal {
  16.65% {
    -webkit-transform: translateX(6px);
    transform: translateX(6px);
  }

  33.3% {
    -webkit-transform: translateX(-5px);
    transform: translateX(-5px);
  }

  49.95% {
    -webkit-transform: translateX(4px);
    transform: translateX(4px);
  }

  66.6% {
    -webkit-transform: translateX(-2px);
    transform: translateX(-2px);
  }

  83.25% {
    -webkit-transform: translateX(1px);
    transform: translateX(1px);
  }

  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes hvr-icon-wobble-horizontal {
  16.65% {
    -webkit-transform: translateX(6px);
    transform: translateX(6px);
  }

  33.3% {
    -webkit-transform: translateX(-5px);
    transform: translateX(-5px);
  }

  49.95% {
    -webkit-transform: translateX(4px);
    transform: translateX(4px);
  }

  66.6% {
    -webkit-transform: translateX(-2px);
    transform: translateX(-2px);
  }

  83.25% {
    -webkit-transform: translateX(1px);
    transform: translateX(1px);
  }

  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

.hvr-icon-wobble-horizontal {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-wobble-horizontal:before {
  content: "\f061";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}
.hvr-icon-wobble-horizontal:hover:before, .hvr-icon-wobble-horizontal:focus:before, .hvr-icon-wobble-horizontal:active:before {
  -webkit-animation-name: hvr-icon-wobble-horizontal;
  animation-name: hvr-icon-wobble-horizontal;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Icon Wobble Vertical */
@-webkit-keyframes hvr-icon-wobble-vertical {
  16.65% {
    -webkit-transform: translateY(6px);
    transform: translateY(6px);
  }

  33.3% {
    -webkit-transform: translateY(-5px);
    transform: translateY(-5px);
  }

  49.95% {
    -webkit-transform: translateY(4px);
    transform: translateY(4px);
  }

  66.6% {
    -webkit-transform: translateY(-2px);
    transform: translateY(-2px);
  }

  83.25% {
    -webkit-transform: translateY(1px);
    transform: translateY(1px);
  }

  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

@keyframes hvr-icon-wobble-vertical {
  16.65% {
    -webkit-transform: translateY(6px);
    transform: translateY(6px);
  }

  33.3% {
    -webkit-transform: translateY(-5px);
    transform: translateY(-5px);
  }

  49.95% {
    -webkit-transform: translateY(4px);
    transform: translateY(4px);
  }

  66.6% {
    -webkit-transform: translateY(-2px);
    transform: translateY(-2px);
  }

  83.25% {
    -webkit-transform: translateY(1px);
    transform: translateY(1px);
  }

  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

.hvr-icon-wobble-vertical {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-wobble-vertical:before {
  content: "\f062";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}
.hvr-icon-wobble-vertical:hover:before, .hvr-icon-wobble-vertical:focus:before, .hvr-icon-wobble-vertical:active:before {
  -webkit-animation-name: hvr-icon-wobble-vertical;
  animation-name: hvr-icon-wobble-vertical;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* Icon Buzz */
@-webkit-keyframes hvr-icon-buzz {
  50% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  100% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }
}

@keyframes hvr-icon-buzz {
  50% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  100% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }
}

.hvr-icon-buzz {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-buzz:before {
  content: "\f017";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}
.hvr-icon-buzz:hover:before, .hvr-icon-buzz:focus:before, .hvr-icon-buzz:active:before {
  -webkit-animation-name: hvr-icon-buzz;
  animation-name: hvr-icon-buzz;
  -webkit-animation-duration: 0.15s;
  animation-duration: 0.15s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
}

/* Icon Buzz Out */
@-webkit-keyframes hvr-icon-buzz-out {
  10% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  20% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }

  30% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  40% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }

  50% {
    -webkit-transform: translateX(2px) rotate(1deg);
    transform: translateX(2px) rotate(1deg);
  }

  60% {
    -webkit-transform: translateX(-2px) rotate(-1deg);
    transform: translateX(-2px) rotate(-1deg);
  }

  70% {
    -webkit-transform: translateX(2px) rotate(1deg);
    transform: translateX(2px) rotate(1deg);
  }

  80% {
    -webkit-transform: translateX(-2px) rotate(-1deg);
    transform: translateX(-2px) rotate(-1deg);
  }

  90% {
    -webkit-transform: translateX(1px) rotate(0);
    transform: translateX(1px) rotate(0);
  }

  100% {
    -webkit-transform: translateX(-1px) rotate(0);
    transform: translateX(-1px) rotate(0);
  }
}

@keyframes hvr-icon-buzz-out {
  10% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  20% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }

  30% {
    -webkit-transform: translateX(3px) rotate(2deg);
    transform: translateX(3px) rotate(2deg);
  }

  40% {
    -webkit-transform: translateX(-3px) rotate(-2deg);
    transform: translateX(-3px) rotate(-2deg);
  }

  50% {
    -webkit-transform: translateX(2px) rotate(1deg);
    transform: translateX(2px) rotate(1deg);
  }

  60% {
    -webkit-transform: translateX(-2px) rotate(-1deg);
    transform: translateX(-2px) rotate(-1deg);
  }

  70% {
    -webkit-transform: translateX(2px) rotate(1deg);
    transform: translateX(2px) rotate(1deg);
  }

  80% {
    -webkit-transform: translateX(-2px) rotate(-1deg);
    transform: translateX(-2px) rotate(-1deg);
  }

  90% {
    -webkit-transform: translateX(1px) rotate(0);
    transform: translateX(1px) rotate(0);
  }

  100% {
    -webkit-transform: translateX(-1px) rotate(0);
    transform: translateX(-1px) rotate(0);
  }
}

.hvr-icon-buzz-out {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
  padding-right: 2.2em;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
}
.hvr-icon-buzz-out:before {
  content: "\f023";
  position: absolute;
  right: 1em;
  padding: 0 1px;
  font-family: FontAwesome;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}
.hvr-icon-buzz-out:hover:before, .hvr-icon-buzz-out:focus:before, .hvr-icon-buzz-out:active:before {
  -webkit-animation-name: hvr-icon-buzz-out;
  animation-name: hvr-icon-buzz-out;
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-timing-function: linear;
  animation-timing-function: linear;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
}

/* CURLS */
/* Curl Top Left */
.hvr-curl-top-left {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-curl-top-left:before {
  pointer-events: none;
  position: absolute;
  content: '';
  height: 0;
  width: 0;
  top: 0;
  left: 0;
  background: white;
  /* IE9 */
  background: linear-gradient(135deg, white 45%, #aaaaaa 50%, #cccccc 56%, white 80%);
  filter: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#ffffff', endColorstr='#000000');
  /*For IE7-8-9*/
  z-index: 1000;
  box-shadow: 1px 1px 1px rgba(0, 0, 0, 0.4);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: width, height;
  transition-property: width, height;
}
.hvr-curl-top-left:hover:before, .hvr-curl-top-left:focus:before, .hvr-curl-top-left:active:before {
  width: 25px;
  height: 25px;
}

/* Curl Top Right */
.hvr-curl-top-right {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-curl-top-right:before {
  pointer-events: none;
  position: absolute;
  content: '';
  height: 0;
  width: 0;
  top: 0;
  right: 0;
  background: white;
  /* IE9 */
  background: linear-gradient(225deg, white 45%, #aaaaaa 50%, #cccccc 56%, white 80%);
  box-shadow: -1px 1px 1px rgba(0, 0, 0, 0.4);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: width, height;
  transition-property: width, height;
}
.hvr-curl-top-right:hover:before, .hvr-curl-top-right:focus:before, .hvr-curl-top-right:active:before {
  width: 25px;
  height: 25px;
}

/* Curl Bottom Right */
.hvr-curl-bottom-right {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}
.hvr-curl-bottom-right:before {
  pointer-events: none;
  position: absolute;
  content: '';
  height: 0;
  width: 0;
  bottom: 0;
  right: 0;
  background: white;
  /* IE9 */
  background: linear-gradient(315deg, white 45%, #aaaaaa 50%, #cccccc 56%, white 80%);
  box-shadow: -1px -1px 1px rgba(0, 0, 0, 0.4);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: width, height;
  transition-property: width, height;
}
.hvr-curl-bottom-right:hover:before, .hvr-curl-bottom-right:focus:before, .hvr-curl-bottom-right:active:before {
  width: 25px;
  height: 25px;
}

/* Curl Bottom Left */
.hvr-curl-bottom-left {
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  box-shadow: 0 0 1px rgba(0, 0, 0, 0);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -moz-osx-font-smoothing: grayscale;
  position: relative;
}

.hvr-curl-bottom-left:before {
  pointer-events: none;
  position: absolute;
  content: '';
  height: 0;
  width: 0;
  bottom: 0;
  left: 0;
  background: white;
  /* IE9 */
  background: linear-gradient(45deg, white 45%, #aaaaaa 50%, #cccccc 56%, white 80%);
  box-shadow: 1px -1px 1px rgba(0, 0, 0, 0.4);
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-property: width, height;
  transition-property: width, height;
}
.hvr-curl-bottom-left:hover:before, .hvr-curl-bottom-left:focus:before, .hvr-curl-bottom-left:active:before {
  width: 25px;
  height: 25px;
}
.mCustomScrollbar{-ms-touch-action:pinch-zoom;touch-action:pinch-zoom}.mCustomScrollbar.mCS_no_scrollbar,.mCustomScrollbar.mCS_touch_action{-ms-touch-action:auto;touch-action:auto}.mCustomScrollBox{position:relative;overflow:hidden;height:100%;max-width:100%;outline:0;direction:ltr}.mCSB_container{overflow:hidden;width:auto;height:auto}.mCSB_inside>.mCSB_container{margin-right:30px}.mCSB_container.mCS_no_scrollbar_y.mCS_y_hidden{margin-right:0}.mCS-dir-rtl>.mCSB_inside>.mCSB_container{margin-right:0;margin-left:30px}.mCS-dir-rtl>.mCSB_inside>.mCSB_container.mCS_no_scrollbar_y.mCS_y_hidden{margin-left:0}.mCSB_scrollTools{position:absolute;width:16px;height:auto;left:auto;top:0;right:0;bottom:0;opacity:.75;filter:"alpha(opacity=75)";-ms-filter:"alpha(opacity=75)"}.mCSB_outside+.mCSB_scrollTools{right:-26px}.mCS-dir-rtl>.mCSB_inside>.mCSB_scrollTools,.mCS-dir-rtl>.mCSB_outside+.mCSB_scrollTools{right:auto;left:0}.mCS-dir-rtl>.mCSB_outside+.mCSB_scrollTools{left:-26px}.mCSB_scrollTools .mCSB_draggerContainer{position:absolute;top:0;left:0;bottom:0;right:0;height:auto}.mCSB_scrollTools a+.mCSB_draggerContainer{margin:20px 0}.mCSB_scrollTools .mCSB_draggerRail{width:2px;height:100%;margin:0 auto;-webkit-border-radius:16px;-moz-border-radius:16px;border-radius:16px}.mCSB_scrollTools .mCSB_dragger{cursor:pointer;width:100%;height:30px;z-index:1}.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{position:relative;width:4px;height:100%;margin:0 auto;-webkit-border-radius:16px;-moz-border-radius:16px;border-radius:16px;text-align:center}.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar{width:12px}.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{width:8px}.mCSB_scrollTools .mCSB_buttonDown,.mCSB_scrollTools .mCSB_buttonUp{display:block;position:absolute;height:20px;width:100%;overflow:hidden;margin:0 auto;cursor:pointer}.mCSB_scrollTools .mCSB_buttonDown{bottom:0}.mCSB_horizontal.mCSB_inside>.mCSB_container{margin-right:0;margin-bottom:30px}.mCSB_horizontal.mCSB_outside>.mCSB_container{min-height:100%}.mCSB_horizontal>.mCSB_container.mCS_no_scrollbar_x.mCS_x_hidden{margin-bottom:0}.mCSB_scrollTools.mCSB_scrollTools_horizontal{width:auto;height:16px;top:auto;right:0;bottom:0;left:0}.mCustomScrollBox+.mCSB_scrollTools+.mCSB_scrollTools.mCSB_scrollTools_horizontal,.mCustomScrollBox+.mCSB_scrollTools.mCSB_scrollTools_horizontal{bottom:-26px}.mCSB_scrollTools.mCSB_scrollTools_horizontal a+.mCSB_draggerContainer{margin:0 20px}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:2px;margin:7px 0}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_dragger{width:30px;height:100%;left:0}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{width:100%;height:4px;margin:6px auto}.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar{height:12px;margin:2px auto}.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{height:8px;margin:4px 0}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_buttonLeft,.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_buttonRight{display:block;position:absolute;width:20px;height:100%;overflow:hidden;margin:0 auto;cursor:pointer}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_buttonLeft{left:0}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_buttonRight{right:0}.mCSB_container_wrapper{position:absolute;height:auto;width:auto;overflow:hidden;top:0;left:0;right:0;bottom:0;margin-right:30px;margin-bottom:30px}.mCSB_container_wrapper>.mCSB_container{padding-right:30px;padding-bottom:30px;-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}.mCSB_vertical_horizontal>.mCSB_scrollTools.mCSB_scrollTools_vertical{bottom:20px}.mCSB_vertical_horizontal>.mCSB_scrollTools.mCSB_scrollTools_horizontal{right:20px}.mCSB_container_wrapper.mCS_no_scrollbar_x.mCS_x_hidden+.mCSB_scrollTools.mCSB_scrollTools_vertical{bottom:0}.mCS-dir-rtl>.mCustomScrollBox.mCSB_vertical_horizontal.mCSB_inside>.mCSB_scrollTools.mCSB_scrollTools_horizontal,.mCSB_container_wrapper.mCS_no_scrollbar_y.mCS_y_hidden+.mCSB_scrollTools~.mCSB_scrollTools.mCSB_scrollTools_horizontal{right:0}.mCS-dir-rtl>.mCustomScrollBox.mCSB_vertical_horizontal.mCSB_inside>.mCSB_scrollTools.mCSB_scrollTools_horizontal{left:20px}.mCS-dir-rtl>.mCustomScrollBox.mCSB_vertical_horizontal.mCSB_inside>.mCSB_container_wrapper.mCS_no_scrollbar_y.mCS_y_hidden+.mCSB_scrollTools~.mCSB_scrollTools.mCSB_scrollTools_horizontal{left:0}.mCS-dir-rtl>.mCSB_inside>.mCSB_container_wrapper{margin-right:0;margin-left:30px}.mCSB_container_wrapper.mCS_no_scrollbar_y.mCS_y_hidden>.mCSB_container{padding-right:0}.mCSB_container_wrapper.mCS_no_scrollbar_x.mCS_x_hidden>.mCSB_container{padding-bottom:0}.mCustomScrollBox.mCSB_vertical_horizontal.mCSB_inside>.mCSB_container_wrapper.mCS_no_scrollbar_y.mCS_y_hidden{margin-right:0;margin-left:0}.mCustomScrollBox.mCSB_vertical_horizontal.mCSB_inside>.mCSB_container_wrapper.mCS_no_scrollbar_x.mCS_x_hidden{margin-bottom:0}.mCSB_scrollTools,.mCSB_scrollTools .mCSB_buttonDown,.mCSB_scrollTools .mCSB_buttonLeft,.mCSB_scrollTools .mCSB_buttonRight,.mCSB_scrollTools .mCSB_buttonUp,.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{-webkit-transition:opacity .2s ease-in-out,background-color .2s ease-in-out;-moz-transition:opacity .2s ease-in-out,background-color .2s ease-in-out;-o-transition:opacity .2s ease-in-out,background-color .2s ease-in-out;transition:opacity .2s ease-in-out,background-color .2s ease-in-out}.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerRail,.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger_bar,.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerRail,.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger_bar{-webkit-transition:width .2s ease-out .2s,height .2s ease-out .2s,margin-left .2s ease-out .2s,margin-right .2s ease-out .2s,margin-top .2s ease-out .2s,margin-bottom .2s ease-out .2s,opacity .2s ease-in-out,background-color .2s ease-in-out;-moz-transition:width .2s ease-out .2s,height .2s ease-out .2s,margin-left .2s ease-out .2s,margin-right .2s ease-out .2s,margin-top .2s ease-out .2s,margin-bottom .2s ease-out .2s,opacity .2s ease-in-out,background-color .2s ease-in-out;-o-transition:width .2s ease-out .2s,height .2s ease-out .2s,margin-left .2s ease-out .2s,margin-right .2s ease-out .2s,margin-top .2s ease-out .2s,margin-bottom .2s ease-out .2s,opacity .2s ease-in-out,background-color .2s ease-in-out;transition:width .2s ease-out .2s,height .2s ease-out .2s,margin-left .2s ease-out .2s,margin-right .2s ease-out .2s,margin-top .2s ease-out .2s,margin-bottom .2s ease-out .2s,opacity .2s ease-in-out,background-color .2s ease-in-out}.mCS-autoHide>.mCustomScrollBox>.mCSB_scrollTools,.mCS-autoHide>.mCustomScrollBox~.mCSB_scrollTools{opacity:0;filter:"alpha(opacity=0)";-ms-filter:"alpha(opacity=0)"}.mCS-autoHide:hover>.mCustomScrollBox>.mCSB_scrollTools,.mCS-autoHide:hover>.mCustomScrollBox~.mCSB_scrollTools,.mCustomScrollBox:hover>.mCSB_scrollTools,.mCustomScrollBox:hover~.mCSB_scrollTools,.mCustomScrollbar>.mCustomScrollBox>.mCSB_scrollTools.mCSB_scrollTools_onDrag,.mCustomScrollbar>.mCustomScrollBox~.mCSB_scrollTools.mCSB_scrollTools_onDrag{opacity:1;filter:"alpha(opacity=100)";-ms-filter:"alpha(opacity=100)"}.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.4);filter:"alpha(opacity=40)";-ms-filter:"alpha(opacity=40)"}.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.75);filter:"alpha(opacity=75)";-ms-filter:"alpha(opacity=75)"}.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.85);filter:"alpha(opacity=85)";-ms-filter:"alpha(opacity=85)"}.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.9);filter:"alpha(opacity=90)";-ms-filter:"alpha(opacity=90)"}.mCSB_scrollTools .mCSB_buttonDown,.mCSB_scrollTools .mCSB_buttonLeft,.mCSB_scrollTools .mCSB_buttonRight,.mCSB_scrollTools .mCSB_buttonUp{background-image:url(mCSB_buttons.png);background-repeat:no-repeat;opacity:.4;filter:"alpha(opacity=40)";-ms-filter:"alpha(opacity=40)"}.mCSB_scrollTools .mCSB_buttonUp{background-position:0 0}.mCSB_scrollTools .mCSB_buttonDown{background-position:0 -20px}.mCSB_scrollTools .mCSB_buttonLeft{background-position:0 -40px}.mCSB_scrollTools .mCSB_buttonRight{background-position:0 -56px}.mCSB_scrollTools .mCSB_buttonDown:hover,.mCSB_scrollTools .mCSB_buttonLeft:hover,.mCSB_scrollTools .mCSB_buttonRight:hover,.mCSB_scrollTools .mCSB_buttonUp:hover{opacity:.75;filter:"alpha(opacity=75)";-ms-filter:"alpha(opacity=75)"}.mCSB_scrollTools .mCSB_buttonDown:active,.mCSB_scrollTools .mCSB_buttonLeft:active,.mCSB_scrollTools .mCSB_buttonRight:active,.mCSB_scrollTools .mCSB_buttonUp:active{opacity:.9;filter:"alpha(opacity=90)";-ms-filter:"alpha(opacity=90)"}.mCS-dark.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.15)}.mCS-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:rgba(0,0,0,.85)}.mCS-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:rgba(0,0,0,.9)}.mCS-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-80px 0}.mCS-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-80px -20px}.mCS-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-80px -40px}.mCS-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-80px -56px}.mCS-dark-2.mCSB_scrollTools .mCSB_draggerRail,.mCS-light-2.mCSB_scrollTools .mCSB_draggerRail{width:4px;background-color:#fff;background-color:rgba(255,255,255,.1);-webkit-border-radius:1px;-moz-border-radius:1px;border-radius:1px}.mCS-dark-2.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-light-2.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:4px;background-color:#fff;background-color:rgba(255,255,255,.75);-webkit-border-radius:1px;-moz-border-radius:1px;border-radius:1px}.mCS-dark-2.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-dark-2.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-light-2.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-light-2.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:4px;margin:6px auto}.mCS-light-2.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.85)}.mCS-light-2.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-light-2.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.9)}.mCS-light-2.mCSB_scrollTools .mCSB_buttonUp{background-position:-32px 0}.mCS-light-2.mCSB_scrollTools .mCSB_buttonDown{background-position:-32px -20px}.mCS-light-2.mCSB_scrollTools .mCSB_buttonLeft{background-position:-40px -40px}.mCS-light-2.mCSB_scrollTools .mCSB_buttonRight{background-position:-40px -56px}.mCS-dark-2.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.1);-webkit-border-radius:1px;-moz-border-radius:1px;border-radius:1px}.mCS-dark-2.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75);-webkit-border-radius:1px;-moz-border-radius:1px;border-radius:1px}.mCS-dark-2.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-dark-2.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-dark-2.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-dark-2.mCSB_scrollTools .mCSB_buttonUp{background-position:-112px 0}.mCS-dark-2.mCSB_scrollTools .mCSB_buttonDown{background-position:-112px -20px}.mCS-dark-2.mCSB_scrollTools .mCSB_buttonLeft{background-position:-120px -40px}.mCS-dark-2.mCSB_scrollTools .mCSB_buttonRight{background-position:-120px -56px}.mCS-dark-thick.mCSB_scrollTools .mCSB_draggerRail,.mCS-light-thick.mCSB_scrollTools .mCSB_draggerRail{width:4px;background-color:#fff;background-color:rgba(255,255,255,.1);-webkit-border-radius:2px;-moz-border-radius:2px;border-radius:2px}.mCS-dark-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-light-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:6px;background-color:#fff;background-color:rgba(255,255,255,.75);-webkit-border-radius:2px;-moz-border-radius:2px;border-radius:2px}.mCS-dark-thick.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-light-thick.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:4px;margin:6px 0}.mCS-dark-thick.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-light-thick.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{width:100%;height:6px;margin:5px auto}.mCS-light-thick.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.85)}.mCS-light-thick.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-light-thick.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.9)}.mCS-light-thick.mCSB_scrollTools .mCSB_buttonUp{background-position:-16px 0}.mCS-light-thick.mCSB_scrollTools .mCSB_buttonDown{background-position:-16px -20px}.mCS-light-thick.mCSB_scrollTools .mCSB_buttonLeft{background-position:-20px -40px}.mCS-light-thick.mCSB_scrollTools .mCSB_buttonRight{background-position:-20px -56px}.mCS-dark-thick.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.1);-webkit-border-radius:2px;-moz-border-radius:2px;border-radius:2px}.mCS-dark-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75);-webkit-border-radius:2px;-moz-border-radius:2px;border-radius:2px}.mCS-dark-thick.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-dark-thick.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-dark-thick.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-dark-thick.mCSB_scrollTools .mCSB_buttonUp{background-position:-96px 0}.mCS-dark-thick.mCSB_scrollTools .mCSB_buttonDown{background-position:-96px -20px}.mCS-dark-thick.mCSB_scrollTools .mCSB_buttonLeft{background-position:-100px -40px}.mCS-dark-thick.mCSB_scrollTools .mCSB_buttonRight{background-position:-100px -56px}.mCS-light-thin.mCSB_scrollTools .mCSB_draggerRail{background-color:#fff;background-color:rgba(255,255,255,.1)}.mCS-dark-thin.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-light-thin.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:2px}.mCS-dark-thin.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-light-thin.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%}.mCS-dark-thin.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-light-thin.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{width:100%;height:2px;margin:7px auto}.mCS-dark-thin.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.15)}.mCS-dark-thin.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-dark-thin.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-dark-thin.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-dark-thin.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-dark-thin.mCSB_scrollTools .mCSB_buttonUp{background-position:-80px 0}.mCS-dark-thin.mCSB_scrollTools .mCSB_buttonDown{background-position:-80px -20px}.mCS-dark-thin.mCSB_scrollTools .mCSB_buttonLeft{background-position:-80px -40px}.mCS-dark-thin.mCSB_scrollTools .mCSB_buttonRight{background-position:-80px -56px}.mCS-rounded.mCSB_scrollTools .mCSB_draggerRail{background-color:#fff;background-color:rgba(255,255,255,.15)}.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger,.mCS-rounded-dots.mCSB_scrollTools .mCSB_dragger,.mCS-rounded.mCSB_scrollTools .mCSB_dragger{height:14px}.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded-dots.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:14px;margin:0 1px}.mCS-rounded-dark.mCSB_scrollTools_horizontal .mCSB_dragger,.mCS-rounded-dots-dark.mCSB_scrollTools_horizontal .mCSB_dragger,.mCS-rounded-dots.mCSB_scrollTools_horizontal .mCSB_dragger,.mCS-rounded.mCSB_scrollTools_horizontal .mCSB_dragger{width:14px}.mCS-rounded-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded-dots.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{height:14px;margin:1px 0}.mCS-rounded-dark.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCS-rounded-dark.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar{width:16px;height:16px;margin:-1px 0}.mCS-rounded-dark.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-rounded-dark.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail,.mCS-rounded.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-rounded.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{width:4px}.mCS-rounded-dark.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCS-rounded-dark.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar{height:16px;width:16px;margin:0 -1px}.mCS-rounded-dark.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-rounded-dark.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail,.mCS-rounded.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-rounded.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{height:4px;margin:6px 0}.mCS-rounded.mCSB_scrollTools .mCSB_buttonUp{background-position:0 -72px}.mCS-rounded.mCSB_scrollTools .mCSB_buttonDown{background-position:0 -92px}.mCS-rounded.mCSB_scrollTools .mCSB_buttonLeft{background-position:0 -112px}.mCS-rounded.mCSB_scrollTools .mCSB_buttonRight{background-position:0 -128px}.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-rounded-dark.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.15)}.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-rounded-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-80px -72px}.mCS-rounded-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-80px -92px}.mCS-rounded-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-80px -112px}.mCS-rounded-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-80px -128px}.mCS-rounded-dots-dark.mCSB_scrollTools_vertical .mCSB_draggerRail,.mCS-rounded-dots.mCSB_scrollTools_vertical .mCSB_draggerRail{width:4px}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-rounded-dots-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-rounded-dots.mCSB_scrollTools .mCSB_draggerRail,.mCS-rounded-dots.mCSB_scrollTools_horizontal .mCSB_draggerRail{background-color:transparent;background-position:center}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-rounded-dots.mCSB_scrollTools .mCSB_draggerRail{background-image:url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAgAAAAICAYAAADED76LAAAANElEQVQYV2NkIAAYiVbw//9/Y6DiM1ANJoyMjGdBbLgJQAX/kU0DKgDLkaQAvxW4HEvQFwCRcxIJK1XznAAAAABJRU5ErkJggg==);background-repeat:repeat-y;opacity:.3;filter:"alpha(opacity=30)";-ms-filter:"alpha(opacity=30)"}.mCS-rounded-dots-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-rounded-dots.mCSB_scrollTools_horizontal .mCSB_draggerRail{height:4px;margin:6px 0;background-repeat:repeat-x}.mCS-rounded-dots.mCSB_scrollTools .mCSB_buttonUp{background-position:-16px -72px}.mCS-rounded-dots.mCSB_scrollTools .mCSB_buttonDown{background-position:-16px -92px}.mCS-rounded-dots.mCSB_scrollTools .mCSB_buttonLeft{background-position:-20px -112px}.mCS-rounded-dots.mCSB_scrollTools .mCSB_buttonRight{background-position:-20px -128px}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_draggerRail{background-image:url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAgAAAAICAYAAADED76LAAAALElEQVQYV2NkIAAYSVFgDFR8BqrBBEifBbGRTfiPZhpYjiQFBK3A6l6CvgAAE9kGCd1mvgEAAAAASUVORK5CYII=)}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-96px -72px}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-96px -92px}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-100px -112px}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-100px -128px}.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-repeat:repeat-y;background-image:-moz-linear-gradient(left,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-webkit-gradient(linear,left top,right top,color-stop(0,rgba(255,255,255,.5)),color-stop(100%,rgba(255,255,255,0)));background-image:-webkit-linear-gradient(left,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-o-linear-gradient(left,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-ms-linear-gradient(left,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:linear-gradient(to right,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%)}.mCS-3d-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{background-repeat:repeat-x;background-image:-moz-linear-gradient(top,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-webkit-gradient(linear,left top,left bottom,color-stop(0,rgba(255,255,255,.5)),color-stop(100%,rgba(255,255,255,0)));background-image:-webkit-linear-gradient(top,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-o-linear-gradient(top,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-ms-linear-gradient(top,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:linear-gradient(to bottom,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%)}.mCS-3d-dark.mCSB_scrollTools_vertical .mCSB_dragger,.mCS-3d.mCSB_scrollTools_vertical .mCSB_dragger{height:70px}.mCS-3d-dark.mCSB_scrollTools_horizontal .mCSB_dragger,.mCS-3d.mCSB_scrollTools_horizontal .mCSB_dragger{width:70px}.mCS-3d-dark.mCSB_scrollTools,.mCS-3d.mCSB_scrollTools{opacity:1;filter:"alpha(opacity=30)";-ms-filter:"alpha(opacity=30)"}.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-3d.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_draggerRail{-webkit-border-radius:16px;-moz-border-radius:16px;border-radius:16px}.mCS-3d-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-3d.mCSB_scrollTools .mCSB_draggerRail{width:8px;background-color:#000;background-color:rgba(0,0,0,.2);box-shadow:inset 1px 0 1px rgba(0,0,0,.5),inset -1px 0 1px rgba(255,255,255,.2)}.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#555}.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:8px}.mCS-3d-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-3d.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:8px;margin:4px 0;box-shadow:inset 0 1px 1px rgba(0,0,0,.5),inset 0 -1px 1px rgba(255,255,255,.2)}.mCS-3d-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{width:100%;height:8px;margin:4px auto}.mCS-3d.mCSB_scrollTools .mCSB_buttonUp{background-position:-32px -72px}.mCS-3d.mCSB_scrollTools .mCSB_buttonDown{background-position:-32px -92px}.mCS-3d.mCSB_scrollTools .mCSB_buttonLeft{background-position:-40px -112px}.mCS-3d.mCSB_scrollTools .mCSB_buttonRight{background-position:-40px -128px}.mCS-3d-dark.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.1);box-shadow:inset 1px 0 1px rgba(0,0,0,.1)}.mCS-3d-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail{box-shadow:inset 0 1px 1px rgba(0,0,0,.1)}.mCS-3d-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-112px -72px}.mCS-3d-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-112px -92px}.mCS-3d-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-120px -112px}.mCS-3d-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-120px -128px}.mCS-3d-thick-dark.mCSB_scrollTools,.mCS-3d-thick.mCSB_scrollTools{opacity:1;filter:"alpha(opacity=30)";-ms-filter:"alpha(opacity=30)"}.mCS-3d-thick-dark.mCSB_scrollTools,.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_draggerContainer,.mCS-3d-thick.mCSB_scrollTools,.mCS-3d-thick.mCSB_scrollTools .mCSB_draggerContainer{-webkit-border-radius:7px;-moz-border-radius:7px;border-radius:7px}.mCSB_inside+.mCS-3d-thick-dark.mCSB_scrollTools_vertical,.mCSB_inside+.mCS-3d-thick.mCSB_scrollTools_vertical{right:1px}.mCS-3d-thick-dark.mCSB_scrollTools_vertical,.mCS-3d-thick.mCSB_scrollTools_vertical{box-shadow:inset 1px 0 1px rgba(0,0,0,.1),inset 0 0 14px rgba(0,0,0,.5)}.mCS-3d-thick-dark.mCSB_scrollTools_horizontal,.mCS-3d-thick.mCSB_scrollTools_horizontal{bottom:1px;box-shadow:inset 0 1px 1px rgba(0,0,0,.1),inset 0 0 14px rgba(0,0,0,.5)}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{-webkit-border-radius:5px;-moz-border-radius:5px;border-radius:5px;box-shadow:inset 1px 0 0 rgba(255,255,255,.4);width:12px;margin:2px;position:absolute;height:auto;top:0;bottom:0;left:0;right:0}.mCS-3d-thick-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{box-shadow:inset 0 1px 0 rgba(255,255,255,.4);height:12px;width:auto}.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#555}.mCS-3d-thick.mCSB_scrollTools .mCSB_draggerContainer{background-color:#000;background-color:rgba(0,0,0,.05);box-shadow:inset 1px 1px 16px rgba(0,0,0,.1)}.mCS-3d-thick.mCSB_scrollTools .mCSB_draggerRail{background-color:transparent}.mCS-3d-thick.mCSB_scrollTools .mCSB_buttonUp{background-position:-32px -72px}.mCS-3d-thick.mCSB_scrollTools .mCSB_buttonDown{background-position:-32px -92px}.mCS-3d-thick.mCSB_scrollTools .mCSB_buttonLeft{background-position:-40px -112px}.mCS-3d-thick.mCSB_scrollTools .mCSB_buttonRight{background-position:-40px -128px}.mCS-3d-thick-dark.mCSB_scrollTools{box-shadow:inset 0 0 14px rgba(0,0,0,.2)}.mCS-3d-thick-dark.mCSB_scrollTools_horizontal{box-shadow:inset 0 1px 1px rgba(0,0,0,.1),inset 0 0 14px rgba(0,0,0,.2)}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{box-shadow:inset 1px 0 0 rgba(255,255,255,.4),inset -1px 0 0 rgba(0,0,0,.2)}.mCS-3d-thick-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{box-shadow:inset 0 1px 0 rgba(255,255,255,.4),inset 0 -1px 0 rgba(0,0,0,.2)}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#777}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_draggerContainer{background-color:#fff;background-color:rgba(0,0,0,.05);box-shadow:inset 1px 1px 16px rgba(0,0,0,.1)}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-minimal-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-minimal.mCSB_scrollTools .mCSB_draggerRail{background-color:transparent}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-112px -72px}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-112px -92px}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-120px -112px}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-120px -128px}.mCSB_outside+.mCS-minimal-dark.mCSB_scrollTools_vertical,.mCSB_outside+.mCS-minimal.mCSB_scrollTools_vertical{right:0;margin:12px 0}.mCustomScrollBox.mCS-minimal+.mCSB_scrollTools+.mCSB_scrollTools.mCSB_scrollTools_horizontal,.mCustomScrollBox.mCS-minimal+.mCSB_scrollTools.mCSB_scrollTools_horizontal,.mCustomScrollBox.mCS-minimal-dark+.mCSB_scrollTools+.mCSB_scrollTools.mCSB_scrollTools_horizontal,.mCustomScrollBox.mCS-minimal-dark+.mCSB_scrollTools.mCSB_scrollTools_horizontal{bottom:0;margin:0 12px}.mCS-dir-rtl>.mCSB_outside+.mCS-minimal-dark.mCSB_scrollTools_vertical,.mCS-dir-rtl>.mCSB_outside+.mCS-minimal.mCSB_scrollTools_vertical{left:0;right:auto}.mCS-minimal-dark.mCSB_scrollTools_vertical .mCSB_dragger,.mCS-minimal.mCSB_scrollTools_vertical .mCSB_dragger{height:50px}.mCS-minimal-dark.mCSB_scrollTools_horizontal .mCSB_dragger,.mCS-minimal.mCSB_scrollTools_horizontal .mCSB_dragger{width:50px}.mCS-minimal.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.2);filter:"alpha(opacity=20)";-ms-filter:"alpha(opacity=20)"}.mCS-minimal.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-minimal.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.5);filter:"alpha(opacity=50)";-ms-filter:"alpha(opacity=50)"}.mCS-minimal-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.2);filter:"alpha(opacity=20)";-ms-filter:"alpha(opacity=20)"}.mCS-minimal-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-minimal-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.5);filter:"alpha(opacity=50)";-ms-filter:"alpha(opacity=50)"}.mCS-dark-3.mCSB_scrollTools .mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools .mCSB_draggerRail{width:6px;background-color:#000;background-color:rgba(0,0,0,.2)}.mCS-dark-3.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-light-3.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:6px}.mCS-dark-3.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-dark-3.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-light-3.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:6px;margin:5px 0}.mCS-dark-3.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-dark-3.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{width:12px}.mCS-dark-3.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-dark-3.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{height:12px;margin:2px 0}.mCS-light-3.mCSB_scrollTools .mCSB_buttonUp{background-position:-32px -72px}.mCS-light-3.mCSB_scrollTools .mCSB_buttonDown{background-position:-32px -92px}.mCS-light-3.mCSB_scrollTools .mCSB_buttonLeft{background-position:-40px -112px}.mCS-light-3.mCSB_scrollTools .mCSB_buttonRight{background-position:-40px -128px}.mCS-dark-3.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-dark-3.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-dark-3.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-dark-3.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-dark-3.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.1)}.mCS-dark-3.mCSB_scrollTools .mCSB_buttonUp{background-position:-112px -72px}.mCS-dark-3.mCSB_scrollTools .mCSB_buttonDown{background-position:-112px -92px}.mCS-dark-3.mCSB_scrollTools .mCSB_buttonLeft{background-position:-120px -112px}.mCS-dark-3.mCSB_scrollTools .mCSB_buttonRight{background-position:-120px -128px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-2.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-3.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset.mCSB_scrollTools .mCSB_draggerRail{width:12px;background-color:#000;background-color:rgba(0,0,0,.2)}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-2.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-3.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:6px;margin:3px 5px;position:absolute;height:auto;top:0;bottom:0;left:0;right:0}.mCS-inset-2-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-2.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-3.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-inset.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{height:6px;margin:5px 3px;position:absolute;width:auto;top:0;bottom:0;left:0;right:0}.mCS-inset-2-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-inset-2.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-inset-3-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-inset-3.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-inset-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-inset.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:12px;margin:2px 0}.mCS-inset-2.mCSB_scrollTools .mCSB_buttonUp,.mCS-inset-3.mCSB_scrollTools .mCSB_buttonUp,.mCS-inset.mCSB_scrollTools .mCSB_buttonUp{background-position:-32px -72px}.mCS-inset-2.mCSB_scrollTools .mCSB_buttonDown,.mCS-inset-3.mCSB_scrollTools .mCSB_buttonDown,.mCS-inset.mCSB_scrollTools .mCSB_buttonDown{background-position:-32px -92px}.mCS-inset-2.mCSB_scrollTools .mCSB_buttonLeft,.mCS-inset-3.mCSB_scrollTools .mCSB_buttonLeft,.mCS-inset.mCSB_scrollTools .mCSB_buttonLeft{background-position:-40px -112px}.mCS-inset-2.mCSB_scrollTools .mCSB_buttonRight,.mCS-inset-3.mCSB_scrollTools .mCSB_buttonRight,.mCS-inset.mCSB_scrollTools .mCSB_buttonRight{background-position:-40px -128px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-inset-2-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-dark.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.1)}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_buttonUp,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_buttonUp,.mCS-inset-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-112px -72px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_buttonDown,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_buttonDown,.mCS-inset-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-112px -92px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_buttonLeft,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_buttonLeft,.mCS-inset-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-120px -112px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_buttonRight,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_buttonRight,.mCS-inset-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-120px -128px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-2.mCSB_scrollTools .mCSB_draggerRail{background-color:transparent;border-width:1px;border-style:solid;border-color:#fff;border-color:rgba(255,255,255,.2);-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_draggerRail{border-color:#000;border-color:rgba(0,0,0,.2)}.mCS-inset-3.mCSB_scrollTools .mCSB_draggerRail{background-color:#fff;background-color:rgba(255,255,255,.6)}.mCS-inset-3-dark.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.6)}.mCS-inset-3.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-inset-3.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-inset-3.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-inset-3.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.75)}.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.85)}.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.9)}
/* line 17, ../src/please-wait.scss */
body.pg-loading {
  overflow: hidden;
}

/* line 21, ../src/please-wait.scss */
.pg-loading-screen {
  position: fixed;
  bottom: 0;
  left: 0;
  right: 0;
  top: 0;
  z-index: 1000000;
  opacity: 1;
  background-color: #FFF;
  -webkit-transition: background-color 0.4s ease-in-out 0s;
  -moz-transition: background-color 0.4s ease-in-out 0s;
  -ms-transition: background-color 0.4s ease-in-out 0s;
  -o-transition: background-color 0.4s ease-in-out 0s;
  transition: background-color 0.4s ease-in-out 0s;
}
/* line 32, ../src/please-wait.scss */
.pg-loading-screen.pg-loaded {
  opacity: 0;
  -webkit-animation: pgAnimLoaded 0.5s cubic-bezier(0.7, 0, 0.3, 1) both;
  -moz-animation: pgAnimLoaded 0.5s cubic-bezier(0.7, 0, 0.3, 1) both;
  -ms-animation: pgAnimLoaded 0.5s cubic-bezier(0.7, 0, 0.3, 1) both;
  -o-animation: pgAnimLoaded 0.5s cubic-bezier(0.7, 0, 0.3, 1) both;
  animation: pgAnimLoaded 0.5s cubic-bezier(0.7, 0, 0.3, 1) both;
}
/* line 38, ../src/please-wait.scss */
.pg-loading-screen.pg-loading .pg-loading-logo-header, .pg-loading-screen.pg-loading .pg-loading-html {
  opacity: 1;
}
/* line 42, ../src/please-wait.scss */
.pg-loading-screen.pg-loading .pg-loading-logo-header, .pg-loading-screen.pg-loading .pg-loading-html:not(.pg-loaded) {
  -webkit-animation: pgAnimLoading 1s cubic-bezier(0.7, 0, 0.3, 1) both;
  -moz-animation: pgAnimLoading 1s cubic-bezier(0.7, 0, 0.3, 1) both;
  -ms-animation: pgAnimLoading 1s cubic-bezier(0.7, 0, 0.3, 1) both;
  -o-animation: pgAnimLoading 1s cubic-bezier(0.7, 0, 0.3, 1) both;
  animation: pgAnimLoading 1s cubic-bezier(0.7, 0, 0.3, 1) both;
}
/* line 46, ../src/please-wait.scss */
.pg-loading-screen.pg-loading .pg-loading-html:not(.pg-loaded) {
  -webkit-animation-delay: 0.3s;
  -moz-animation-delay: 0.3s;
  -ms-animation-delay: 0.3s;
  -o-animation-delay: 0.3s;
  animation-delay: 0.3s;
}
/* line 51, ../src/please-wait.scss */
.pg-loading-screen .pg-loading-inner {
  height: 100%;
  width: 100%;
  margin: 0;
  padding: 0;
  position: static;
}
/* line 59, ../src/please-wait.scss */
.pg-loading-screen .pg-loading-center-outer {
  width: 100%;
  padding: 0;
  display: table !important;
  height: 100%;
  position: absolute;
  top: 0;
  left: 0;
  margin: 0;
}
/* line 70, ../src/please-wait.scss */
.pg-loading-screen .pg-loading-center-middle {
  padding: 0;
  vertical-align: middle;
  display: table-cell  !important;
  margin: 0;
  text-align: center;
}
/* line 78, ../src/please-wait.scss */
.pg-loading-screen .pg-loading-logo-header, .pg-loading-screen .pg-loading-html {
  width: 100%;
  opacity: 0;
}
/* line 83, ../src/please-wait.scss */
.pg-loading-screen .pg-loading-logo-header {
  text-align: center;
}
/* line 86, ../src/please-wait.scss */
.pg-loading-screen .pg-loading-logo-header img {
  display: none !important;
}
/* line 91, ../src/please-wait.scss */
.pg-loading-screen .pg-loading-html {
  margin-top: 90px;
}
/* line 94, ../src/please-wait.scss */
.pg-loading-screen .pg-loading-html.pg-loaded {
  -webkit-transition: opacity 0.5s cubic-bezier(0.7, 0, 0.3, 1);
  -moz-transition: opacity 0.5s cubic-bezier(0.7, 0, 0.3, 1);
  -ms-transition: opacity 0.5s cubic-bezier(0.7, 0, 0.3, 1);
  -o-transition: opacity 0.5s cubic-bezier(0.7, 0, 0.3, 1);
  transition: opacity 0.5s cubic-bezier(0.7, 0, 0.3, 1);
}
/* line 97, ../src/please-wait.scss */
.pg-loading-screen .pg-loading-html.pg-loaded.pg-removing {
  opacity: 0;
}
/* line 101, ../src/please-wait.scss */
.pg-loading-screen .pg-loading-html.pg-loaded.pg-loading {
  opacity: 1;
}

@-webkit-keyframes pgAnimLoading {
  from {
    opacity: 0;
  }
}
@-moz-keyframes pgAnimLoading {
  from {
    opacity: 0;
  }
}
@-o-keyframes pgAnimLoading {
  from {
    opacity: 0;
  }
}
@-ms-keyframes pgAnimLoading {
  from {
    opacity: 0;
  }
}
@keyframes pgAnimLoading {
  from {
    opacity: 0;
  }
}
@-webkit-keyframes pgAnimLoaded {
  from {
    opacity: 1;
  }
}
@-moz-keyframes pgAnimLoaded {
  from {
    opacity: 1;
  }
}
@-o-keyframes pgAnimLoaded {
  from {
    opacity: 1;
  }
}
@-ms-keyframes pgAnimLoaded {
  from {
    opacity: 1;
  }
}
@keyframes pgAnimLoaded {
  from {
    opacity: 1;
  }
}

body,input,textarea,select
{
    font-family: 'Open Sans';
    color: #000;
}

a,a:hover,a:focus
{
    text-decoration:none;
}

body
{
    color: #fff;
}

header
{
    background: #0d0d29;
    height: 75px;
    line-height: 75px;
}

#top-right-menu{
    list-style: none;

}

#top-right-menu
{
    display: inline-block;
}

#top-right-menu li{
    display: inline-block;
    font-weight: bold;
    margin-left: 15px;
    box-sizing: border-box;
}

#top-right-menu .selected
{
    border-bottom: 4px solid #057acd;
    height: 75px;
}

#top-right-menu .selected a
{
    color: #057acd;;
}

.logged-in
{
    margin-right: 10px;
    margin-left: 30px;
}

.blue-conversation .user-name
{
    color: #009cde;
}

.green-conversation .user-name
{
    color: #0de77a;
}

#listing-history a{
    margin-left: 35px;
    color: #fff;
    text-transform: uppercase;
    display: inline-block;
    height: 37px;
    margin-bottom: -2px;

}

.the-date
{
    font-size: 13px;
    color: #615e87;
    position: relative;
    top: 2px;
}

.numbers span
{
    display: inline-block;

}

.added-a-few
{
    font-weight: 600;
    color: #908dce;
}

.join-coin
{
    color: #fff;
}

.no-padding
{
    padding-left: 0px;
    padding-right: 0px;
}

.with-line-below
{
    padding-bottom: 15px;
    margin-bottom: 15px;
    border-bottom: 1px solid #3e3b69;
    margin-left: 0px;
    margin-right: 0px;
    font-weight: 600;
}

.with-line-below > div:first-child
{
    padding-left: 0px;
}

.blue-font-span
{
    color: #009cde;
}

.added-a-few
{
    padding-left: 8px;
}

.no-padding-left
{
    padding-left: 0px;
}

.bigger-font
{
    font-size: 15px;
    font-weight: 600;
}

.with-line-below > div:last-child
{
    padding-left: 0px;
}

#listing-history a.active
{
    border-bottom: 3px solid #009cde;
}

#listing-history a img
{
    margin-right: 3px;
}

#listing-history
{
    text-align: right;
    border-bottom: 1px solid #56519d;
}

.top-logged-in
{
    color: #fff;
    font-weight: bold;
}

.top-logged-in img
{
    margin-left: 10px;
}

.one-segment
{
    margin-left: 20px;
    margin-right: 20px;
    display: inline-block;
}

#history
{
    display:none;
}

.row-tight
{
    margin-left: -1px;
    margin-right: -1px;
}

.row-tight > div
{
    padding-left: 1px;
    padding-right: 1px;
}

.floating-left
{
    position: absolute;
    top: 0px;
    left: 0px;
}

.floating-right
{
    position: absolute;
    top: 0px;
    right: 0px;
}

.col-xs-4 > div
{
    position:relative;
}

#first-column, #last-column
{
    padding-right: 0px;
}

#last-column{
    padding-left: 0px;
    overflow:hidden;
}

body
{
    overflow:hidden;
}

header a
{
    color: #fff;
}

#overlay
{
    width: 100%;
    left: 0px;
    top: 0px;
    height: 100%;
    position: fixed;
    z-index: 1000000000;
    background: rgba(11,10,25,0.9);
}

.blurred
{
    -webkit-filter: blur(5px); -moz-filter: blur(5px); -o-filter: blur(5px); -ms-filter: blur(5px); filter: blur(5px);
}

#the-overlay-content
{
    max-width: 666px;
    margin-left: auto;
    margin-right: auto;
}

.overlay-button
{
    height: 45px;
    line-height: 40px;
    width: 100%;
    font-size: 20px;
    max-width: 150px;
    display: inline-block;
    color: #fff;
    text-transform: uppercase;
    text-align: center;
    border: 2px solid #00FA9A;
    border-radius: 50px;
    box-sizing: border-box;
    transition: 0.35s;
    margin-left: 10px;
    margin-right: 10px;
    font-weight: 600;
}

#overlay-footer
{
    position: absolute;
    text-align: center;
    bottom: 20px;
    width: 100%;
}

#overlay
{
    padding-left: 15px;
    padding-right: 15px;
}

#overlay-footer a
{
    margin-left: 10px;
    margin-right: 10px;
}

#overlay-logo img
{
    max-width: 100px;
    
}

@font-face {
  font-family: 'geomanist_regularregular';
  src:  url('font/geomanist-regular-webfont.woff') format('woff')
}

#top-line
{
    font-weight: 400;
    font-size: 40px;
    font-family: arial;
    margin-top: 20px;
	color:#c1c1c1;
}

#top-line b
{
    color: #00FA9A;
}

#bottom-line
{
    font-family: arial;
    margin-bottom: 0px;
	color:#c1c1c1;
    font-size: 14px;
}

#bottom-line span
{
    color: #00FA9A;
}



#overlay-logo 
{
    margin-bottom: 60px;
}

#overlay-at-least
{
    margin-bottom: 40px;
    margin-top: 15px;
    color: #9490cf;
}

#overlay-at-least a
{
    color: #fff;
}

#overlay-at-least input
{
    margin-right: 5px;
}

#overlay-money span
{
    display: block;
    font-size: 28px;
    color: #00FA9A;
    font-weight: 600;
}

#overlay-money .col-xs-4
{
    border-right: 1px solid #9490cf;
}

#overlay-money .col-xs-4:last-child
{
    border-right: 0px;
}

.overlay-button:hover
{
    color: #fff;
    border: 2px solid #00FA9A;
    background: #00FA9A;
}

#the-overlay-content{
    text-align: center;
    padding-top: 10%;
}

#below-backpack .col-xs-9
{
    font-weight: 400;
    font-size: 15px;
    text-transform: uppercase;
}

#top-chat-row{
    padding-right: 15px;
}

#listing-history
{
    margin: 0px 15px 0 15px;
}

#below-backpack
{
    margin-bottom: 15px;
}

#first-column,
#last-column
{
    margin-top: -10px;
    background: rgba(0,0,0,0.5);
}
#second-column > div,
#third-column > div
{
    margin-top: 20px;
}

#third-column > div
{
    margin-right:15px;
}

.one-listing
{
    padding-top: 15px;
    padding-bottom: 15px;
}

.one-listing
{

    padding-left: 20px;
    padding-right: 20px;
}

.one-listing:nth-child(even)
{
    background: rgba(0,0,0,0.2);
}

.one-listing .inventory
{
    margin-top: 10px;
}

.guy-name
{
    margin-top: 20px;
    margin-bottom: 3px;
    font-size: 18px;
    color: #fff;
    font-weight: 600;
}

.the-guy
{
    max-width: 95%;
    margin-top: 10px;
    height: auto;
}

#live-record{
    padding-top: 40px;
}

.some-padding-right
{
    padding-right: 40px;
}

.some-padding-left
{
    padding-left: 40px;
}

.guy-money{
    font-weight: 600;
    color: #009cde;
}

.numbers
{
    margin-top: 15px;
    margin-bottom: 15px;
}

.numbers span
{
    display: inline-block;
    padding: 5px 7px;
    border-radius: 2px;
    background: rgba(0,0,0,0.2);
    font-weight: 600;
    margin: 0px 1px;
    font-size: 20px;
}

.numbers .blue
{
    color: #009cde;
}

.big-button
{
    font-weight: 600;
    padding: 5px 0;
    text-align: center;
    display:block;
    background: rgba(0,0,0,0.2);
    line-height: 19px;
    font-weight: 600;
    color: #fff;
}

.big-button.green-button
{
    border-bottom: 2px solid #0fca6f;
}

.big-button.green-button span
{
    color: #0fca6f;
    font-weight: 600;
}

.big-button.blue-button
{
    border-bottom: 2px solid #009cde;
}

.big-button.blue-button span
{
    color: #009cde;
    font-weight: 600;
}

.social-icons a
{
    margin-left: 9px;
    margin-right: 9px;
}

.copyright span
{
    color: #fff;
}

#chat-input input[type="image"]
{
    float: right;
}

#below-backpack span
{
    color: #009cde;
}

.big-button span
{
    display:block;
}


#top-chat-row .floating-right
{
    margin-right: 0px;
}

.user-name img
{
    margin-right: 5px;
}

.user-name img:last-child
{
    margin-left: 3px;
    vertical-align: baseline;
}

.user-name img:first-child
{
    vertical-align: middle;
}

.user-name
{
    color: #aba9e3;
    font-weight: 600;
}

@media all and (min-width: 1024px)
{
    #first-column,
    #last-column
    {
        width: 330px;
    }

    #second-column,
    #third-column
    {
        /*width: calc(50% - 330px);*/
    }

    #middle-column
    {
        width: calc(100% - 660px);
    }
}

.mCS-light-2.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar
{
    background: #908dce;
}

.mCS-dark-2.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar, .mCS-light-2.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar
{
    margin-top: 5px;
    background: #908dce;
}

#chat-input
{
    padding-right: 15px;
}

#second-column,
#third-column
{
    margin-bottom: 20px;
}

.col-xs-8ths,
.col-sm-8ths,
.col-md-8ths,
.col-lg-8ths {
    position: relative;
    min-height: 1px;
    padding-right: 10px;
    padding-left: 10px;
}

.col-xs-8ths {
    width: 20%;
    float: left;
}



.one-history-wrapper
{
    box-sizing: border-box;
    width: calc(100% - 200px);
    padding: 0px 10px;
    float: left;
}

.money-wrapper
{
    font-weight: 600;
    color: #009cde;
    margin-bottom: 8px;
    font-size: 16px;
}

.ok-1
{
    margin-left: 10px;
}

.ok-2
{
    margin-right: 10px;
}


.top-row
{
    margin-bottom: -14px;
}

.versus-wrapper
{
    margin-bottom: -10px;
    margin-top: 0px;
    position: relative;
    top: -0px;
}

@media (min-width: 768px) {
    .col-sm-8ths {
        width: 12.5%;
        float: left;
    }
}

@media (min-width: 992px) {
    .col-md-8ths {
        width: 12.5%;
        float: left;
    }
}

@media (min-width: 1200px) {
    .col-lg-8ths {
        width: 12.5%;
        float: left;
    }
}

@media all and (max-width: 767px)
{


    .desktop
    {
        display:none;
    }

    .mobile
    {
        display:block;
    }
}

@media all and (max-width: 1550px)
{
    #first-column, #last-column
    {
        width: 290px;
    }

    #middle-column
    {
        width: calc(100% - 580px);
        padding-left: 0px;
        padding-right: 0px;
    }

    #second-column
    {
        padding-right: 7px;
    }

    #third-column
    {
        padding-left: 7px;
    }
}

@media all and (max-width: 1400px)
{
    #first-column, #last-column
    {
        width: 240px;
    }

    #middle-column
    {
        width: calc(100% - 480px);
        padding-left: 0px;
        padding-right: 0px;
    }
}

@media all and (max-width: 1280px)
{
    #first-column, #last-column
    {
        width: 320px;
    }

    #middle-column
    {
        width: calc(100% - 640px);
        padding-left: 0px;
        padding-right: 0px;
    }

    #second-column,#third-column
    {
        width: 100%;
        padding-left: 15px;
        padding-right: 15px;
    }

    #second-column > div,#third-column  > div
    {
        margin-left: 15px;
        margin-right: 10px;
    }


}

@media all and (max-width: 1100px)
{
    #first-column, #last-column
    {
        width: 240px;
    }

    #middle-column
    {
        width: calc(100% - 480px);        
    }
}


@media all and (max-width: 950px)
{
    #first-column,#middle-column
    {
        width: 50%;
    }

    #last-column
    {
        width: 100%;
    }

    #the-content
    {
        clear: both;
        height: auto !important;
    }

    footer
    {
        height: auto;

    }

    .col-xs-3.one-inventory-cell
    {
        width: 10%;
    }
}


@media all and (max-width: 767px)
{
    #first-column,#middle-column
    {
        width: 100%;
    }

    .col-md-8ths
    {
        width: 12.5%;
    }

    #first-column
    {
        padding-bottom: 10px;
    }


}

@media all and (max-width: 500px)
{
    .col-xs-3.one-inventory-cell
    {
        width: 20%;
    }

    .col-md-8ths
    {
        width: 25%;
    }

}


@media all and (max-width: 400px)
{
    .one-rght-inventory-wrapper
    {
        width: 50%;
    }
}

@media all and (max-width: 700px)
{
    header
    {
        line-height: 30px;
        padding: 10px 0;
        height: auto;
    }

    #top-right-menu .selected
    {
        height: 30px;
    }
}

@media all and (max-width: 600px)
{
    header
    {
        text-align: center;
    }
    
    #overlay-money span
    {
        font-size: 21px;
    }

    header .row > div
    {
        width: 100%;
        margin: 5px 0;
    }

    #top-right-menu li
    {
        margin-left: 5px;
    }

    #top-right-menu
    {
        margin-left: 0px;
        padding-left: 0px;
    }
}
.toast-title{font-weight:700}.toast-message{-ms-word-wrap:break-word;word-wrap:break-word}.toast-message a,.toast-message label{color:#fff}.toast-message a:hover{color:#ccc;text-decoration:none}.toast-close-button{position:relative;right:-.3em;top:-.3em;float:right;font-size:20px;font-weight:700;color:#fff;-webkit-text-shadow:0 1px 0 #fff;text-shadow:0 1px 0 #fff;opacity:.8;-ms-filter:alpha(Opacity=80);filter:alpha(opacity=80)}.toast-close-button:focus,.toast-close-button:hover{color:#000;text-decoration:none;cursor:pointer;opacity:.4;-ms-filter:alpha(Opacity=40);filter:alpha(opacity=40)}button.toast-close-button{padding:0;cursor:pointer;background:0 0;border:0;-webkit-appearance:none}.toast-top-full-width{top:0;right:0;width:100%}.toast-bottom-full-width{bottom:0;right:0;width:100%}.toast-top-left{top:12px;left:12px}.toast-top-center{top:12px}.toast-bottom-right{right:12px;bottom:12px}.toast-bottom-center{bottom:12px}.toast-bottom-left{bottom:12px;left:12px}.toast-center{top:45%}#toast-container{position:fixed;z-index:999999}#toast-container.toast-bottom-center,#toast-container.toast-center,#toast-container.toast-top-center{width:100%}#toast-container.toast-bottom-center>div,#toast-container.toast-center>div,#toast-container.toast-top-center>div{margin:auto}#toast-container *{-moz-box-sizing:border-box;-webkit-box-sizing:border-box;box-sizing:border-box}#toast-container>div{margin:0 0 6px;padding:15px 15px 15px 50px;width:450px;background-position:15px center;background-repeat:no-repeat;color:#fff;opacity:.8;line-height:25px;-ms-filter:alpha(Opacity=80);filter:alpha(opacity=80)}#toast-container>:hover{opacity:1;-ms-filter:alpha(Opacity=100);filter:alpha(opacity=100);cursor:pointer}#toast-container>.toast-info{background-image:url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAGwSURBVEhLtZa9SgNBEMc9sUxxRcoUKSzSWIhXpFMhhYWFhaBg4yPYiWCXZxBLERsLRS3EQkEfwCKdjWJAwSKCgoKCcudv4O5YLrt7EzgXhiU3/4+b2ckmwVjJSpKkQ6wAi4gwhT+z3wRBcEz0yjSseUTrcRyfsHsXmD0AmbHOC9Ii8VImnuXBPglHpQ5wwSVM7sNnTG7Za4JwDdCjxyAiH3nyA2mtaTJufiDZ5dCaqlItILh1NHatfN5skvjx9Z38m69CgzuXmZgVrPIGE763Jx9qKsRozWYw6xOHdER+nn2KkO+Bb+UV5CBN6WC6QtBgbRVozrahAbmm6HtUsgtPC19tFdxXZYBOfkbmFJ1VaHA1VAHjd0pp70oTZzvR+EVrx2Ygfdsq6eu55BHYR8hlcki+n+kERUFG8BrA0BwjeAv2M8WLQBtcy+SD6fNsmnB3AlBLrgTtVW1c2QN4bVWLATaIS60J2Du5y1TiJgjSBvFVZgTmwCU+dAZFoPxGEEs8nyHC9Bwe2GvEJv2WXZb0vjdyFT4Cxk3e/kIqlOGoVLwwPevpYHT+00T+hWwXDf4AJAOUqWcDhbwAAAAASUVORK5CYII=)!important}#toast-container>.toast-wait{background-image:url(data:image/gif;base64,R0lGODlhIAAgAIQAAAQCBISGhMzKzERCROTm5CQiJKyurHx+fPz+/ExOTOzu7Dw+PIyOjCwqLFRWVAwKDIyKjMzOzOzq7CQmJLy6vFRSVPTy9AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACH/C05FVFNDQVBFMi4wAwEAAAAh+QQJCQAXACwAAAAAIAAgAAAF3eAljmRpnmh6VRSVqLDpIDTixOdUlFSNUDhSQUAT7ES9GnD0SFQAKWItMqr4bqKHVPDI+WiTkaOFFVlrFe83rDrT0qeIjwrT0iLdU0GOiBxhAA4VeSk6QYeIOAsQEAuJKgw+EI8nA18IA48JBAQvFxCXDI8SNAQikV+iiaQIpheWX5mJmxKeF6g0qpQmA4yOu8C7EwYWCgZswRcTFj4KyMAGlwYxDwcHhCXMXxYxBzQHKNo+3DDeCOAn0V/TddbYJA0K48gAEAFQicMWFsfwNA3JSgAIAAFfwIMIL4QAACH5BAkJABoALAAAAAAgACAAhAQCBIyKjERCRMzOzCQiJPTy9DQyNGRmZMTCxOTm5CwqLHx+fBQWFJyenNTW1Pz6/Dw6PGxubAwKDIyOjNTS1CQmJCwuLPz+/Dw+PHRydAAAAAAAAAAAAAAAAAAAAAAAAAXboCaOZGmeaKoxWcSosMkk15W8cZ7VdZaXkcEgQtrxfD9RhHchima1GwlCGUBSFCaFxMrgRtnLFhWujWHhs2nJc8KoVlWGQnEn7/i8XgOwWAB7JwoONQ4KgSQAZRcOgHgSCwsSIhZMNRZ5CzULIgaWF5h4mhecfIQ8jXmQkiODhYeIiRYGjrG2PxgBARi3IhNMAbcCnwI5BAQpAZ8TIwK6vCQVDwUVKL+WzAANTA210g/VJ8OWxQefByQE4dZMzBoInwh4zrtgn2p725YNthUFTNRuGYB3AYGBHCEAACH5BAkJAB0ALAAAAAAgACAAhAQCBISChFRWVMzKzCQiJOTm5GxqbCwuLJSWlPz6/NTW1AwODJSSlGRmZCwqLOzu7HR2dDQ2NAQGBISGhFxaXNTS1CQmJOzq7GxubDQyNKSmpPz+/Nza3AAAAAAAAAAAAAXfYCeOZGmeaKqurHBdAiuP17Zdc0lMAVHWt9yI8LA9fCPB4xEjARoNSWpis01kBpshFahurqzsZosiGpErScMAUO0maKF8Tq/bTQCIQgFp30cQXhB1BHEcXhx0FgkJFiOHVYlzi42AgoRxeRx8fn+en3UABwedKgsBAwMBCygOCjYKDisLFV4VrCUAtVUKpSZdXl8mB8EbByQWcQPFAyYZxccdB7sV0cvBzbmvvG0LBV4FrFTBYCWuNhyyHRTFFB20trh4BxmdYl4YIqepq0IRxRE+IfDCAFQHARo0NGERAgAh+QQJCQAgACwAAAAAIAAgAIUEAgSEgoRMTkzMyswcHhzk5uR0cnQUFhRcXlwsKiz09vQMCgyMiozU1tQkJiR8fnxkZmT8/vwEBgSEhoRcWlzU0tQkIiT08vR0dnQcGhxkYmQ0MjT8+vwMDgyMjozc2twAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAG+UCQcEgsGo/IpHLJXDweC6Z0+IhEHlOjRGIMWLHZoUZx0RQlAajxkFFKFFYFl5m5KNpIySU+X2bIBEoQZBBZGQdMElFhjI2Oj5AgHQEDAw8dQxYeDBaNHRVWVhWYCXsRFwmMXqFWEyAerB6MA6xWA6+xs7URt6VWqIwTu64gDh4eDp6goaORQ5OVAZjO1EgEGhB4RwAYDQ0YAEwIcBEKFEgYrBhLBORxgUYfrB9LELuF8fNDAAaVBuEg7NXCVyRdqHVCGLBiIIQAB1Yc4BXh9uEbwAXuyi2iQI7DuSwHdiFqCEGDtizLRFUDsaGAlQIbVoJYIEDAIiZBAAAh+QQJCQAbACwAAAAAIAAgAIQEAgSMioxcWlz08vQcHhysqqwMDgx8enwsKiykoqRkZmT8+vzEwsQMCgyUlpQkJiS0srQEBgSMjoxcXlz09vQkIiSsrqwUEhQ0MjRsamz8/vwAAAAAAAAAAAAAAAAAAAAF7+AmjmRpnmiqruz2PG0sIssCj4CQJAIgj4/abRNJaI6agu9kCAQaphdJgEQKUIFjgGWsahJYLdf7RTWfLKr3+jsBClVlG5Xb9eb4fImgUBBKDVB4ExRHFGwbGRQLGXMEhUgUfw2QC4IyCmSNDQtHlm2ZXgoiGQsUjW0EnUgLfyKBeYSeiHojfH61uS0GBisVEgEVLRcWRxAXKAgDRwMILMVIECgSVRIrBmS9JtRI1iMVBweuGxerSNolyszOIhjLGs0jEFXSKA8SEkMbcEgWIxfzNBxrw6AKgxIGkM05UOWALhERHJhysOThBgAVWYQAACH5BAkJABkALAAAAAAgACAAhAQGBIyKjERCRMzOzCwuLGRiZPz6/OTm5AwODLSytFRSVNTW1Dw6PHx6fAwKDJSSlERGRNTS1DQyNGxqbPz+/BQSFLy6vFRWVNza3AAAAAAAAAAAAAAAAAAAAAAAAAAAAAXqYCaO5FgFwxBUZeu61ULNFMa+eBvQdJD/owFvFhkBBAwHsBQZUooZyWF2YOQkBNJu6ANMaQeli0AxSEwymi0DcUJeEgPlbEJFAghRe/h+Eeg/Dl9UYks5DF9VhksOAgKFi5GSSwh5kzgVCXIJNxknD5aSCTwJIw8zD5MITpanFKmSCHI8NxUPoJejNKWXLZkznL0vCJ3CxsckDpA/ChYJFzkTBgYTSxc80C4OswbLLhY8Fi/bMwYAJVgl4DTiL9LUJADrFuci1zTZLwD1IwU8BSQuWLCQb1EDHg2QiSDALYvCDAISJLDy8FIIACH5BAkJAB4ALAAAAAAgACAAhAQGBISGhFRSVNTW1CQiJKyqrGRmZOzu7CwuLIyOjGxubPz6/BQSFGRiZOTi5CwqLLy6vDQ2NIyKjFRWVCQmJKyurGxqbPT29DQyNJSSlHRydPz+/BQWFOzq7AAAAAAAAAXhoCeOJElYClGubOs117YtjWuvxCLLi3qbhc6h4FPsdorfiNI5dige43GT9AAkHUcCwCpMNxVP7tgTJY4J1uF7EBl0M8Ooueuo2SOCIkVa11kVX2E2EmgsFH4yBz4uAAkdHVstBAUHQ4xKmZqbnJ2bAhAQAiURGJ4eE0cTIxgzpp0QRxCsrp6xO7MjpaepO6unKxOhv8DFxsfIJBwaChw2DAkZDEocDjIOzi0ZMhlKUjIaLtsb3T8aR+EtDBkJ0yQUBQVQI9XX2ZsDMgMlyxr3mzE2XEgmotCGAARFIHiQ0FMIACH5BAkJABgALAAAAAAgACAAhAQCBISGhDw+POTi5CwuLLS2tPTy9BQSFJyenGRiZDQ2NIyOjLy+vPz6/BweHIyKjFRSVOzq7DQyNLy6vBQWFHRydDw6PPz+/AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAXXICaOZHkcZaquIjVd10SxtFrAcFGrVhBYIwoON9uNAsOA6DCEFTEKBEKxEjQvAtELNxkpGrAGNfW4Plpb2QgxRKjKzfPoVGLj3CnLNUv7hscpSDhKOxJSgDwPP0ZGAACMjAQFDQYFBJA0BAZDBpeYGBQVFUU3TV2YFAMwAzNgTQ2PkBVDFRiuQ7CYszi1pUOnkKmrM5qcnqiiTwQTDQ2Wn9DR0tPUfRKQEBEREDQSFw3XRhEwEd3f4TvjF+XWKgJ8JNnb0QkwCdUlCzAL+CQODAwc9BtIMAQAOw==)!important}#toast-container>.toast-error{background-image:url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAHOSURBVEhLrZa/SgNBEMZzh0WKCClSCKaIYOED+AAKeQQLG8HWztLCImBrYadgIdY+gIKNYkBFSwu7CAoqCgkkoGBI/E28PdbLZmeDLgzZzcx83/zZ2SSXC1j9fr+I1Hq93g2yxH4iwM1vkoBWAdxCmpzTxfkN2RcyZNaHFIkSo10+8kgxkXIURV5HGxTmFuc75B2RfQkpxHG8aAgaAFa0tAHqYFfQ7Iwe2yhODk8+J4C7yAoRTWI3w/4klGRgR4lO7Rpn9+gvMyWp+uxFh8+H+ARlgN1nJuJuQAYvNkEnwGFck18Er4q3egEc/oO+mhLdKgRyhdNFiacC0rlOCbhNVz4H9FnAYgDBvU3QIioZlJFLJtsoHYRDfiZoUyIxqCtRpVlANq0EU4dApjrtgezPFad5S19Wgjkc0hNVnuF4HjVA6C7QrSIbylB+oZe3aHgBsqlNqKYH48jXyJKMuAbiyVJ8KzaB3eRc0pg9VwQ4niFryI68qiOi3AbjwdsfnAtk0bCjTLJKr6mrD9g8iq/S/B81hguOMlQTnVyG40wAcjnmgsCNESDrjme7wfftP4P7SP4N3CJZdvzoNyGq2c/HWOXJGsvVg+RA/k2MC/wN6I2YA2Pt8GkAAAAASUVORK5CYII=)!important}#toast-container>.toast-success{background-image:url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAADsSURBVEhLY2AYBfQMgf///3P8+/evAIgvA/FsIF+BavYDDWMBGroaSMMBiE8VC7AZDrIFaMFnii3AZTjUgsUUWUDA8OdAH6iQbQEhw4HyGsPEcKBXBIC4ARhex4G4BsjmweU1soIFaGg/WtoFZRIZdEvIMhxkCCjXIVsATV6gFGACs4Rsw0EGgIIH3QJYJgHSARQZDrWAB+jawzgs+Q2UO49D7jnRSRGoEFRILcdmEMWGI0cm0JJ2QpYA1RDvcmzJEWhABhD/pqrL0S0CWuABKgnRki9lLseS7g2AlqwHWQSKH4oKLrILpRGhEQCw2LiRUIa4lwAAAABJRU5ErkJggg==)!important}#toast-container>.toast-warning{background-image:url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAGYSURBVEhL5ZSvTsNQFMbXZGICMYGYmJhAQIJAICYQPAACiSDB8AiICQQJT4CqQEwgJvYASAQCiZiYmJhAIBATCARJy+9rTsldd8sKu1M0+dLb057v6/lbq/2rK0mS/TRNj9cWNAKPYIJII7gIxCcQ51cvqID+GIEX8ASG4B1bK5gIZFeQfoJdEXOfgX4QAQg7kH2A65yQ87lyxb27sggkAzAuFhbbg1K2kgCkB1bVwyIR9m2L7PRPIhDUIXgGtyKw575yz3lTNs6X4JXnjV+LKM/m3MydnTbtOKIjtz6VhCBq4vSm3ncdrD2lk0VgUXSVKjVDJXJzijW1RQdsU7F77He8u68koNZTz8Oz5yGa6J3H3lZ0xYgXBK2QymlWWA+RWnYhskLBv2vmE+hBMCtbA7KX5drWyRT/2JsqZ2IvfB9Y4bWDNMFbJRFmC9E74SoS0CqulwjkC0+5bpcV1CZ8NMej4pjy0U+doDQsGyo1hzVJttIjhQ7GnBtRFN1UarUlH8F3xict+HY07rEzoUGPlWcjRFRr4/gChZgc3ZL2d8oAAAAASUVORK5CYII=)!important}#toast-container.toast-bottom-full-width>div,#toast-container.toast-top-full-width>div{width:96%;margin:auto}.toast{background-color:#030303}.toast-success{background-color:#51a351}.toast-error{background-color:#bd362f}.toast-info,.toast-wait{background-color:#2f96b4}.toast-warning{background-color:#f89406}@media all and (max-width:240px){#toast-container>div{padding:8px 8px 8px 50px;width:11em}#toast-container .toast-close-button{right:-.2em;top:-.2em}}@media all and (min-width:241px) and (max-width:480px){#toast-container>div{padding:8px 8px 8px 50px;width:18em}#toast-container .toast-close-button{right:-.2em;top:-.2em}}@media all and (min-width:481px) and (max-width:768px){#toast-container>div{padding:15px 15px 15px 50px;width:25em}}:not(.no-enter)#toast-container>div.ng-enter,:not(.no-leave)#toast-container>div.ng-leave{-webkit-transition:0.5ms cubic-bezier(0.25,.25,.75,.75) all;-moz-transition:0.5ms cubic-bezier(0.25,.25,.75,.75) all;-ms-transition:0.5ms cubic-bezier(0.25,.25,.75,.75) all;-o-transition:0.5ms cubic-bezier(0.25,.25,.75,.75) all;transition:0.5ms cubic-bezier(0.25,.25,.75,.75) all}:not(.no-enter)#toast-container>div.ng-enter.ng-enter-active,:not(.no-leave)#toast-container>div.ng-leave{opacity:.8}:not(.no-enter)#toast-container>div.ng-enter,:not(.no-leave)#toast-container>div.ng-leave.ng-leave-active{opacity:0}