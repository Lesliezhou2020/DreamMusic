// JavaScript Drum Kit App

$(document).ready(function(){
	const beats = $(".beats");
	const audios = $("audio");
	let playing = false;

	const playingClass = 'playing',
		crashRide = document.getElementById('crash-ride'),
		hiHatTop = document.getElementById('hihat-top');

	const animateCrashOrRide = () => {
		crashRide.style.transform = 'rotate(0deg) scale(1.5)';
	};

	const animateHiHatClosed = () => {
		hiHatTop.style.top = '171px';
	};

	const playSound = e => {
		const keyCode = e.keyCode,
			keyElement = document.querySelector(`div[data-key="${keyCode}"]`);

		if(!keyElement) return;

		const audioElement = document.querySelector(`audio[data-key="${keyCode}"]`);
		audioElement.currentTime = 0;
		audioElement.play();

		switch(keyCode) {
			case 69:
			case 82:
				animateCrashOrRide();
				break;
			case 75:
				animateHiHatClosed();
				break;
		}

		keyElement.classList.add(playingClass);
	};

	const removeCrashRideTransition = e => {
		if(e.propertyName !== 'transform') return;

		e.target.style.transform = 'rotate(-7.2deg) scale(1.5)';
	};

	const removeHiHatTopTransition = e => {
		if(e.propertyName !== 'top') return;

		e.target.style.top = '166px';
	};	

	const removeKeyTransition = e => {
		if(e.propertyName !== 'transform') return;

		e.target.classList.remove(playingClass)
	};

	const drumKeys = Array.from(document.querySelectorAll('.key'));

	drumKeys.forEach(key => {
		key.addEventListener('transitionend', removeKeyTransition);
	});

	crashRide.addEventListener('transitionend', removeCrashRideTransition);
	hiHatTop.addEventListener('transitionend', removeHiHatTopTransition);

	window.addEventListener('keydown', playSound);

	$(".beats").click(function() {
		let beat = this.textContent;
		this.textContent = (beat == 'x' ? '-' : 'x');
	});

	$("#stop").click(function() {
		playing = false;
	});

	$("#play").click(async function() {
		playing = true;
		let iterations = $("#iterations")[0].value;
		while (iterations > 0) {
			console.log(iterations);
			await play();
			iterations--;
		}
	});

	const sleepNow = (delay) => new Promise((resolve) => setTimeout(resolve, delay));

	async function play() {
		for (let step = 0; step < beats.length / 9; step++) {
			for (let instrument = 0; instrument < 9; instrument++) {
				if (beats[step * 9 + instrument].textContent == 'x') {
					audios[instrument].play();
				}
			}
			await sleepNow(500);
		}
		await sleepNow(1000);
	}

});