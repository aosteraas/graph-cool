//
//  ImagesViewController.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 21/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI
import UIKit
import Apollo


struct PageViewController : UIViewControllerRepresentable {
    var controllers: [UIViewController]
    @State public var imageData: GetImagesQuery.Data?
    
    func makeUIViewController(context: Context) -> UIPageViewController {
        let pageViewController = UIPageViewController(
           transitionStyle: .scroll,
           navigationOrientation: .horizontal)

        return pageViewController
    }
    
    func updateUIViewController(_ pageViewController: UIPageViewController, context: Context) {
        pageViewController.setViewControllers(
            [controllers[0]], direction: .forward, animated: true)
    }
    
    func fetchData() {
        apollo.fetch(query: GetImagesQuery()) { result in
            guard let data = try? result.get().data else { return }
            self.imageData = data
            switch result {
                case.success(let result):
                    print(result)
                case.failure(let error):
                    print(error)

            }
        }
    }

}
