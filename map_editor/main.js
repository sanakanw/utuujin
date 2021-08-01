
const SCALE = 2;

const MAP_SIZE = 32;

const SPRITE_SIZE			= 16;
const SPRITE_MAP_SIZE	= 512;

const TILE_SIZE				= 32;

const KEY_LEFT				= 37;
const KEY_UP					= 38;
const KEY_RIGHT				= 39;
const KEY_DOWN				= 40;

const MBUTTON_LEFT		= 0;
const MBUTTON_RIGHT		= 2;

const TILE_NONE												= 0;
const TILE_GRASS											= 1;
const TILE_SAND												= 2;
const TILE_SAND_BOX_0 								= 3;
const TILE_SAND_BOX_1 								= 4;
const TILE_SAND_BOX_2 								= 5;
const TILE_SAND_BOX_3 								= 6;
const TILE_SAND_BOX_4 								= 7;
const TILE_SAND_BOX_5 								= 8;
const TILE_SAND_BOX_6 								= 9;
const TILE_SAND_BOX_7 								= 10;
const TILE_CHECKER										= 11;
const TILE_VOID												= 12;
const TILE_EMPTY_VOID									= 13;
const TILE_SAND_PATH_0								= 14;
const TILE_SAND_PATH_1								= 15;
const TILE_SAND_PATH_2								= 16;
const TILE_SAND_PATH_3								= 17;
const TILE_SAND_PATH_4								= 18;
const TILE_SAND_PATH_5								= 19;
const TILE_SAND_PATH_6								= 20;
const TILE_SAND_PATH_7								= 21;
const TILE_TREE_BORDER_0              = 22;
const TILE_TREE_BORDER_1              = 23;
const TILE_TREE_BORDER_2              = 24;
const TILE_TREE_BORDER_3              = 25;
const TILE_TREE_BORDER_4              = 26;
const TILE_TREE_BORDER_5              = 27;
const TILE_TREE_BORDER_6              = 28;
const TILE_TREE_BORDER_7              = 29;
const TILE_TREE_BORDER_8              = 30;
const TILE_TREE_BORDER_9              = 31;
const TILE_TREE_BORDER_10             = 32;
const TILE_TREE_BORDER_11             = 33;
const TILE_TREE_BORDER_12             = 34;
const TILE_TREE_BORDER_13             = 35;
const TILE_TREE_BORDER_14             = 36;
const TILE_TREE_BORDER_15             = 37;
const TILE_ROAD_0                     = 38;
const TILE_ROAD_1                     = 39;
const TILE_ROAD_2                     = 40;
const TILE_ROAD_3                     = 41;
const TILE_INVISIBLE									= 42;
const TILE_INVISIBLE_SOLID						= 43;
const TILE_SEWER_LADDER_0             = 44;
const TILE_SEWER_LADDER_2             = 45;
const TILE_SEWER_WALL                 = 46;
const TILE_SEWER_WATER                = 47;
const TILE_SEWER_FLOOR                = 48;
const TILE_SEWER_BRIDGE_0             = 49;
const TILE_SEWER_BRIDGE_1             = 50;
const TILE_SEWER_BRIDGE_2             = 51;
const TILE_SEWER_BRIDGE_3             = 52;
const TILE_MALL_0                     = 53;
const TILE_MALL_1                     = 54;
const TILE_MALL_2                     = 55;
const TILE_MALL_3                     = 56;
const TILE_MALL_4                     = 57;
const TILE_MALL_5                     = 58;
const TILE_MALL_6                     = 59;
const TILE_MALL_7                     = 60;
const TILE_MALL_8                     = 61;
const TILE_MALL_9                     = 62;
const TILE_MALL_10                    = 63;
const TILE_MALL_11                    = 64;
const TILE_MALL_12                    = 65;
const TILE_MALL_13                    = 66;
const TILE_MALL_14                    = 67;
const TILE_MALL_15                    = 68;
const TILE_MALL_16                    = 69;
const TILE_MALL_17                    = 70;
const TILE_MALL_18                    = 71;
const TILE_MALL_19                    = 72;
const TILE_MALL_20                    = 73;
const TILE_MALL_21                    = 74;
const TILE_MALL_22                    = 75;

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
const ENTITY_TREE                     = 16;
const ENTITY_TREE_BUNDLE              = 17;
const ENTITY_MANHOLE                  = 18;
const ENTITY_MANHOLE_OPEN             = 19;
const ENTITY_ROAD_BLOCK               = 20;
const ENTITY_JOYSTICK_OFF             = 21;
const ENTITY_JOYSTICK_ON              = 22;
const ENTITY_LAMP                     = 23;
const ENTITY_BENCH                    = 24;
const ENTITY_BUS_STOP                 = 25;
const ENTITY_BIN											= 26;

