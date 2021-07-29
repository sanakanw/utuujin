
const SCALE = 2;

const MAP_SIZE = 32;

const SPRITE_SIZE			= 16;
const SPRITE_MAP_SIZE	= 256;

const TILE_SIZE				= SPRITE_MAP_SIZE / SPRITE_SIZE * SCALE;

const KEY_LEFT				= 37;
const KEY_UP					= 38;
const KEY_RIGHT				= 39;
const KEY_DOWN				= 40;

const MBUTTON_LEFT		= 0;
const MBUTTON_RIGHT		= 2;

const TILE_NONE				= 0;
const TILE_GRASS			= 1;
const TILE_SAND				= 2;
const TILE_SAND_BOX_0 = 3;
const TILE_SAND_BOX_1 = 4;
const TILE_SAND_BOX_2 = 5;
const TILE_SAND_BOX_3 = 6;
const TILE_SAND_BOX_4 = 7;
const TILE_SAND_BOX_5 = 8;
const TILE_SAND_BOX_6 = 9;
const TILE_SAND_BOX_7 = 10;
const TILE_CHECKER		= 11;
const TILE_VOID				= 12;
const TILE_EMPTY_VOID	= 13;

const ENTITY_NONE											= 0;
const ENTITY_PLAYER_FORWARD						= 1;
const ENTITY_PLAYER_FORWARD_WALK_0		= 2;
const ENTITY_PLAYER_FORWARD_WALK_1		= 3;
const ENTITY_PLAYER_LEFT							= 4;
const ENTITY_PLAYER_LEFT_WALK_0				= 5;
const ENTITY_PLAYER_LEFT_WALK_1				= 6;
const ENTITY_PLAYER_BACKWARD					= 7;
const ENTITY_PLAYER_BACKWARD_WALK_0		= 8;
const ENTITY_PLAYER_BACKWARD_WALK_1		= 9;
const ENTITY_PLAYER_RIGHT							= 10;
const ENTITY_PLAYER_RIGHT_WALK_0			= 11;
const ENTITY_PLAYER_RIGHT_WALK_1			= 12;
const ENTITY_SLIDE										= 13;
const ENTITY_BOARD										= 14;
const ENTITY_MAGIC_SQUARE 						= 15;
const ENTITY_FLOATING_HALF_VOID				= 16;

const FLOATING_TILE_NONE = 0;

const tile_dict = [
	{ xt: 0, yt: 0 }, // TILE_NONE
	{ xt: 1, yt: 0 }, // TILE_GRASS
	{ xt: 1, yt: 1 }, // TILE_SAND
	{ xt: 2, yt: 0 }, // TILE_SAND_BOX_0
	{ xt: 3, yt: 0 }, // TILE_SAND_BOX_1
	{ xt: 4, yt: 0 }, // TILE_SAND_BOX_2
	{ xt: 5, yt: 0 }, // TILE_SAND_BOX_3
	{ xt: 2, yt: 1 }, // TILE_SAND_BOX_4
	{ xt: 3, yt: 1 }, // TILE_SAND_BOX_5
	{ xt: 4, yt: 1 }, // TILE_SAND_BOX_6
	{ xt: 5, yt: 1 }, // TILE_SAND_BOX_7
	{ xt: 6, yt: 0 }, // TILE_CHECKER,
	{ xt: 7, yt: 0 },  // TILE_VOID
	{ xt: 6, yt: 3, }, // TILE_SHOP_0
	{ xt: 7, yt: 2 },  // TILE_SHOP_1
	{ xt: 8, yt: 2 },  // TILE_SHOP_2
	{ xt: 9, yt: 2 },  // TILE_SHOP_3
	{ xt: 7, yt: 3 },  // TILE_SHOP_4
	{ xt: 8, yt: 3 },  // TILE_SHOP_5
	{ xt: 9, yt: 3 },  // TILE_SHOP_6
	{ xt: 10, yt: 3 },  // TILE_SHOP_7
	{ xt: 11, yt: 3 },  // TILE_SHOP_8
	{ xt: 10, yt: 2 },  // TILE_SHOP_9
	{ xt: 11, yt: 2 },  // TILE_SHOP_10
	{ xt: 10, yt: 1 },  // TILE_SHOP_11
	{ xt: 11, yt: 1 },  // TILE_SHOP_12
];

