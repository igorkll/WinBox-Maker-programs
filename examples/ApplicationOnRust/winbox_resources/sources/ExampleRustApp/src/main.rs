use pixels::{Pixels, SurfaceTexture};
use winit::{
    event::{Event, WindowEvent},
    event_loop::{ControlFlow, EventLoop},
    window::{Fullscreen, WindowBuilder},
};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    let event_loop = EventLoop::new();
    let window = WindowBuilder::new()
        .with_title("ExampleRustApp")
        .with_fullscreen(Some(Fullscreen::Borderless(None)))
        .build(&event_loop)?;
    let size = window.inner_size();
    let surface_texture = SurfaceTexture::new(size.width, size.height, &window);
    let width = size.width;
    let height = size.height;
    let mut pixels = Pixels::new(size.width, size.height, surface_texture)?;

    event_loop.run(move |event, _, control_flow| {
        *control_flow = ControlFlow::Wait;
        match event {
            Event::WindowEvent { event, .. } => match event {
                WindowEvent::CloseRequested => {
                    *control_flow = ControlFlow::Exit;
                }
                _ => {}
            },
            Event::MainEventsCleared => {
                window.request_redraw();
            }
            Event::RedrawRequested(_) => {
                let frame = pixels.frame_mut();
                
                // It's wrong to make gradients this way. this is just an example of a canvas in rust. in a real application, you need to use shaders.
                for y in 0..height {
                    for x in 0..width {
                        let i = ((y * width + x) * 4) as usize;
                        let r = (x * 255 / width) as u8;
                        let g = 0;
                        let b = (255 - r) as u8;
                        frame[i] = r;
                        frame[i + 1] = g;
                        frame[i + 2] = b;
                        frame[i + 3] = 255;
                    }
                }

                if pixels.render().is_err() {
                    *control_flow = ControlFlow::Exit;
                }
            }
            _ => {}
        }
    });
}