const FLOATING_TILE_NONE							= 0;
const FLOATING_TILE_VOID							= 1;
const FLOATING_TILE_HALF_VOID					= 2;
const FLOATING_TILE_SHOP_0						= 3;
const FLOATING_TILE_SHOP_1						= 4;
const FLOATING_TILE_SEWER_WALL				= 5;

const EVENT_NONE                      = 0;
const LOAD_GAME_MAIN                  = 1;
const LOAD_GAME_COLOR                 = 2;
const LOAD_GAME_CLIMBING              = 3;
const LOAD_GAME_REGISTER              = 4;
const LOAD_GAME_WORD_CONNECT          = 5;
const LOAD_GAME_CIPHER                = 6;
const LOAD_GAME_MAGIC_SQUARE          = 7;
const LOAD_LEVEL_PARK_2               = 8;
const EVENT_SLIDE_COMPLETE            = 9;

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
	{ xt: 8, yt: 4 }, // TILE_SAND_PATH_0
	{ xt: 8, yt: 5 }, // TILE_SAND_PATH_1
	{ xt: 8, yt: 6 }, // TILE_SAND_PATH_2
	{ xt: 9, yt: 6 }, // TILE_SAND_PATH_3
	{ xt: 10, yt: 6 }, // TILE_SAND_PATH_4
	{ xt: 10, yt: 5 }, // TILE_SAND_PATH_5
	{ xt: 9, yt: 4 }, // TILE_SAND_PATH_6
	{ xt: 10, yt: 4 }, // TILE_SAND_PATH_7
	{ xt: 11, yt: 4 }, // TILE_TREE_BORDER_0
	{ xt: 12, yt: 4 }, // TILE_TREE_BORDER_1
	{ xt: 13, yt: 4 }, // TILE_TREE_BORDER_2
	{ xt: 11, yt: 5 }, // TILE_TREE_BORDER_3
	{ xt: 13, yt: 5 }, // TILE_TREE_BORDER_4
	{ xt: 11, yt: 6 }, // TILE_TREE_BORDER_5
	{ xt: 12, yt: 6 }, // TILE_TREE_BORDER_6
	{ xt: 13, yt: 6 }, // TILE_TREE_BORDER_7
	{ xt: 8, yt: 7 }, // TILE_TREE_BORDER_8
	{ xt: 9, yt: 7 }, // TILE_TREE_BORDER_9
	{ xt: 10, yt: 7 }, // TILE_TREE_BORDER_10
	{ xt: 8, yt: 8 }, // TILE_TREE_BORDER_11
	{ xt: 10, yt: 8 }, // TILE_TREE_BORDER_13
	{ xt: 8, yt: 9 }, // TILE_TREE_BORDER_14
	{ xt: 9, yt: 9 }, // TILE_TREE_BORDER_15
	{ xt: 10, yt: 9 }, // TILE_TREE_BORDER_16
	{ xt: 3, yt: 8 }, // TILE_ROAD_0
	{ xt: 4, yt: 8 }, // TILE_ROAD_1
	{ xt: 3, yt: 9 }, // TILE_ROAD_2
	{ xt: 4, yt: 9 }, // TILE_ROAD_3
	{ xt: 6, yt: 4 }, // TILE_INVISLBE
	{ xt: 7, yt: 4 }, // TILE_INVISLBE_SOLID
	{ xt: 3, yt: 11 }, // TILE_SEWER_LADDER_0
	{ xt: 3, yt: 12 }, // TILE_SEWER_LADDER_1
	{ xt: 3, yt: 13 }, // TILE_SEWER_WALL
	{ xt: 6, yt: 12 }, // TILE_SEWER_WATER
	{ xt: 5, yt: 12 }, // TILE_SEWER_FLOOR
	{ xt: 4, yt: 13 }, // TILE_SEWER_BRIDGE_0
	{ xt: 5, yt: 13 }, // TILE_SEWER_BRIDGE_1
	{ xt: 6, yt: 13 }, // TILE_SEWER_BRIDGE_2
	{ xt: 7, yt: 13 }, // TILE_SEWER_BRIDGE_3
	{ xt: 0, yt: 14 }, // TILE_MALL_0        
	{ xt: 1, yt: 14 }, // TILE_MALL_1        
	{ xt: 2, yt: 14 }, // TILE_MALL_2        
	{ xt: 3, yt: 14 }, // TILE_MALL_3        
	{ xt: 7, yt: 14 }, // TILE_MALL_7  
	
	{ xt: 0, yt: 15 }, // TILE_MALL_8        
	{ xt: 1, yt: 15 }, // TILE_MALL_9        
	{ xt: 2, yt: 15 }, // TILE_MALL_10       
	{ xt: 3, yt: 15 }, // TILE_MALL_11       
	{ xt: 4, yt: 15 }, // TILE_MALL_12       
	{ xt: 5, yt: 15 }, // TILE_MALL_13       
	{ xt: 6, yt: 15 }, // TILE_MALL_14       
	{ xt: 7, yt: 15 }, // TILE_MALL_15   
	
	{ xt: 0, yt: 16 }, // TILE_MALL_16       
	{ xt: 1, yt: 16 }, // TILE_MALL_17       
	{ xt: 2, yt: 16 }, // TILE_MALL_18       
	{ xt: 3, yt: 16 }, // TILE_MALL_19       
	{ xt: 4, yt: 16 }, // TILE_MALL_20        
	{ xt: 4, yt: 17 }, // TILE_MALL_21         
	{ xt: 5, yt: 16 }, // TILE_MALL_22     
];                        

