// JavaScript Drum Kit App

$(document).ready(function(){
	const beats = $(".form-control");
	const audios = $("audio");

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
	});

	$("#play").click(async function() {
		await play();
	});

	$("#save").click(function() {
		const user_id = $("#meta_info").attr("user_id");
		if (user_id == -1) {
			location.href = "/sign";
			return;
		}

		var title = prompt("Please enter the clap title", "");
		if (title != null) {
			let claps = beats.toArray().map(x => x.value);
			console.log(name);
			console.log(claps);
			$.ajax({
				type: "POST",
				url: "new",
				success: function (data) { console.log(data); },
				data: {
					title: title,
					creatorId: user_id,
					crash: claps[0],
					ride: claps[1],
					floorTom: claps[2],
					midTom: claps[3],
					highTom: claps[4],
					kick: claps[5],
					snare: claps[6],
					hiHatOpen: claps[7],
					hiHatClose: claps[8],
				},
				accept: 'application/json',
			});
		}
	});

	const sleepNow = (delay) => new Promise((resolve) => setTimeout(resolve, delay));

	async function play() {
		let interval = parseInt(document.getElementById("interval").value);
		let claps = beats.toArray().map(b => b.value.length).reduce((x, y) => (x > y ? x : y), 0);
		console.log(claps);

		for (let clap = 0; clap < claps; clap++) {
			for (let instrument = 0; instrument < beats.length; instrument++) {
				if (beats[instrument].value[clap] == 'x') {
					audios[instrument].play();
				}
			}
			await sleepNow(interval);
		}
	}
});