const floating_tile_dict = [
	{ xt: 0, yt: 0, }, // FLOATING_TILE_NONE
	{ xt: 7, yt: 1, }, // FLOATING_TILE_VOID
	{ xt: 8, yt: 0, }, // FLOATING_TILE_HALF_VOID
	{ xt: 6, yt: 2, }, // FLOATING_TILE_SHOP_0
	{ xt: 11, yt: 0 } // FLOATING_TILE_SHOP_1
];

const entity_dict = [
	{ xt: 0, yt: 0, w: 1, h: 1 },		// ENTITY_NONE											
	{ xt: 0, yt: 5, w: 1, h: 2 },		// ENTITY_PLAYER_FORWARD						
	{ xt: 1, yt: 5, w: 1, h: 2 },		// ENTITY_PLAYER_FORWARD_WALK_0		
	{ xt: 2, yt: 5, w: 1, h: 2 },		// ENTITY_PLAYER_FORWARD_WALK_1		
	{ xt: 0, yt: 7, w: 1, h: 2 },		// ENTITY_PLAYER_LEFT							
	{ xt: 1, yt: 7, w: 1, h: 2 },		// ENTITY_PLAYER_LEFT_WALK_0				
	{ xt: 2, yt: 7, w: 1, h: 2 },		// ENTITY_PLAYER_LEFT_WALK_1				
	{ xt: 0, yt: 9, w: 1, h: 2 },		// ENTITY_PLAYER_BACKWARD					
	{ xt: 1, yt: 9, w: 1, h: 2 },		// ENTITY_PLAYER_BACKWARD_WALK_0		
	{ xt: 2, yt: 9, w: 1, h: 2 },		// ENTITY_PLAYER_BACKWARD_WALK_1		
	{ xt: 5, yt: 11, w: 1, h: 2 },	// ENTITY_PLAYER_RIGHT							
	{ xt: 6, yt: 11, w: 1, h: 2 },	// ENTITY_PLAYER_RIGHT_WALK_0			
	{ xt: 7, yt: 11, w: 1, h: 2 },	// ENTITY_PLAYER_RIGHT_WALK_1			
	{ xt: 3, yt: 4, w: 5, h: 4 },		// ENTITY_SLIDE										
	{ xt: 0, yt: 2, w: 3, h: 2 },		// ENTITY_BOARD										
	{ xt: 0, yt: 4, w: 2, h: 1 },  	// ENTITY_MAGIC_SQUARE          
];

function get_tile_space(n)
{
	return Math.floor(n / TILE_SIZE);
}

function find_entity(xt, yt)
{
	for (let i = 0; i < entity_dict.length; i++) {
		if (entity_dict[i].xt == xt && entity_dict[i].yt == yt) {
			return i;
		}
	}
	
	return ENTITY_NONE;
}

function find_tile(xt, yt)
{
	for (let i = 0; i < tile_dict.length; i++) {
		if (tile_dict[i].xt == xt && tile_dict[i].yt == yt) {
			return i;
		}
	}
	
	return TILE_NONE;
}

function find_floating_tile(xt, yt)
{
	for (let i = 0; i < floating_tile_dict.length; i++) {
		if (floating_tile_dict[i].xt == xt && floating_tile_dict[i].yt == yt) {
			return i;
		}
	}
	
	return FLOATING_TILE_NONE;
}

function new_entity(x, y, type)
{
	return {
		x: x,
		y: y,
		type: type
	};
}

function new_floating_tile(x, y, type)
{
	return {
		x: x,
		y: y,
		type: type
	};
}