const floating_tile_dict = [
	{ xt: 0, yt: 0, }, // FLOATING_TILE_NONE
	{ xt: 7, yt: 1, }, // FLOATING_TILE_VOID
	{ xt: 8, yt: 0, }, // FLOATING_TILE_HALF_VOID
	{ xt: 6, yt: 2, }, // FLOATING_TILE_SHOP_0
	{ xt: 11, yt: 0 }, // FLOATING_TILE_SHOP_1
	{ xt: 4, yt: 12 },  // FLOATING_TILE_SEWER_WALL        
	{ xt: 4, yt: 14 }, // FLOATINT_TILE_TILE_MALL_4        
	{ xt: 5, yt: 14 }, // FLOATINT_TILE_TILE_MALL_5        
	{ xt: 6, yt: 14 } // FLOATINT_TILE_TILE_MALL_6
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
	{ xt: 0, yt: 2, w: 2, h: 2 },		// ENTITY_BOARD										
	{ xt: 0, yt: 4, w: 2, h: 1 },  	// ENTITY_MAGIC_SQUARE          
	{ xt: 5, yt: 2, w: 1, h: 2 },  	// ENTITY_TREE          
	{ xt: 12, yt: 0, w: 2, h: 3 },  // ENTITY_TREE_BUNDLE  
	{ xt: 2, yt: 2, w: 2, h: 1 },  	// ENTITY_MANHOLE      
	{ xt: 2, yt: 3, w: 3, h: 1 },  	// ENTITY_MANHOLE_OPEN 	
	{ xt: 10, yt: 10, w: 2, h: 3 },  	// ENTITY_ROAD_BLOCK
	{ xt: 3, yt: 10, w: 1, h: 1 }, // ENTITY_JOYSTICK_OFF
	{ xt: 4, yt: 10, w: 1, h: 1 }, // ENTITY_JOYSTICK_ON
	{ xt: 5, yt: 8, w: 1, h: 3 }, // ENTITY_LAMP                     
	{ xt: 6, yt: 8, w: 2, h: 1 }, // ENTITY_BENCH                     
	{ xt: 7, yt: 9, w: 1, h: 2 }, // ENTITY_BUS_STOP             
	{ xt: 6, yt: 9, w: 1, h: 1 } // ENTITY_BIN  
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

function new_load_trigger(x, y, w, h, lvl)
{
	return {
			x: x,
			y: y,
			w: w,
			h: h,
			lvl: lvl
	};
}

function draw_map(display, sprite_map, map, entity_list, floating_tile_list, load_trigger_list)
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
	
	for (let i = 0; i < load_trigger_list.length; i++) {
		let load_trigger = load_trigger_list[i];
		
		display.drawImage(
			sprite_map,
			0 * SPRITE_SIZE,
			1 * SPRITE_SIZE,
			SPRITE_SIZE,
			SPRITE_SIZE,
			load_trigger.x * TILE_SIZE,
			load_trigger.y * TILE_SIZE,
			load_trigger.w * TILE_SIZE,
			-load_trigger.h * TILE_SIZE
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
	let load_trigger_list = [];
	
	let mouse_down = false;
	let xt = 0;
	let yt = 0;
	
	document.getElementById("fill").addEventListener("click", function(e)
	{
		for (let i = 0; i < MAP_SIZE * MAP_SIZE; i++) {
			map[i] = tile;
		}
		
		draw_map(display, sprite_map, map, entity_list, floating_tile_list, load_trigger_list);
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
		
		save.value += load_trigger_list.length.toString() + " ";
		
		for (let i = 0; i < load_trigger_list.length; i++) {
			save.value += load_trigger_list[i].lvl + " ";
			save.value += load_trigger_list[i].x + " ";
			save.value += load_trigger_list[i].y + " ";
			save.value += load_trigger_list[i].w + " ";
			save.value += load_trigger_list[i].h + " ";
		}
	});
	
	document.getElementById("update").addEventListener("click", function(e)
	{
		let save = document.getElementById("code");
		
		let map_data = save.value.split(' ').map(function(item) {
				return parseInt(item, 10);
		});
		
		entity_list = [];
		floating_tile_list = [];
		load_trigger_list = [];
		
		let data_ptr = 0;
		
		let map_width = map_data[data_ptr++];
		let map_height = map_data[data_ptr++];
		
		for (let i = 0; i < map_width * map_height; i++)
			map[i] = map_data[data_ptr++];
		
		let entity_count = map_data[data_ptr++];
		
		for (let i = 0; i < entity_count; i++) {
			let type = map_data[data_ptr + 0];
			let x = map_data[data_ptr + 1];
			let y = map_data[data_ptr + 2];
			
			entity_list.push(new_entity(x, y, type));
			
			data_ptr += 3;
		}
		
		let floating_tile_count = map_data[data_ptr++];
		
		for (let i = 0; i < floating_tile_count; i++) {
			let floating_tile = map_data[data_ptr + 0];
			let x = map_data[data_ptr + 1];
			let y = map_data[data_ptr + 2];
			
			floating_tile_list.push(new_floating_tile(x, y, floating_tile));
			
			data_ptr += 3;
		}
		
		let load_trigger_count = map_data[data_ptr++];
		
		for (let i = 0; i < load_trigger_count; i++) {
			let lvl = map_data[data_ptr + 0];
			let x = map_data[data_ptr + 1];
			let y = map_data[data_ptr + 2];
			let w = map_data[data_ptr + 3];
			let h = map_data[data_ptr + 4];
			
			load_trigger_list.push(new_load_trigger(x, y, w, h, lvl));
			
			data_ptr += 5;
		}
		
		draw_map(display, sprite_map, map, entity_list, floating_tile_list, load_trigger_list);
	});
	
	document.getElementById("display").addEventListener("mousemove", function(e)
	{
		if (mouse_down) {
			let x = get_tile_space(e.offsetX);
			let y = get_tile_space(e.offsetY);
			
			if (tile != TILE_NONE)
				map[x + y * MAP_SIZE] = tile;
			
			draw_map(display, sprite_map, map, entity_list, floating_tile_list, load_trigger_list);
		}
	});
	
	document.getElementById("display").addEventListener("mousedown", function(e)
	{
		let x = get_tile_space(e.offsetX);
		let y = get_tile_space(e.offsetY);
		
		console.log(x, y);
		
		if (e.button == MBUTTON_LEFT) {
			if (tile != TILE_NONE)
				map[x + y * MAP_SIZE] = tile;
			else if (entity != ENTITY_NONE)
				entity_list.push(new_entity(x, y + 1, entity));
			else if (floating_tile != FLOATING_TILE_NONE)
				floating_tile_list.push(new_floating_tile(x, y, floating_tile));
			else if (xt == 0 && yt == 1) {
				let w = parseInt(document.getElementById("trigger_width").value);
				let h = parseInt(document.getElementById("trigger_height").value);
				
				let level = parseInt(document.getElementById("trigger_level").value);
				
				load_trigger_list.push(new_load_trigger(x, y + 1, w, h, level));
			}
			
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
			for (let i = 0; i < load_trigger_list.length; i++) {
				console.log(load_trigger_list, x, y);
				if (load_trigger_list[i].x == x && load_trigger_list[i].y == y + 1) {
					load_trigger_list.splice(i, 1);
				}
			}
		}
		
		draw_map(display, sprite_map, map, entity_list, floating_tile_list, load_trigger_list);
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
	
	draw_map(display, sprite_map, map, entity_list, floating_tile_list, load_trigger_list);
	sprite_select.fillRect(0, 0, SPRITE_MAP_SIZE * SCALE, SPRITE_MAP_SIZE * SCALE);
	sprite_select.drawImage(sprite_map, 0, 0, SPRITE_MAP_SIZE * SCALE, SPRITE_MAP_SIZE * SCALE);
}

(function() {
	
	let sprite_map = new Image();
	sprite_map.src = 'sprite_map.png';
	
	sprite_map.onload = function(e) {
		start(sprite_map);
	};
})();
