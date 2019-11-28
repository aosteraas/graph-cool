//
//  RemoteImage.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 24/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI
import UIKit
import Combine
import Foundation

struct ImageLoadingView: View {
    @ObservedObject private var imageLoader: ImageLoader
    private static var placeholder: Image = Image(uiImage: UIImage(named: "logo.png")!)
    init(url: URL) {
        imageLoader = ImageLoader(url: url)
     
    }
    
    var body: some View {
        ZStack {
            if (imageLoader.image == nil) {
                ImageLoadingView.placeholder
                .resizable()
                .aspectRatio(contentMode: .fill)
            } else {
                Image(uiImage: imageLoader.image!)
                .resizable()
                .aspectRatio(contentMode: .fill)
            }
        }
        .onAppear(perform: imageLoader.load)
        .onDisappear(perform: imageLoader.cancel)
    }
}

final class ImageLoader: ObservableObject {
    enum ImageLoadingError: Error {
        case incorrectData
    }
        let objectWillChange = ObservableObjectPublisher()

    @Published private(set) var image: UIImage? = nil {
        willSet {
            objectWillChange.send()
        }
    }
    
    private let url: URL
    private var cancellable: AnyCancellable?
    
    init(url: URL) {
        self.url = url
    }
    
    deinit {
        cancellable?.cancel()
    }
    
    func load() {
        cancellable = URLSession
            .shared
            .dataTaskPublisher(for: url)
            .tryMap { data, _ in
                guard let image = UIImage(data: data) else {
                    throw ImageLoadingError.incorrectData
                }
                
                return image
            }
            .receive(on: DispatchQueue.main)
            .sink(
                receiveCompletion: { _ in },
                receiveValue: { [weak self] image in
                    self?.image = image

                    
                }
            )
    }
    
    func cancel() {
        cancellable?.cancel()
    }
}