function draw_map(display, sprite_map, map, entity_list, floating_tile_list)
{
	for (let y = 0; y < MAP_SIZE; y++) {
		for (let x = 0; x < MAP_SIZE; x++) {
			let tile = tile_dict[map[x + y * MAP_SIZE]];
			
			display.drawImage(
				sprite_map,
				tile.xt * SPRITE_SIZE,
				tile.yt * SPRITE_SIZE,
				SPRITE_SIZE,
				SPRITE_SIZE,
				x * TILE_SIZE,
				y * TILE_SIZE,
				TILE_SIZE,
				TILE_SIZE);
		}
	}
	
	for (let i = 0; i < entity_list.length; i++) {
		let entity = entity_list[i];
		let entity_data = entity_dict[entity.type];
		
		display.drawImage(
			sprite_map,
			entity_data.xt * SPRITE_SIZE,
			entity_data.yt * SPRITE_SIZE,
			entity_data.w * SPRITE_SIZE,
			entity_data.h * SPRITE_SIZE,
			entity.x * TILE_SIZE,
			entity.y * TILE_SIZE,
			entity_data.w * TILE_SIZE,
			-entity_data.h * TILE_SIZE
		);
	}
	
	for (let i = 0; i < floating_tile_list.length; i++) {
		let floating_tile = floating_tile_list[i];
		let floating_tile_data = floating_tile_dict[floating_tile.type];
		
		display.drawImage(
			sprite_map,
			floating_tile_data.xt * SPRITE_SIZE,
			floating_tile_data.yt * SPRITE_SIZE,
			SPRITE_SIZE,
			SPRITE_SIZE,
			floating_tile.x * TILE_SIZE,
			floating_tile.y * TILE_SIZE,
			TILE_SIZE,
			TILE_SIZE
		);
	}
}

function draw_grid(display)
{
	for (let xt = 0; xt < display.canvas.width; xt += TILE_SIZE) {
		ctx.fillRect(xt - 1, 0, 2, display.canvas.width);
	}
	
	for (let yt = 0; yt < display.canvas.height; yt += TILE_SIZE) {
		ctx.fillRect(0, yt - 1, display.canvas.height, 2);
	}
}

function draw_box(display, xt, yt)
{
	const offset = 0;
	
	display.beginPath();
	display.rect(
		xt * TILE_SIZE - offset / 2,
		yt * TILE_SIZE - offset / 2,
		TILE_SIZE + offset,
		TILE_SIZE + offset);
	display.stroke();
	display.closePath();
}

function start(sprite_map)
{
	let display = document.getElementById("display").getContext("2d");
	let sprite_select = document.getElementById("sprite_map").getContext("2d");
	
	display.canvas.width = MAP_SIZE * TILE_SIZE;
	display.canvas.height = MAP_SIZE * TILE_SIZE;
	display.imageSmoothingEnabled = false;
	display.fillStyle ="#ffffff";
	display.strokeStyle = "#ffffff";
	
	sprite_select.canvas.width = SCALE * SPRITE_MAP_SIZE;
	sprite_select.canvas.height = SCALE * SPRITE_MAP_SIZE;
	sprite_select.imageSmoothingEnabled = false;
	sprite_select.fillStyle ="#ffffff";
	sprite_select.strokeStyle = "#000000";
	
	let tile = TILE_NONE;
	let entity = ENTITY_NONE;
	let floating_tile = FLOATING_TILE_NONE;
	
	let map = new Uint32Array(MAP_SIZE * MAP_SIZE);
	let entity_list = [];
	let floating_tile_list = [];
	
	let mouse_down = false;
	let xt = 0;
	let yt = 0;
	
	document.getElementById("fill").addEventListener("click", function(e)
	{
		for (let i = 0; i < MAP_SIZE * MAP_SIZE; i++) {
			map[i] = tile;
		}
		
		draw_map(display, sprite_map, map, entity_list, floating_tile_list);
	});
	
	document.getElementById("save").addEventListener("click", function(e)
	{
		let save = document.getElementById("code");
		
		save.value = "";
		
		save.value += MAP_SIZE.toString() + " ";
		save.value += MAP_SIZE.toString() + " ";
		
		for (let i = 0; i < map.length; i++) {
			save.value += map[i].toString() + " ";
		}
		
		save.value += entity_list.length.toString() + " ";
		
		for (let i = 0; i < entity_list.length; i++) {
			save.value += entity_list[i].type + " ";
			save.value += entity_list[i].x + " ";
			save.value += entity_list[i].y + " ";
		}
		
		save.value += floating_tile_list.length.toString() + " ";
		
		for (let i = 0; i < floating_tile_list.length; i++) {
			save.value += floating_tile_list[i].type + " ";
			save.value += floating_tile_list[i].x + " ";
			save.value += floating_tile_list[i].y + " ";
		}
	});
	
	document.getElementById("display").addEventListener("mousemove", function(e)
	{
		if (mouse_down) {
			let x = get_tile_space(e.offsetX);
			let y = get_tile_space(e.offsetY);
			
			if (tile != TILE_NONE)
				map[x + y * MAP_SIZE] = tile;
			
			draw_map(display, sprite_map, map, entity_list, floating_tile_list);
		}
	});
	
	document.getElementById("display").addEventListener("mousedown", function(e)
	{
		let x = get_tile_space(e.offsetX);
		let y = get_tile_space(e.offsetY);
		
		if (e.button == MBUTTON_LEFT) {
			if (tile != TILE_NONE)
				map[x + y * MAP_SIZE] = tile;
			else if (entity != ENTITY_NONE)
				entity_list.push(new_entity(x, y + 1, entity));
			else if (floating_tile != FLOATING_TILE_NONE)
				floating_tile_list.push(new_floating_tile(x, y, floating_tile));
			
			mouse_down = true;
		} else if (e.button == MBUTTON_RIGHT) {
			for (let i = 0; i < entity_list.length; i++) {
				if (entity_list[i].x == x && entity_list[i].y == y + 1) {
					entity_list.splice(i, 1);
				}
			}
			
			for (let i = 0; i < floating_tile_list.length; i++) {
				if (floating_tile_list[i].x == x && floating_tile_list[i].y == y) {
					floating_tile_list.splice(i, 1);
				}
			}
		}
		
		draw_map(display, sprite_map, map, entity_list, floating_tile_list);
	});
	
	document.getElementById("display").addEventListener("contextmenu", function(e)
	{
		e.preventDefault();
	});
	
	document.getElementById("display").addEventListener("mouseup", function(e)
	{
		mouse_down = false;
	});
	
	document.getElementById("sprite_map").addEventListener("mousedown", function(e) {
		xt = get_tile_space(e.offsetX);
		yt = get_tile_space(e.offsetY);
		
		tile = find_tile(xt, yt);
		entity = find_entity(xt, yt);
		floating_tile = find_floating_tile(xt, yt);
		
		sprite_select.fillRect(0, 0, SPRITE_MAP_SIZE * SCALE, SPRITE_MAP_SIZE * SCALE);
		sprite_select.drawImage(sprite_map, 0, 0, SPRITE_MAP_SIZE * SCALE, SPRITE_MAP_SIZE * SCALE);
		draw_box(sprite_select, xt, yt);
	});
	
	document.addEventListener("keydown", function(e) {
		switch (e.keyCode) {
		case KEY_UP:
			yt--;
			e.preventDefault();
			break;
		case KEY_DOWN:
			yt++;
			e.preventDefault();
			break;
		case KEY_RIGHT:
			xt++;
			e.preventDefault();
			break;
			console.log(x + ", " + y);
		
		case KEY_LEFT:
			xt--;
			e.preventDefault();
			break;
		}
		
		tile = find_tile(xt, yt);
		entity = find_entity(xt, yt);
		floating_tile = find_floating_tile(xt, yt);
		
		sprite_select.fillRect(0, 0, SPRITE_MAP_SIZE * SCALE, SPRITE_MAP_SIZE * SCALE);
		sprite_select.drawImage(sprite_map, 0, 0, SPRITE_MAP_SIZE * SCALE, SPRITE_MAP_SIZE * SCALE);
		draw_box(sprite_select, xt, yt);
	});
	
	for (let i = 0; i < MAP_SIZE * MAP_SIZE; i++) {
		map[i] = TILE_GRASS;
	}
	
	draw_map(display, sprite_map, map, entity_list, floating_tile_list);
	sprite_select.fillRect(0, 0, SPRITE_MAP_SIZE * SCALE, SPRITE_MAP_SIZE * SCALE);
	sprite_select.drawImage(sprite_map, 0, 0, SPRITE_MAP_SIZE * SCALE, SPRITE_MAP_SIZE * SCALE);
}

(function() {
	
	let sprite_map = new Image();
	sprite_map.src = 'SpriteMap.png';
	
	sprite_map.onload = function(e) {
		start(sprite_map);
	};
})();
